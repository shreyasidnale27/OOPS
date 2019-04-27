// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressDetailsManipulation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.AdressBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// class for Adress details manipualtion
    /// </summary>
    public class AddressDetailsManipulation
    {
        /// <summary>
        /// Changes the address.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="nameToEdit">The name to edit.</param>
        public static void ChangeAddress(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New Address");
                string address = Console.ReadLine();

                if (Utility.CheckString(address))
                {
                    Console.WriteLine("Address Cant be Empty");
                    continue;
                }

                ////Getting the existing AddressBook from the file
                AddressBook addressBook = FileOperation.GetBookDetails(bookName);

                List<AddressBookModelClass> list = addressBook.AddressDetailsList;

                ////loops over all the Address Details and replaces the new addresses with old address.
                foreach (AddressBookModelClass addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.Address = address;
                        break;
                    }
                }

                FileOperation.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");

                break;
            }
        }

        /// <summary>
        /// Changes the city.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="nameToEdit">The name to edit.</param>
        public static void ChangeCity(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New City");
                string city = Console.ReadLine();

                if (!Regex.IsMatch(city, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                ////Getting the existing AddressBook from the file
                AddressBook addressBook = FileOperation.GetBookDetails(bookName);

                List<AddressBookModelClass> list = addressBook.AddressDetailsList;

                ////loops over all the Address Details and replaces the new City with old City.
                foreach (AddressBookModelClass addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.City = city;
                        break;
                    }
                }

                FileOperation.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        /// <summary>
        /// Changes the state.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="nameToEdit">The name to edit.</param>
        public static void ChangeState(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New State");
                string state = Console.ReadLine();

                if (!Regex.IsMatch(state, "^[a-zA-z]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                AddressBook addressBook = FileOperation.GetBookDetails(bookName);

                List<AddressBookModelClass> list = addressBook.AddressDetailsList;

                ////loops over all the Address Details and replaces the new state with old state.
                foreach (AddressBookModelClass addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.State = state;
                        break;
                    }
                }

                FileOperation.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        /// <summary>
        /// Changes the zip.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="nameToEdit">The name to edit.</param>
        public static void ChangeZip(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New Zip");
                string zip = Console.ReadLine();

                if (!Regex.IsMatch(zip, "^[0-9]+$"))
                {
                    Console.WriteLine("Wrong input,(Characters not allowed)");
                    continue;
                }

                AddressBook addressBook = FileOperation.GetBookDetails(bookName);

                List<AddressBookModelClass> list = addressBook.AddressDetailsList;

                ////loops over all the Address Details and replaces the new Zip with old Zip.
                foreach (AddressBookModelClass addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.Zip = zip;
                        break;
                    }
                }

                FileOperation.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        /// <summary>
        /// Changes the phone number.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="nameToEdit">The name to edit.</param>
        public static void ChangePhoneNumber(string bookName, string nameToEdit)
        {
            while (true)
            {
                Console.WriteLine("Enter the New phoneNumber");
                string phoneNumber = Console.ReadLine();

                if (!Regex.IsMatch(phoneNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Wrong input,(Characters,number not allowed)");
                    continue;
                }

                AddressBook addressBook = FileOperation.GetBookDetails(bookName);

                List<AddressBookModelClass> list = addressBook.AddressDetailsList;

                ////loops over all the Address Details and replaces the new PhoneNumber with old PhoneNumber.
                foreach (AddressBookModelClass addressDetail in list)
                {
                    if (addressDetail.FirstName.Equals(nameToEdit))
                    {
                        addressDetail.PhoneNumber = phoneNumber;
                        break;
                    }
                }

                FileOperation.WriteAddressBookToFile(addressBook);
                Console.WriteLine("Successfully updated");
                break;
            }
        }

        /// <summary>
        /// Sorts the last name of the by.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        public static void SortByLastName(string bookName)
        {
            AddressBook addressBook = FileOperation.GetBookDetails(bookName);

            List<AddressBookModelClass> list = addressBook.AddressDetailsList;

            ////sorting the Objects in list by lastname
            var sortedList = list.OrderBy(v => v.LastName);

            ////Printing to Console All details sorted by LastName
            foreach (AddressBookModelClass address in sortedList)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------");
            }
        }

        /// <summary>
        /// Sorts the by zip.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        public static void SortByZip(string bookName)
        {
            AddressBook addressBook = FileOperation.GetBookDetails(bookName);

            List<AddressBookModelClass> list = addressBook.AddressDetailsList;

            ////sorting the Objects in list by Zip
            var sortedList = list.OrderBy(v => v.Zip);

            ////Printing to Console All details sorted by Zip
            foreach (AddressBookModelClass address in sortedList)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------");
            }
        }
    }
}
