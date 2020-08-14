using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int playableCharacter;
            int gameAct = 1;

            string characterOne;
            string characterTwo = "Stacie";

            bool isPoisoned;
            bool isParalyzed = true;

            float characterOneHP;
            float characterTwoHP = 10000;

            double bossTwelveHP;
            double bossFinalHP = 100000000;

            decimal poisonTick;
            decimal poisonTickPlus = 500.2m;

            bossTwelveHP = 1000000;

            Console.WriteLine(bossTwelveHP);
            Console.WriteLine(poisonTickPlus);
            Console.WriteLine(isParalyzed);

            string kingTextOne = "Welcome, adventurers. I am the king of this land, Soriel. You have traveled" +
                "far to tell me of tidings of the western world? Pray tell me of such news and sights" +
                "as you have seen. My scouts have not returned from their last venture and I worry there" +
                "may be something on the brink of catastrophy.";
            Console.WriteLine(kingTextOne);

            int birthYear = 1990;
            string birthYearMsg = "I was born in " + birthYear + "";

            Console.WriteLine(birthYearMsg);

        }
    }
}
