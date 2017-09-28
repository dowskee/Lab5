using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool RollAgain = true;
            while (RollAgain == true)
            {

                int DieSide1, DieSide2;

                DieSide1 = ReadInteger();

                DieSide2 = ReadInteger();

                // application asks user to enter number of sides for die
                // then application prompts user to roll die
                // application will roll two (n-sided) die, and display the result of each
                // application will ask if user wants to roll again 

                int Result = Sum(DieSide1, DieSide2); //sum returned as result
                Console.WriteLine(Result); //write result for user 

            }

            public static int ReadInteger()
            {
                int SideSelect;
                Console.WriteLine("Welcome to the Grand Circus Casino! I'm your host, Grant Chirpus! Please select any number-sided die of your choosing:");
                SideSelect = int.Parse(Console.ReadLine());

                return SideSelect; //takes number selected and produces random generation of two numbers (Die1 and Die2) for next method

            }

            public static int Sum(int Die1, int Die2)
            {
                int Result = Die1 + Die2;

                if (DieSide1 + DieSide2 == 2) //sum of 1+1 is 2, snake eyes
                {
                   Console.WriteLine("Snake Eyes!");
                }

                else if (DieSide1 + DieSide2 == 7 || DieSide1 + DieSide2 == 11)
                {
                   Console.WriteLine("Craps!"); //craps is total of 7 or 11
                }

                else if (DieSide1 == 6 && DieSide2 == 6)
                {
                   Console.WriteLine("Box Cars!"); //box cars returns two 6-faced die. 
                }
                    return Result;
                }
            

            string UserSelection;
            Console.WriteLine("Roll Again? (Y or N?)");
            UserSelection = Console.ReadLine();
            
            if ((UserSelection == "n") || (UserSelection == "N") || (UserSelection == "no") || (UserSelection == "No"))
            {
            RollAgain = false;
            Console.WriteLine("Your loss. House wins!");
            }
        }
    }
}
