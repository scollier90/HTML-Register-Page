using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string topic = "Psychology";
            string first = "the cares we sell are ";
            string second = "BWM, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            //result: The cars we sell are BMW, Lexus, and Mercedes.

            string firstName = "Jenn";
            string lastName = "Williams";
            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);
            //result: Her name is Jenn Williams

            string firstName = "Robin;";
            string lastName = "Holler";
                                //1         //2
            Console.WriteLine($"Her name is {firstName} {lastName}");

            string firstName = "Alex";
            string lastName = "Farris";

            Console.WriteLine(firstName + lastName);
            Console.WriteLine("His name is {0} {1}.", firstName, lastName);
            Console.WriteLine($"His name is {firstName} {lastName}")


        }
    }
}
