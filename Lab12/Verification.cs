using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Verification
    {
        //Verify user choice of rock, paper, or scissors
        public static bool VerifyRPS(string input)
        {
            bool isValidInput;

            if(input.Equals("r") || input.Equals("p") || input.Equals("s") || input.Equals("rock") || input.Equals("paper") || input.Equals("scissors"))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type r/p/s or rock/paper/scissors:");
                isValidInput = false;
            }

            return isValidInput;
        }

        //Verify user's choice of opponent
        public static bool VerifyOpponent(string input)
        {
            bool isValidInput;

            if (input.Equals("rocky") || input.Equals("randy"))
            {
                isValidInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input! Please type 'rocky' or 'randy':");
                isValidInput = false;
            }

            return isValidInput;
        }
    }
}
