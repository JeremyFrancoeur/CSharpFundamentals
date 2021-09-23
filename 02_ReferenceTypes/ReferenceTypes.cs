using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_ReferenceTypes
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void ReferenceTypeVariables()
        {
            //Strings
            string thisIsDeclaration;
            thisIsDeclaration = "This is initialized";

            string declarationAndInitialization = "this is both declaring and initializing a string";

            //Console.WriteLine("What is your first name?");
            //string firstName = Console.ReadLine();
            //Console.WriteLine(firstName);

            //String OperationS
            //Concatenation
            string concatenatedFullName;
            string firstName = "Jeremy";
            string lastName = "Francoeur";
            concatenatedFullName = firstName + ' ' + lastName; //Jeremy Francoeur
            Console.WriteLine(concatenatedFullName);

            //interpolation
            string interpolatedFullName = $"{firstName} {lastName}"; //Jeremy Francoeur
            Console.WriteLine(interpolatedFullName);

            //Collections
            List<string> listOfStrings = new List<strig>();
            listOfStrings.Add(firstName);
            listOfStrings.Add(lastName);

            //Array
            String[] arrayOfStrings = new string[8];
            string[] anotherArrayOfStrings = { firstName, lastName, "blahblah" };

            //Queue
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue(lastName);
            firstInFirstOut.Enqueue("this is my string added to my Queue");

            //Dictionary
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(7, "seven");
            Console.WriteLine(keyValuePairs[7]);

            //Other Types Collections
            SortedList<String, int> sortedKeyValuePairs = new SortedList<string, int>();
            Hashset<int> uniqueList = new Hashset<int>();
            Slack<string> lastInFirstOut = new Slack<string>();


            //Classes
            Random randomExample = new Random();

            int randomNumber = randomExample.Next();
            Console.WriteLine(randomNumber);

        }
    }
}
