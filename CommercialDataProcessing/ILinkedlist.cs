// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILinkedlist.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Oriented_Programming.CommersialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface ILinkedlist<T>
    {
        /// <summary>
        /// Adds the specified word.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>returns true or false</returns>
        void AddNodeAtLast(T word);

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        bool IsEmpty();

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns>returns size</returns>
        long Size();

        /// <summary>
        /// Deletes the specified word to search.
        /// </summary>
        /// <param name="wordToSearch">The word to search.</param>
        /// <returns>returns true or false</returns>
        void DeleteAtPosition(T wordToSearch);

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="pos">The position.</param>
        /// <returns>returns true or false </returns>
        bool Insert(T data, long pos);

        /// <summary>
        /// Prints this instance.
        /// </summary>
        void Print();

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        bool Contains(T word);

    }
}