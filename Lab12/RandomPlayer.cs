using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer : Player
    {
        private string name;
        Random rnd;

        public RandomPlayer(string n, Random r)
        {
            name = n;
            rnd = r;
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
            //Generate random choice of rock, paper, or scissors
            int randomNum = rnd.Next(0, 3);
            string result;
            RoshamboRound r = new RoshamboRound();

            if (randomNum == 0)
            {
                result = r.GetRoshambo(0);
            }
            else if (randomNum == 1)
            {
                result = r.GetRoshambo(1);
            }
            else if (randomNum == 2)
            {
                result = r.GetRoshambo(2);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }

            return result;
        }
    }
}
