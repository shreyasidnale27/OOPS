using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Orienetd_Programming.DeckOfCards
{
   public class DeckCardQueue<T>
    {
        /// <summary>
        /// The list is an integer instance of the Linked List
        /// </summary>
        public LinkedListQueue<T> list = new LinkedListQueue<T>();

        /// <summary>
        /// Insert elements into the queue.
        /// </summary>
        /// <param name="list1">The list1 is the list of element.</param>
        /// <param name="number">The number to be inserted into queue.</param>
        /// <returns>updated List</returns>
        public LinkedListQueue<T> EnQueue(List<T> list1, T number)
        {
            try
            {
                ////Add the data into the linked list
                this.list = this.list.AddNodeAtLast1(list1, number, list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return this.list;
        }

        /// <summary>
        /// Removes elements from the queue.
        /// </summary>
        /// <param name="list1">The list1 is the instance of the linked list.</param>
        /// <param name="list">The list is the list of elements.</param>
        /// <returns>updated linked list</returns>
        public LinkedListQueue<T> DeQueue(LinkedListQueue<T> list, List<T> list1)
        {
            try
            {
                T number;

                ////remove top element from the linked list
                number = list.DeleteFirst1();

                //// add that removed node from 
                list.AddNodeAtFirst1(list1, number, list);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return list;
        }
    }
}
