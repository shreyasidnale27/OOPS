// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// class Inventory Manager
    /// </summary>
    class InventoryManager
    {
        /// <summary>
        /// Gets the inventory list.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public static void GetInventoryList(string inventoryType)
        {
            ////Getting Inventory Objects from the inventory factory.
            InventoryTypes inventoryTypes = InventoryFactory.ReadJsonFile();

            if (inventoryType.Equals("RICE"))
            {
                List<RiceClass> riceList = inventoryTypes.RiceList;
                foreach (RiceClass rice in riceList)
                {
                    Console.WriteLine("Rice type");
                    Console.WriteLine("Name : " + rice.Name + "\nWeight : " + rice.Weight + "\nPrice per Kg : " + rice.PricePerKg);
                    Console.WriteLine("Total price of " + rice.Name + " = " + (rice.Weight * rice.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }

                return;
            }

            if (inventoryType.Equals("WHEAT"))
            {
                List<WheatClass> wheatList = inventoryTypes.WheatList;
                foreach (WheatClass wheat in wheatList)
                {
                    Console.WriteLine("Wheat type");
                    Console.WriteLine("Name : " + wheat.Name + "\nWeight : " + wheat.Weight + "\nPrice per Kg : " + wheat.PricePerKg);
                    Console.WriteLine("Total price of " + wheat.Name + " = " + (wheat.Weight * wheat.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }

                return;
            }

            if (inventoryType.Equals("PULSES"))
            {
                List<PulsesClass> pulsesList = inventoryTypes.PulsesList;
                foreach (PulsesClass pulse in pulsesList)
                {
                    Console.WriteLine("Pulse type");
                    Console.WriteLine("Name : " + pulse.Name + "\nWeight : " + pulse.Weight + "\nPrice per Kg : " + pulse.PricePerKg);
                    Console.WriteLine("Total price of " + pulse.Name + " = " + (pulse.Weight * pulse.PricePerKg));
                    Console.WriteLine("------------------------------------------");
                }
            }
        }
    }
}