using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboRound
    {
        private List<string> roshambo;
        public RoshamboRound()
        {
            roshambo = new List<string>() { "Rock", "Paper", "Scissors" };
        }

        public string GetRoshambo(int index)
        {
            string roshamboChoice = roshambo[index];
            return roshamboChoice;
        }

        public void PlayRoshambo(Player p1, Player p2)
        {
            string p1Name = p1.GetName();
            string p2Name = p2.GetName();

            //Players choose rock, paper, or scissors
            string p1Choice = p1.GenerateRoshambo();
            string p2Choice = p2.GenerateRoshambo();

            Console.WriteLine("\n" + p1Name + ": " + p1Choice);
            Console.WriteLine(p2Name + ": " + p2Choice);

            //Print winner
            if (p1Choice.Equals(p2Choice))
            {
                Console.WriteLine("This round was a tie!");
            }
            else if(p1Choice.Equals("Rock") && p2Choice.Equals("Scissors"))
            {
                Console.WriteLine(p1Name + " wins!");
            }
            else if (p1Choice.Equals("Paper") && p2Choice.Equals("Rock"))
            {
                Console.WriteLine(p1Name + " wins!");
            }
            else if (p1Choice.Equals("Scissors") && p2Choice.Equals("Paper"))
            {
                Console.WriteLine(p1Name + " wins!");
            }
            else if (p1Choice.Equals("Rock") && p2Choice.Equals("Paper"))
            {
                Console.WriteLine(p2Name + " wins!");
            }
            else if (p1Choice.Equals("Paper") && p2Choice.Equals("Scissors"))
            {
                Console.WriteLine(p2Name + " wins!");
            }
            else if (p1Choice.Equals("Scissors") && p2Choice.Equals("Rock"))
            {
                Console.WriteLine(p2Name + " wins!");
            }
        }
    }
}
