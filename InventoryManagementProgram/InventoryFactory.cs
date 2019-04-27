// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryManagementProgram
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Inventory Factory Class For Read File
    /// </summary>
    class InventoryFactory
    {
        /// <summary>
        /// Reads the json file.
        /// </summary>
        /// <returns>returns Inventory details</returns>
        public static InventoryTypes ReadJsonFile()
        {
            ////checks Wheather File Exist or Not.
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json");

                ////Getting the inventoryTypes Object from the  JSon String.
                InventoryTypes jsonObjectArray = JsonConvert.DeserializeObject<InventoryTypes>(jsonData);

                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new InventoryTypes();
            }
        }
    }
}
