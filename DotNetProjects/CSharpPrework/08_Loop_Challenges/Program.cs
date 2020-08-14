using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Loop_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            for (int i = 0; i <= number; i++)
                if (i % 15 == 0)
                {
                    Console.WriteLine(FizzBuzz);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(Fizz);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(Buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }

        } 
    }
}
