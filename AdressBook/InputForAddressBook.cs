// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForAddressBook.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.AdressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for taking input from user for address book
    /// </summary>
    class InputForAddressBook
    {/// <summary>
     /// Takes the input for address book.
     /// </summary>
     /// <returns>returns string</returns>
        public static string TakeInputForAddressBook()
        {
            string addressBookName = string.Empty;
            while (true)
            {
                Console.WriteLine("Enter a Name for Address Book");
                addressBookName = Console.ReadLine();

                if (Utility.CheckString(addressBookName))
                {
                    Console.WriteLine("You have to Specify a name");
                    continue;
                }

                if (InventoryManagementProgram.Utility.ContainsCharacter(addressBookName))
                {
                    Console.WriteLine("No Special Characters allowed");
                    continue;
                }

                return addressBookName;
            }
        }
    }
}
