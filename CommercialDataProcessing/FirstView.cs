// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FirstView.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.CommercialDataProcessing
{
    using Object_Oriented_Programming.CommersialDataProcessing;
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class FirstView
    {
        /// <summary>
        /// Starts  the processing on shares.
        /// </summary>
        public void ShareProcessingStart()
        {
            StockDetails stocdetails = new StockDetails();
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1) To buy Share");
                Console.WriteLine("2) To Sell a Share");
                Console.WriteLine("3) To view Existing Shares");
                Console.WriteLine("4) View Stock Symobol Purchased");

                string stringOption = Console.ReadLine();

                if (InventoryManagementProgram.Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);

                //// Calls the method based on choosen option by the user.
                switch (option)
                {
                    case 1:
                        {
                            InputData.TakeUserInput(option);
                            break;
                        }

                    case 2:
                        {
                            InputData.TakeUserInput(option);
                            break;
                        }

                    case 3:
                        {
                            stocdetails.PrintReport();
                            break;
                        }

                    case 4:
                        {
                            StockDetails stockDetails = new StockDetails();
                            stockDetails.PrintSymbols();
                            break;
                        }

                    default:
                        {
                            return;
                        }
                }
            }
        }
    }
}