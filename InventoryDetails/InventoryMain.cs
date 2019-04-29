// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryDetails
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// class main inventory for read and display elements
    /// </summary>
    public class InventoryMain
    {
        /// <summary>
        /// inventory data managements this instance
        /// </summary>
        public void DisplayAllData()
        {
            try
            {
                //// Reads the file from which is json format
                
                AllFilePaths paths = new AllFilePaths();
                List<InventoryModelClass> items = InventoryMain.ReadFile(paths.InventoryItems);
                Console.WriteLine("Name\tweight\tRate\tAmount");

                //// for loop to iterate a data from json file
                foreach (var item in items)
                {
                    Console.WriteLine("{0}" + "\t" + "{1}" + " \t" + "{2}" + "\t" + "{3}", item.Name, item.Weight, item.Priceperkg, item.Priceperkg * item.Weight);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Reads the file from Java Script Object Notation.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>returns items in inventory</returns>
        public static List<InventoryModelClass> ReadFile(string fileName)
        {
            ////StreamReader is  used to read from the file
            using (StreamReader read = new StreamReader(fileName))
            {
                var json = read.ReadToEnd();

                //// deserialize data into .net because it is in json format
                var items = JsonConvert.DeserializeObject<List<InventoryModelClass>>(json);
                return items;
            }
        }
    }
}