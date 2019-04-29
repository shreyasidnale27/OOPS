using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming.CommersialDataProcessing
{
    class Node<T>
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

        /// <summary>
        /// size for node
        /// </summary>
        private long position;

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
        /// <param name="position">The position.</param>
        public Node(T data, long position)
        {
            this.position = position;
            this.data = data;
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

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public long Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

    }
}
