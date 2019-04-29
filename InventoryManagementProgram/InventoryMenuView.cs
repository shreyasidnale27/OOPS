// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryMenuView.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for user to view inventory 
    /// </summary>
    public class InventoryMenuView
    {
        /// <summary>
        /// Inventories the menu view.
        /// </summary>
        /// <param name="inventoryType">Type of the inventory.</param>
        public static void InventoryMenuview(string inventoryType)
        {
            int option = 0;
            while (true)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Choose an Option");
                Console.WriteLine("0) To Go Back");
                Console.WriteLine("1) To view Existing Inventory for " + inventoryType);
                Console.WriteLine("2) To Remove an " + inventoryType + " Item");
                Console.WriteLine("3) To Add " + inventoryType + " Item");
                Console.WriteLine("4) To Edit from Existing " + inventoryType + " Inventory");

                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                //// Calls the mdethods based on the Option Choosen
                switch (option)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            InventoryManager.GetInventoryList(inventoryType);
                            break;
                        }

                    case 2:
                        {
                            InputsForInventory.TakeInputForRemovingObject(inventoryType);
                            break;
                        }

                    case 3:
                        {
                            InputsForInventory.TakeInputsForCreatingObject(inventoryType);
                            break;
                        }

                    case 4:
                        {
                            InventoryManipulationView.InventoryManipulationview(inventoryType);
                            break;
                        }
                }
            }
        }
    }
}
