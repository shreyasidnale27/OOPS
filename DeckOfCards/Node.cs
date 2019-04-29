using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Orienetd_Programming.DeckOfCards
{
    public class Node<T>
    {
        /// <summary>
        /// The data for holds data from node
        /// </summary>
        T data;

        /// <summary>
        /// The next for holds address of next node 
        /// </summary>
        Node<T> next;

        /// <summary>
        /// The previous for holds address of previous node
        /// </summary>
        Node<T> previous;

        public Node()
        {
            this.next = null;
            this.previous = null;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = null;
            this.previous = null;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="next">The next.</param>
        /// <param name="previous">The previous.</param>
        public Node(T data, Node<T> next, Node<T> previous)
        {
            this.data = data;
            this.next = null;
            this.previous = null;

        }

        /// <summary>
        /// Sets the data of node.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetData(T data)
        {
            this.data = data;
        }

        /// <summary>
        /// Gets the data of node.
        /// </summary>
        /// <returns></returns>
        public T GetData()
        {
            return this.data;
        }

        /// <summary>
        /// Sets the next of node.
        /// </summary>
        /// <param name="an">An.</param>
        public void SetNext(Node<T> an)
        {
            this.next = an;
        }

        /// <summary>
        /// Gets the next of node.
        /// </summary>
        /// <returns></returns>
        public Node<T> GetNext()
        {
            return this.next;
        }

        /// <summary>
        /// Sets the previous of node.
        /// </summary>
        /// <param name="bn">The bn.</param>
        public void SetPrevious(Node<T> bn)
        {
            this.previous = bn;
        }
    }
}
