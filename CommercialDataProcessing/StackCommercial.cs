﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.CommersialDataProcessing
{
    public class StackCommercial
    {
         /// <summary>
        /// The top is index of top element in stack
        /// </summary>
        private static int top;

        /// <summary>
        /// The maximum is the size stack
        /// </summary>
        private static int maximum;

        /// <summary>
        /// My list is array to store stack elements
        /// </summary>
        private string[] myList;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Stack{T}"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public void StackCommercial1(int size)
        {
            this.myList = new string[size];
            top = -1;
            maximum = size;
        }

        /// <summary>
        /// Pushes elements into stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void PushIntoStack(string data)
        {
            try
            {
                if (top == (maximum - 1))
                {
                    Console.WriteLine("Stack is full ");
                }
                else
                {
                    this.myList[++top] = data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Pop elements from stack.
        /// </summary>
        /// <returns>true if pop element from stack</returns>
        public bool PopFromStack()
        {
            if (this.IsEmpty())
            {
                return false;
            }
            else
            {
                top--;
                return true;
            }
        }

        /// <summary>
        /// Prints the stack.
        /// </summary>
        public void PrintStack()
        {
            try
            {
                if (this.IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                }
                else
                {
                    foreach (string i in this.myList)
                    {
                        Console.WriteLine("Element" + (top++) + "]->" + i);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
