// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressDetailsManipulationView.cs" company="Bridgelabz">
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
    /// class is for view of Address detail manipulation 
    /// </summary>
    class AddressDetailsManipulationView
    {
        /// <summary>
        /// Edits the details.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        public static void EditDetails(string bookName)
        {
            int option = 0;
            string nameToEdit = string.Empty;

            Console.WriteLine("Enter the First Name you want to edit");
            nameToEdit = Console.ReadLine();

            if (AddressBookModelClass.DoesNameExist(nameToEdit, bookName) == false)
            {
                Console.WriteLine("The Name You Entered Does not Exist");
                return;
            }

            Console.WriteLine("------------------------------------------");
            AddressBook.PrintSingleAddresss(bookName, nameToEdit);
            Console.WriteLine("------------------------------------------");

            while (true)
            {
                Console.WriteLine("Choose what you want to edit");
                Console.WriteLine("0) To Go back");
                Console.WriteLine("1) Address");
                Console.WriteLine("2) City");
                Console.WriteLine("3) State");
                Console.WriteLine("4) Zip");
                Console.WriteLine("5) PhoneNumber");
                string stringOption = Console.ReadLine();

                if (InventoryManagementProgram.Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                option = Convert.ToInt32(stringOption);

                ////calling the methods based on the Option Choosen.
                switch (option)
                {
                    case 0:
                        {
                            return;
                        }

                    case 1:
                        {
                            AddressDetailsManipulation.ChangeAddress(bookName, nameToEdit);
                            break;
                        }

                    case 2:
                        {
                            AddressDetailsManipulation.ChangeCity(bookName, nameToEdit);
                            break;
                        }

                    case 3:
                        {
                            AddressDetailsManipulation.ChangeState(bookName, nameToEdit);
                            break;
                        }

                    case 4:
                        {
                            AddressDetailsManipulation.ChangeZip(bookName, nameToEdit);
                            break;
                        }

                    case 5:
                        {
                            AddressDetailsManipulation.ChangePhoneNumber(bookName, nameToEdit);
                            break;
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
