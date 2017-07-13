using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Test
{
    class Tommy : Player
    {
        public override string GenerateRoshambo()
        {
            return ThrowRocks(); 
        }
        public string ThrowRocks()
        {
            Console.WriteLine("Choose an option R, P, S : ");
            string choice = Console.ReadLine();

            if (choice == "R") 
            {
                return "R";
            }
            else if (choice == "P")
            {
                return "R";
            }
            else
            {
                return "R";
            }

        }
    }
}
