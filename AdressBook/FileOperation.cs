// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileOperation.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.AdressBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// class for Reading and Writing in class
    /// </summary>
    class FileOperation
    {
        /// <summary>
        /// Creates the address book file.
        /// </summary>
        /// <param name="addressBook">The address book.</param>
        public static void CreateAddressBookFile(AddressBook addressBook)
        {
            ////converting the AddressBook object to JSon File.
            string jsonAdddressBook = JsonConvert.SerializeObject(addressBook);

            //// checking the File path exist or not.
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json"))
            {
                Console.WriteLine("AddressBook with name : " + addressBook.AddressBookName + " already exist");
                return;
            }

            using (StreamWriter sw = new StreamWriter("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json"))
            {
                sw.Close();
                ////Writing to File.
                System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json", jsonAdddressBook);

                Console.WriteLine("Address Book with name " + addressBook.AddressBookName + " created");
            }
        }

        /// <summary>
        /// Gets the address book list.
        /// </summary>
        /// <returns>returns AddressBook List</returns>
        public static List<string> GetAddressBookList()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Users\\Bridge labz\\Desktop\\AddressBook");

            ////Getting All the filesName in list.
            FileInfo[] files = directoryInfo.GetFiles("*.json"); ////Getting json files
            List<string> fileNameArray = new List<string>();
            foreach (FileInfo file in files)
            {
                fileNameArray.Add(file.Name);
            }

            return fileNameArray;
        }

        /// <summary>
        /// Gets the book details.
        /// </summary>
        /// <param name="bookName">Name of the book.</param>
        /// <returns>returns AddressBook</returns>
        public static AddressBook GetBookDetails(string bookName)
        {
            string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + bookName + ".json");
            ////Getting the AddressBook Object of  given Name.
            AddressBook addressBook = JsonConvert.DeserializeObject<AddressBook>(jsonData);

            return addressBook;
        }

        /// <summary>
        /// Writes the address book to file.
        /// </summary>
        /// <param name="addressBook">The address book.</param>
        public static void WriteAddressBookToFile(AddressBook addressBook)
        {
            string jsonAdddressBook = JsonConvert.SerializeObject(addressBook);
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\AddressBook\\" + addressBook.AddressBookName + ".json", jsonAdddressBook);
        }
    }
}
