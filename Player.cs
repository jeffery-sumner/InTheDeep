using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDeep
{
    internal class Player : Character
    {
        public Player(string name, int health, ConsoleColor color)
            : base(name, health, color, "")
        {

        }
    }
}
