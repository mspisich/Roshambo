using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    interface Player
    {
        string GetName();

        void SetName(String n);

        string GenerateRoshambo();
    }
}
