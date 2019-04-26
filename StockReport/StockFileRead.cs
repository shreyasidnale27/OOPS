// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockFileRead.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.StockReport
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// class for read file
    /// </summary>
   public class StockFileRead
    {
        /// <summary>
        /// Displays the stock Data.
        /// </summary>
        public void DisplayStocks()
        {
            try
            {
                StockFileRead stockRead = new StockFileRead();
                AllFilePaths path = new AllFilePaths();
                double totalStockCost = 0;

                if (File.Exists(path.StockData))
                {
                    ////read file data 
                    string readfile = File.ReadAllText(path.StockData);

                    ////convert data to .Net
                    StockModelClass[] stockData = JsonConvert.DeserializeObject<StockModelClass[]>(readfile);

                    ////Display Stock Data
                    for (int i = 1; i <= stockData.Length; i++)
                    {
                        Console.WriteLine("\n StockData {0}: \n", i);
                        Console.WriteLine("\n Stock Name  :{0}", stockData[i].StockName);
                        Console.WriteLine("\n Number Of Stocks :{0}", stockData[i].NumberOfShares);
                        Console.WriteLine("\n Cost Of Each Share :{0}", stockData[i].ShareCost);
                        Console.WriteLine("\n Total Share Cost :{0}", stockData[i].ShareCost * stockData[i].NumberOfShares);

                        ////Total Cost Share For All Stocks 
                        totalStockCost += stockData[i].ShareCost * stockData[i].NumberOfShares;
                    }

                    Console.WriteLine("Total Cost for Stock is:" + totalStockCost);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
