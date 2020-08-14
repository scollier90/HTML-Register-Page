using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declared, not assigned a value
            bool isDeclared;

            // Assign it a value, based on type
            isDeclared = true;

            //-- Characters (char)
            // To define a single character, make sure to use single quotes ('')
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char underscore = '_';
            char spedcialCharacter = '\n';

            //-- Whole Numbers
            // Here we just have a lot of whole numbers
            // You don't have to go into much detail, it's just nice to show the students there are options
            byte byteExample = 255;
            sbyte sByteMax = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = -10;

            byte age = 25;

            //-- Decimals
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.25789907289072890457897897897897897m;

            float myFloat = 4.503f;
            double myDouble = 4.503d;
            decimal myDecimal = 1.2598m;

            Console.WriteLine(1.25789907289072890457897897897897897f);
            Console.WriteLine(1.25789907289072890457897897897897897d);
            Console.WriteLine(1.25789907289072890457897897897897897m);
            Console.ReadKey();

            // Arrays
            string[] stringArray = { "Cozi", "Jenna", "Seth" };
            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 20;
            intArray[2] = 30;
            intArray[3] = 40;
            int[] intArray2 = { 1, 21, 34, 59 };

            // Lists
            List<string> townsInNewYork = new List<string> { "Huntington", "Melville", "Syracue", "Buffalo" };
            string specificTownInNewYork = townsInNewYork[3];
            foreach (var town in townsInNewYork)
            {
                Console.WriteLine(town);
            }
            Console.WriteLine("///");

            // Dictionaries
            Dictionary<string, int> townsWithTemperatures = new Dictionary<string, int>();
            townsWithTemperatures.Add("Indy", 90);
            townsWithTemperatures.Add("New York", 80);
            townsWithTemperatures.Add("Chicago", 75);
            foreach (var key in townsWithTemperatures.Keys)
            {
                Console.WriteLine(key + ", " + townsWithTemperatures[key]);
            }
            Console.ReadKey();
        }
    }
}
