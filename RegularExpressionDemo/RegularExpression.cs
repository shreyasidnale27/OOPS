// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InputFromUser.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.RegularExapressionDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// class for taking input from user
    /// </summary>
    public class RegularExpression
    {
        RegularExapressionDemo.Utility utility = new RegularExapressionDemo.Utility();

        /// <summary>
        /// Reads the data.
        /// </summary>
        public void ReadData()
        {
            string firstName, lastName, mobileNumber;
            bool flag = false;
            ////validation for User Input
            do
            {
                ////take the first name from user
                Console.WriteLine("ENTER THE FIRST NAME");
                firstName = Console.ReadLine();
                if (!Regex.IsMatch(firstName, @"[a-zA-z]"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct FirstName");
                    flag = true;
                }
            } while (flag);

            do
            {
                ////Take the last name from user
                Console.WriteLine("ENTER THE LAST NAME");
                lastName = Console.ReadLine();
                if (!Regex.IsMatch(lastName, @"[a-zA-z]"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct LastName");
                    flag = true;
                }

            } while (flag);

            do
            {
                ////Take the mobile number from user
                Console.WriteLine("ENTER THE VALID MOBILE NUMBER");
                mobileNumber = Console.ReadLine();
                if (!Regex.IsMatch(mobileNumber, "^[0-9]{10}$"))
                {
                    Console.WriteLine("Enterd Wrong Input,Please Enter Correct mobileNumber");
                    flag = true;
                }
            } while (flag);

            ////create oject of datetime 
            DateTime thisDay = DateTime.Today;
            utility.RetrieveDataOfUser(firstName, lastName, mobileNumber);
        }
    }
}