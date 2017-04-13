using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class UserPlayer : Player
    {
        private string name;

        public UserPlayer(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string n)
        {
            name = n;
        }

        public string GenerateRoshambo()
        {
            string userInput;
            string result;
            RoshamboRound r = new RoshamboRound();

            //Get user choice of r/p/s or rock/paper/scissors
            Console.WriteLine("\nRock, paper, or scissors? (R/P/S):");

            bool isValidInput = false;
            do
            {
                userInput = Console.ReadLine().ToLower();
                isValidInput = Verification.VerifyRPS(userInput);
            } while (isValidInput == false);


            if (userInput.Equals("r") || userInput.Equals("rock"))
            {
                result = r.GetRoshambo(0);
            }
            else if (userInput.Equals("p") || userInput.Equals("paper"))
            {
                result = r.GetRoshambo(1);
            }
            else if (userInput.Equals("s") || userInput.Equals("scissors"))
            {
                result = r.GetRoshambo(2);
            }
            else
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something was wrong with your input. I'm just going to make you 'rock'.");
                    result = r.GetRoshambo(0);
                }
            }

            return result;
        }
    }
}
