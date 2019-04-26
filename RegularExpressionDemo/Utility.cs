// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Shreya Sidnale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Object_Orienetd_Programming.RegularExapressionDemo
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// utility for retrieve data
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Retrieves the data of user.
        /// </summary>
        /// <param name="fname">The fname.</param>
        /// <param name="lname">The lname.</param>
        /// <param name="mno">The mno.</param>
        /// <param name="date">The date.</param>
        public void RetrieveDataOfUser(string firstName, string lastName, string mobileNumber)
        {

            
            ////this is sentance for given requirements
            string message = "Hello <<name>>, We have your full name as <<full name>> in our system your contact number is <<91-xxxxxxxxx>>, Please,let us know in case of any clarification Thank you BridgeLabz <<dd/mm/yyyy>>.";

            //// give string to change the position of names
            string patternForName = "<<name>>";

            ////using showmatch static method of regularexexpression class to replace the pattern with valid data
            message = Utility.DisplayIfMatch(message, firstName, patternForName);

            ////Pattern for changing full name from the sentence       
            string patternForfame = "<<full name>>";

            ////using showmatch static method of regularexexpression class to replace the pattern with valid data
            message = Utility.DisplayIfMatch(message, firstName + " " + lastName, patternForfame);

            ////Pattern for changing mobile number from the sentence   
            string contactNumber = "<<91-xxxxxxxxx>>";

            ////using showmatch static method of regularexexpression class to replace the pattern with valid data
            message = Utility.DisplayIfMatch(message, "91" + " " + mobileNumber, contactNumber);

            ////Pattern for changing Currrent date from the sentence   
            string currentdate = "<<dd/mm/yyyy>>";
            string date = DateTime.Now.ToShortDateString();

            ////using showmatch static method of regularexexpression class to replace the pattern with valid data
            message = Utility.DisplayIfMatch(message, date.ToString(), currentdate);
            Console.WriteLine(message);
        }

        /// <summary>
        /// Shows the match.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="expression">The expression.</param>
        /// <param name="pattern">The pattern.</param>
        /// <returns>new string</returns>
        public static string DisplayIfMatch(string message, string expression, string pattern)
        {
            ////creating regex class object for passing pattern
            Regex rgx = new Regex(pattern);
            string newString = rgx.Replace(message, expression);
            return newString;
        }
    }
}
