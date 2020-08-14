using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace _2___Conditionals_Methods_Loops
{
    enum Genders ( Male = 1, Female = 2, Nonbinary = 3)
    class Program
    {
        static void Main(string[] args)
        {
            bool nickIsTired = true;
            if (nickIsTired)
            {
                Console.WriteLine("Go to bed!");
            }
            else
            {
                Console.WriteLine("Keep going bud");
            }


            int legalAge = 18;
            Console.WriteLine("what is your age?");
            string nicksAgeFromReadLine = Console.ReadLine();
            int nicksAge = Convert.ToInt32(nicksAgeFromReadLine);

            Console.WriteLine("What is your gender? 1 for male, 2 for female, 3 for nonbinary");
            string nicksGenerFromReadLine = Console.ReadLine();
            int nicksGenderValue = Convert.ToInt32(nicksGenerFromReadLine);

            switch (switch_on)
            {
                case 1:
                    Console.WriteLine("You're gender is " + Genders.Male.ToString());
                    break;
                case 2:
                    Console.WriteLine("You're gender is " + Genders.Female.ToString());
                    break;
                case 3:
                    Console.WriteLine("You're gender is " + Genders.Nonbinary.ToString());
                    break;
                default;
                    break;

            }
            if (nicksGenderValue == 1)
            {

            }
            else if (nicksGenderValue == 2)
            {

            }
            else if (nicksGenderValue == 3)
            {

            }
            
            if (nicksAge >= legalAge)
            {
                Console.WriteLine("You are above the legal age!");
            }
            else if(nicksAge == legalAge)
            {
                Console.WriteLine("You are of the legal age");
            }
            else
            {
                Console.WriteLine("You are not of the legal age");
            }
            Console.ReadKey();
        }
    }
}
