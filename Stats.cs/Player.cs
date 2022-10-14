using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InTheDeep.Player.cs
{
    internal class Player
    {
        int playerHp = 40;
        int playerAttack = 5;
        int Level { get; set; }
        int CurrentExp { get; set; }
        int ExpToNextLevel { get; set; }

        void GainExp(int Exp)
        {
            CurrentExp = Exp;
        }
        int LevelUp()
        {
            return Level;
        }
    }
}
