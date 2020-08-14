﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Documents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;    //Int16
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            //Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.237909d; //VSC implicitly implies decimals as doubles
            decimal decimalExample = 1.70000m;

            //Characters
            char letter = 'j';  //single quotations ('') indicate a single 
            char space = ' ';

            //Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numOne * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;    //Called the modulus operator
            Console.WriteLine(remainder);

            Console.WriteLine("Hello");
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            //Strings
            string stringExample = "This is a string.";
            string name = "Joshua";

            string declared;
            declared = "Now it's initialized.";

            //-- Formatting strings
            string concatenate = stringExample + " " + name; //This is a string. Joshua
            string interpolate = $"{name}. Here is the string: {stringExample}";    // Joshua. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2020, 8, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);

            //Collections
            //-- Arrays
            string anotherExampleString = "Hello World";
            string[] stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[] students = new string[15];

            Console.WriteLine(students);

            //Lists
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Lawrence");

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("Luke");

            //Dictionaries
            Dictionary<char, string> keyValuePair = new Dictionary<char, string>();
            keyValuePair.Add('j', "Josh");

            //Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();
        }
    }
}
