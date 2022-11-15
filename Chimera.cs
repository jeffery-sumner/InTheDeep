using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class Chimera : Character
    {

        public Chimera(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Chimera)
        {
            Name = name;
            Health = health;
            Color = color;
            TextArt = ArtAssets.Harpy;
        }

        public void Bite()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"{Name} devours a hunk of flesh from you!");
        }

        public void Smash()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"{Name} swings their club tail with a crushing blow!");
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($"Harpy {Name} is attacking {otherCharacter.Name}!");
            ResetColor();
            int randNum = random.Next(1, 101);

            if (randNum <= 50)
            {
                Bite();
            }
            else
            {
                Smash();
            }

        }
    }
}
