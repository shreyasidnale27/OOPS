using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;


namespace Object_Oriented_Programming.CommersialDataProcessing
{
    class FileOperation
    {
        /// <summary>
        /// Reads from file.
        /// </summary>
        /// <returns>List of CompanyShares</returns>
        public static List<SharesOfCompany> ReadFromFile()
        {
            CommercialLinkedlist<SharesOfCompany> sharesLinkedList = new CommercialLinkedlist<SharesOfCompany>();
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json");

                ////Getting List<CompanyShares> object from JsonFile.
                List<SharesOfCompany> jsonObjectArray = JsonConvert.DeserializeObject<List<SharesOfCompany>>(jsonData);

                ////Adding All the CompanyShares Object to CustomLinkedLsit.
                foreach (SharesOfCompany cs in jsonObjectArray)
                {
                    sharesLinkedList.Add(cs);
                }

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new List<SharesOfCompany>();
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="companySharesList">The company shares list.</param>
        public static void WriteToFile(List<SharesOfCompany> companySharesList)
        {
            //// Converting Object to JSon String.
            string jsonData = JsonConvert.SerializeObject(companySharesList);

            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json", jsonData);
        }

        /// <summary>
        /// Reads the stock symbols.
        /// </summary>
        /// <returns>returns Stack</returns>
        public static StackCommercial ReadStockSymbols()
        {
            StackCommercial symbolStack = new StackCommercial();
            symbolStack.StackCommercial1(1000);

            ////Getting List Of StocksList
            List<SharesOfCompany> stocksList = ReadFromFile();

            //// Pushing all StockSymbol in Custom Stack.
            foreach (SharesOfCompany companyShares in stocksList)
            {
                symbolStack.PushIntoStack(companyShares.Symbol);
            }

            return symbolStack;
        }

        /// <summary>
        /// Writes the symbol.
        /// </summary>
        /// <param name="symbolStack">The symbol stack.</param>
        public static void WriteSymbol(StackCommercial symbolStack)
        {
            List<string> symbolList = new List<string>();
            while (!symbolStack.IsEmpty())
            {
                symbolList.Add(symbolStack.PopFromStack());
            }

            string jsonData = JsonConvert.SerializeObject(symbolList);

            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\SymbolPurchased.json", jsonData);
        }
    }
}
