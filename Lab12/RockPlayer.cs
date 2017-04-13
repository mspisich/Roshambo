using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RockPlayer : Player
    {
        private string name;

        public RockPlayer(string n)
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
            RoshamboRound r = new RoshamboRound();
            string result = r.GetRoshambo(0);
            return result;
        }
    }
}
