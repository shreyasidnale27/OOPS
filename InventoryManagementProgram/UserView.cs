// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserView.cs" company="Bridgelabz">
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
    ///  class For First View For User
    /// </summary>
    class UserView
    {
        /// <summary>
        /// Starts the inventory manager.
        /// </summary>
        public void InventoryManagementMethod()
        {
            
            while (true)
            {
                Console.WriteLine("Select an Inventory from Below");
                Console.WriteLine("0) To exit");
                Console.WriteLine("1) Rice");
                Console.WriteLine("2) Wheat");
                Console.WriteLine("3) Pulses");
                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                int ch = Convert.ToInt32(stringOption);

                ////Calls the metods base on the Choosen option.
                switch (ch)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            InventoryMenuView.InventoryMenuview("RICE");
                            break;
                        }

                    case 2:
                        {
                            InventoryMenuView.InventoryMenuview("WHEAT");
                            break;
                        }

                    case 3:
                        {
                            InventoryMenuView.InventoryMenuview("PULSES");
                            break;
                        }
                }
            }
        }
    }
}
