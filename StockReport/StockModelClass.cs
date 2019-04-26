// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockModelClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.StockReport
{
    using System;

    /// <summary>
    /// class for attribute model use for stock
    /// </summary>
    public class StockModelClass
    {
        /// <summary>
        /// The stock name
        /// </summary>
        private string stockName;

        /// <summary>
        /// The no of shares
        /// </summary>
        private int numberOfShares;

        /// <summary>
        /// The share total price
        /// </summary>
        private long shareCost;

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get
            {
                return this.stockName;
            }

            set
            {
                this.stockName = value;
            }
        }

        /// <summary>
        /// Gets or sets the no of shares.
        /// </summary>
        /// <value>
        /// The no of shares.
        /// </value>
        public int NumberOfShares
        {
            get
            {
                return this.numberOfShares;
            }

            set
            {
                this.numberOfShares = value;
            }
        }

        /// <summary>
        /// Gets or sets the share total prize.
        /// </summary>
        /// <value>
        /// The share total prize.
        /// </value>
        public long ShareCost
        {
            get
            {
                return this.shareCost;
            }

            set
            {
                this.shareCost = value;
            }
        }
    }
}