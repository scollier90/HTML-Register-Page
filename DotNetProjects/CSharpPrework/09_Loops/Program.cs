using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int number = 0; // number is called a lopp control variable or (LCV)
                //2
            while(number <= 100)
            {
                //3
                Console.WriteLine(number);
                number = number + 5;
                //4
            }
            //5
            Console.ReadLine();

            int number = 100;

                //1          //2        //3
            for(int i = 1; i <= number; i++) // i is the loop control variable (LCV)
            {
                //4
                Console.WriteLine(i);
            }
        }
    }
}
