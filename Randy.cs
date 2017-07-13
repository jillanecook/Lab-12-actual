using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Test
{
    class Randy : Player
    {
        Random random = new Random();

        public override string GenerateRoshambo()
        {
            return  GetRoshambo();

        }

        public string GetRoshambo()
        {
            int number = random.Next(1, 4);
            if (number == 1)
            {
                return "R";
            }
            else if (number == 2)
            {
                return "P";
            }
            else
            {
                return "S";
            }
        }
        private string ToText(string choice)
        {
            if (choice == "R")
            {
                return "Rock";
            }
            else if (choice == "P")
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
    } 
}
