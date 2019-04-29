// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
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
    /// class for stock details
    /// </summary>
    /// <seealso cref="Object_Oriented_Programming.CommersialDataProcessing.IStockDetails" />
    public class StockDetails: IStockDetails
    {
        /// <summary>
        /// The company shares list
        /// </summary>
        private CommercialLinkedlist<SharesOfCompany> companySharesList = new CommercialLinkedlist<SharesOfCompany>();

        /// <summary>
        /// Buys the specified number of shares.
        /// </summary>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="price">The price.</param>
        /// <param name="symbol">The symbol.</param>
        public void BuyShare(long numberOfShares, double price, string symbol)
        {
            List<SharesOfCompany> companySharesList = FileOperation.ReadFromFile();

            foreach (SharesOfCompany shares in companySharesList)
            {
                if (shares.Symbol.Equals(symbol))
                {
                    Console.WriteLine("You have already bought this share with symbol " + symbol);
                    return;
                }
            }

            string dateTime = DateTime.Now.ToString();
            SharesOfCompany companyShares = new SharesOfCompany(numberOfShares, price, symbol, dateTime);
            companySharesList.Add(companyShares);

            FileOperation.WriteToFile(companySharesList);
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            double totalValueOfAllStock = 0;
            List<SharesOfCompany> companySharesList = FileOperation.ReadFromFile();

            foreach (SharesOfCompany cs in companySharesList)
            {
                Console.WriteLine("StockName : " + cs.Symbol + "\nNumber of Shares: " + cs.NumberOfShares + "\nPrice Of each share: " + cs.PriceOfShare + "\nPurchased Date and Time : " + cs.DateTime);
                Console.WriteLine("Total Value Of Stock " + cs.Symbol + ": " + (cs.NumberOfShares * cs.PriceOfShare));
                Console.WriteLine("--------------------------------");

                totalValueOfAllStock = totalValueOfAllStock + (cs.NumberOfShares * cs.PriceOfShare);
            }

            Console.WriteLine("Total value Of all Stocks = " + totalValueOfAllStock);
        }

        /// <summary>
        /// Saves the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException">Handles and throws Exception</exception>
        public void SaveShares(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sells the specified symbol.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public void SellsOfShare(string symbol)
        {
            List<SharesOfCompany> companySharesList = FileOperation.ReadFromFile();
            foreach (SharesOfCompany companyShares in companySharesList)
            {
                if (companyShares.Symbol.Equals(symbol))
                {
                    companySharesList.Remove(companyShares);
                    Console.WriteLine("Share with Symbol " + symbol + "removed");
                    FileOperation.WriteToFile(companySharesList);
                    return;
                }
            }

            Console.WriteLine("stock with Symbol " + symbol + "does not exist");
        }

        /// <summary>
        /// Values the of.
        /// </summary>
        /// <returns> double value</returns>
        /// <exception cref="NotImplementedException">Handles and throws Exception</exception>
        public double ValueOf()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Stock account the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException"> Handles and throws Exception</exception>
        public void Stockaccount(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        public void PrintSymbols()
        {
            StackCommercial symbolStack = FileOperation.ReadStockSymbols();

            Console.WriteLine("Your Currently purchased Symbols are ");

            while (!symbolStack.IsEmpty())
            {
                Console.Write(symbolStack.PopFromStack() + " ");
            }
        }

        public double ValueOfStock()
        {
            throw new NotImplementedException();
        }

        void IStockDetails.StockDetails(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}