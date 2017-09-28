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
            Random r = new Random();
            bool RollAgain = true;
            while (RollAgain == true)
            {

                Console.WriteLine("Welcome to the Grand Circus Casino! I'm your host, Grant Chirpus! Roll the dice? (Y/N?)");
                string Choice = Console.ReadLine();

                if ((Choice == "y") || (Choice == "Y") || (Choice == "yes") || (Choice == "Yes"))
                {
                    // application asks user to enter number of sides for die
                    // then application prompts user to roll die
                    // application will roll two (n-sided) die, and display the result of each
                    // application will ask if user wants to roll again 


                    Console.WriteLine("How many sides should each die have?");
                    int diceface = int.Parse(Console.ReadLine());
                    //SideSelect from second method needs to generate random faces for DieSide1 and DieSide2 to then be added
                    Console.WriteLine("You selected your dice to have " + diceface + " sides");

                    Console.WriteLine("You Rolled:");

                   
                    int DieSide1 = r.Next(1, diceface-1);
                    int DieSide2 = r.Next(1, diceface-1);

                    Console.WriteLine(DieSide1);
                    Console.WriteLine(DieSide2); //print random numbers
                    Random(DieSide1, DieSide2); //will return snake eyes, craps, box car. Call without using Console.WriteLine();

                }
                string UserSelection; //while loop from top for roll again prompt
                Console.WriteLine("Roll Again? (Y or N?)");
                UserSelection = Console.ReadLine();

                if ((UserSelection == "n") || (UserSelection == "N") || (UserSelection == "no") || (UserSelection == "No"))
                {
                    RollAgain = false;
                    Console.WriteLine("Your loss. House wins!");
                }
            }
        }
            public static void Random(int DieSide1, int DieSide2) //make void return type to cancel out integer return in main method
            {

                int Result = (DieSide1) & (DieSide2);
                

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
                
            }
        
    }
}
