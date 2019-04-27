// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WriteToFile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryManagementProgram
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// class for write the contents into file
    /// </summary>
    class WriteToFile
    {
        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="inventoryTypes">The inventory types.</param>
        public static void WriteDataToFile(InventoryTypes inventoryTypes)
        {
            ////Converting InventoryTypes Object to Json String
            string jsonAdddressBook = JsonConvert.SerializeObject(inventoryTypes);
            ////Wrinting Json String to file.
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Inventory - Copy.json", jsonAdddressBook);
        }
    }
}
