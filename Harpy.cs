using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace InTheDeep
{
    internal class Harpy : Character
    {
        public Harpy(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Harpy)
        {

        }

        public void Screech()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($" emits a piercing screech that nearly bursts your ears!");
        }

        public void Claws()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"{Name} rends your flesh with it's talons!");
        }


        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            int randPercent = random.Next(1, 101);
            if (randPercent <= 50)
            {
                WriteLine("hits for 5 damage!");
                otherCharacter.TakeDamage(5);
            }
            else
            {
                WriteLine("misses...");
            }
            ResetColor();
        }
    }
}
