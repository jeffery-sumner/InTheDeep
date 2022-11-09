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
        private int ChargeDistance;

        public Chimera(string name, int health, ConsoleColor color, int chargeDistance)
            : base(name, health, color, ArtAssets.Chimera)
        {
            Name = name;
            Health = health;
            Color = color;
            ChargeDistance = chargeDistance;
            TextArt = ArtAssets.Harpy;
        }

        public void Charge()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" swiftly flies forward {ChargeDistance} feet!");
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

    }
}
