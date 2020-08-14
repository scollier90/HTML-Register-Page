using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;
            
            //1 Starting point
            //2 Condition that while true, keeps the loop running
            //3 What happens after each loop
            //4 Body of the loop; what happens each iteration

            //for   //1         //2             //3
            for (int i = 0; i < studentCount; i++) //i = i + 1 is the same as i++
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";
            
            //1 Collection that is being worked on
            //2 Name of the current iteration being used
            //3 Current type in the collection
            //4 in keyword; used to separate the individual and the collection
            //5 Body of the loop

            //foreach //3  //2  //4 //1
            foreach (char letter in name)
            {
                //5
                Console.WriteLine(letter);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            //1 Loop runs while the condition is true
            //2 Body of the loop

            //While //1
            while (total != 30)
            {
                Console.WriteLine(total);
                total++;
            }
        }
    }
}
