// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming
{
    using System;

    /// <summary>
    /// program class for give choice to user
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            char condition;
            do
            {
                Console.WriteLine("PRESS: 1 TO Inventory Data Management For Grocery");
                Console.WriteLine("PRESS: 2 TO Regular Expression Demonstration");
                Console.WriteLine("PRESS: 3 TO STOCK OF COMPANY");
                Console.WriteLine("PRESS: 4 TO INVENTORY MANAGAMENTS");
                Console.WriteLine("PRESS: 5 TO DeckOfCards");
                Console.WriteLine("PRESS 6 TO ADDRESSBOOK");
                Console.WriteLine("PRESS 7 For DeckOfCards Using Queue");
                Console.WriteLine("PRESS 8 FOR COMMERCIAL DATA PROCESSING");

                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        InventoryDetails.InventoryMain details = new InventoryDetails.InventoryMain();
                        details.DisplayAllData();
                        break;
                    case 2:
                       RegularExapressionDemo.RegularExpression rx = new RegularExapressionDemo.RegularExpression();
                        rx.ReadData();
                        break;
                    case 3:
                        StockReport.StockFileRead stock = new StockReport.StockFileRead();
                        stock.DisplayStocks();
                        break;
                    case 4:
                        InventoryManagementProgram.UserView management = new InventoryManagementProgram.UserView();
                        management.InventoryManagementMethod();
                        break;
                    case 5:
                        DeckOfCards.DeckOfCards dc = new DeckOfCards.DeckOfCards();
                        dc.InitializeDeckOfCards();
                        break;
                    case 6:
                        AdressBook.AddressBookMethodCall addbook = new AdressBook.AddressBookMethodCall();
                        addbook.AddressBookstart();
                        break;
                    case 7:
                        DeckOfCards.DeckOfCards DeckCardsQueue = new DeckOfCards.DeckOfCards();
                        DeckCardsQueue.InitializeDeckOfCards();
                        break;


                }
                Console.WriteLine("enter 'Y' or 'y' if you want to continue:");
                condition = Convert.ToChar(Console.ReadLine());
            } while (condition == 'y' || condition == 'Y');
         
        }
    }
}

