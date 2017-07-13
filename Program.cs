using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Test
{
    class Program
    {


        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Let's Play Roshambo!");
                Console.WriteLine("Please enter your name:");
                string name = Console.ReadLine();
                Console.WriteLine($"Welcome, {name}. Please select one of the followng opponents:");
                Console.WriteLine("");
                Console.WriteLine("Tommy"); //rock
                Console.WriteLine("Randy"); // random
                Console.WriteLine("");

                Game game = new Game();

                game.Play();

            } while (Continue() == true); 

        }
            public static Boolean Continue()
            {
                Boolean run;
                Console.WriteLine("Continue? Y/N");
                String answer = Console.ReadLine();

                if ((answer == "Y") || (answer == "y"))
                {
                    run = true;
                }
                else if ((answer == "N") || (answer == "n"))
                {
                    run = false;
                    Console.WriteLine("Good Bye!");
                }
                else
                {
                    Console.WriteLine("Does not compute!");
                    run = Continue();

                }
                return run;
            }
        }

    abstract class Player
    {
        public virtual string GenerateRoshambo()
        {
            return "This player is on vacation";
        }
    }
}
