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
            int Input;
            Console.WriteLine("Welcome to the Grand Circus Casino! I'm your host, Grant Chirpus! Please select any number-sided die of your choosing:");
            Input = int.Parse(Console.ReadLine());

            return Input; //takes number selected and produces random generation of two numbers (Die1 and Die2) for next method

        }

        public static int Sum(int Die1, int Die2)
        {
            int Result = Die1 + Die2;

            if (DieSide1 + DieSide2 == 2) 
            {
                Console.WriteLine("Snake Eyes!");
            }

            else if (DieSide1 + DieSide2 == 7 || DieSide1 + DieSide2 ==11)
            {
                Console.WriteLine("Craps!");
            }

            else if (DieSide1 + DieSide2 ==12)
            {
                Console.WriteLine("Box Cars!");
            }
            return Result;

        }
    }
}
