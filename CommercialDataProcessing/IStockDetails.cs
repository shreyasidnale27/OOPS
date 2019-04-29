// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStockDetails.cs" company="Bridgelabz">
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

    /// <summary>
    /// interface for StockDetails
    /// </summary>
    public interface IStockDetails
    {
        /// <summary>
        /// Buys the specified number of shares.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="price">The price.</param>
        /// <param name="symbol">The symbol.</param>
        void BuyShare(long numberOfShares, double price, string symbol);

        /// <summary>
        /// Prints the report.
        /// </summary>
        void PrintReport();

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void SaveShares(string fileName);

        /// <summary>
        /// Sells the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>     
        void SellsOfShare(string symbol);

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <returns>returns double</returns>
        double ValueOfStock();

        /// <summary>
        /// Stock account the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void StockDetails(string fileName);

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        void PrintSymbols();
    }
}