using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");

            Console.WriteLine("\nEnter your name:");
            string userName = Console.ReadLine();

            Player player1 = new UserPlayer(userName);

            Console.WriteLine("\nWould you like to play against Rocky Balboa or Random Randy?");
            Console.WriteLine("Type 'Rocky' or 'Randy':");

            //Choose opponent. Get and verify input
            string opponentChoice;

            bool isValidInput = false;
            do
            {
                opponentChoice = Console.ReadLine().ToLower();
                isValidInput = Verification.VerifyOpponent(opponentChoice);
            } while (isValidInput == false);

            Player player2;

            if (opponentChoice.Equals("rocky"))
            {
                player2 = new RockPlayer("Rocky Balboa");
            }
            else if (opponentChoice.Equals("randy"))
            {
                Random rnd = new Random();
                player2 = new RandomPlayer("Random Randy", rnd);
            }
            else
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong while choosing your opponent. We'll just put you up against Rocky.");
                    player2 = new RockPlayer("Rocky Balboa");
                }
            }

            bool run = true;
            while (run)
            {


                //Play game
                RoshamboRound r = new RoshamboRound();
                r.PlayRoshambo(player1, player2);

                Console.WriteLine("\nPlay again? (y/n):");
                run = Continue();
            }  
        }

        //Continue program?
        public static bool Continue()
        {
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input.Equals("n"))
            {
                run = false;
            }
            else if (input.Equals("y"))
            {
                run = true;
            }
            else
            {
                Console.WriteLine("\nInvalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}
