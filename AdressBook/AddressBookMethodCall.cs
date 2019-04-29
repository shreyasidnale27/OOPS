// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookMethodCall.cs" company="Bridgelabz">
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
    /// class for choice for options 
    /// </summary>
    public class AddressBookMethodCall
    {
        /// <summary>
        /// Initialize the address book.
        /// </summary>
        public void AddressBookstart()
        {
            int option = 0;

            while (true)
            {
                Console.WriteLine("choose an option");
                Console.WriteLine("1) View Existing Address Book");
                Console.WriteLine("2) Create new Address  book");
                Console.WriteLine("3) To Exit ");
                string stringOption = Console.ReadLine();

                if (Utility.CheckString(stringOption))
                {
                    Console.WriteLine("Invalid Option choosen");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                ////calls the method Based on the Option Choosen.
                switch (option)
                {
                    case 1:
                        {
                            AddressBook.PrintExistingAddressBook();
                            break;
                        }

                    case 2:
                        {
                            string addressBookname = InputForAddressBook.TakeInputForAddressBook();
                            AddressBook.CreateAddressBook(addressBookname);
                            break;
                        }

                    case 3:
                        {
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }
        }
    }
}
