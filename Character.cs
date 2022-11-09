using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class Character
    {
        protected string Name;
        protected int Health;
        protected string TextArt;
        protected ConsoleColor Color;
        protected Random random = new Random();

        public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = textArt;
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            WriteLine($"--- {Name} ---");
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health: {Health}");
            WriteLine($"---");
            ResetColor();
        }
    }
}
