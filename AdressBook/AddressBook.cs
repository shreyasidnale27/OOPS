// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
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
    /// class for AdressBook
    /// </summary>
    public class AddressBook
    {
        /// <summary>
        /// The address book name   
        /// </summary>
        private string addressBookName;

        /// <summary>
        /// The address details list
        /// </summary>
        private List<AddressBookModelClass> addressDetailsList = new List<AddressBookModelClass>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressBook"/> class.
        /// </summary>
        /// <param name="addressBookName">Name of the address book.</param>
        public AddressBook(string addressBookName)
        {
            this.addressBookName = addressBookName;
        }

        /// <summary>
        /// Gets or sets the address details.
        /// </summary>
        /// <value>
        /// The address details.
        /// </value>
        public List<AddressBookModelClass> AddressDetailsList
        {
            get { return this.addressDetailsList; }
            set { this.addressDetailsList = value; }
        }

        /// <summary>
        /// Gets or sets the addressBookName.
        /// </summary>
        public string AddressBookName
        {
            get { return this.addressBookName; }
            set { this.addressBookName = value; }
        }

        /// <summary>
        /// Creates the address book.
        /// </summary>
        /// <param name="addressBookName">Name of the address book.</param>
        public static void CreateAddressBook(string addressBookName)
        {
            AddressBook addressBook = new AddressBook(addressBookName);
            FileOperation.CreateAddressBookFile(addressBook);
        }

        /// <summary>
        /// Prints the existing Address books
        /// </summary>
        public static void PrintExistingAddressBook()
        {
            int optionNumber = 1;
            int addressBookOption = 0;
            List<string> fileNameList = FileOperation.GetAddressBookList();

            while (true)
            {
                Console.WriteLine("Choose an address book to Open");
                Console.WriteLine("0) To Go back");

                //// Removes the extension name from all files.
                foreach (string filename in fileNameList)
                {
                    Console.WriteLine(optionNumber + " ) " + filename.Replace(".json", string.Empty));
                    optionNumber++;
                }

                optionNumber = 1;
                string stringaddressBookOption = Console.ReadLine();

                try
                {
                    addressBookOption = Convert.ToInt32(stringaddressBookOption);
                    if (addressBookOption == 0)
                    {
                        return;
                    }

                    GetBookName(addressBookOption);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("-----------------------------------------------");
                    continue;
                }
            }
        }

        /// <summary>
        /// Gets the name of the book.
        /// </summary>
        /// <param name="addressBookOption">The address book option.</param>
        public static void GetBookName(int addressBookOption)
        {
            try
            {
                ////Getting the All the names of Existing book in list.
                List<string> fileNameList = FileOperation.GetAddressBookList();

                string bookName = fileNameList[addressBookOption - 1].Replace(".json", string.Empty);

                ////Calling the method that will ask the user what to do with choosen Book
                AddressBookView.AddressbookView(bookName);

                AddressBook addressBook = FileOperation.GetBookDetails(bookName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Prints the address book details.
        /// </summary>
        /// <param name="addressBookName">Name of the address book.</param>
        public static void PrintAddressBookDetails(string addressBookName)
        {
            AddressBook addressBook = FileOperation.GetBookDetails(addressBookName);

            List<AddressBookModelClass> list = addressBook.addressDetailsList;

            //// Prints  details of all Persons in the addressBook
            foreach (AddressBookModelClass address in list)
            {
                Console.WriteLine(address.ToString());
                Console.WriteLine("----------------------------------------");
            }
        }

        /// <summary>
        /// Prints the single address.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <param name="firstName">The first name.</param>
        public static void PrintSingleAddresss(string bookName, string firstName)
        {
            AddressBook addressBook = FileOperation.GetBookDetails(bookName);

            List<AddressBookModelClass> list = addressBook.addressDetailsList;

            ////prints only one person details if found.
            foreach (AddressBookModelClass address in list)
            {
                if (address.FirstName.Equals(firstName))
                {
                    Console.WriteLine(address.ToString());
                    return;
                }
            }
        }
    }
}
