using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace InTheDeep
{
    class Harpy : Character
    {
        private Item CurrentItem;

        public Harpy(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Harpy)
        {

        }

        public void PickUpItem(Item item)
        {
            CurrentItem = item;
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
            WriteLine($"{Name} rends your flesh with talons!");

            if (CurrentItem != null)
            {
                WriteLine($"You notice it has {CurrentItem.Name}.");
            }
        }

        public void Gust()
        {
            BackgroundColor = Color;
            Write($" {Name} ");
            ResetColor();
            WriteLine($"{Name} provokes a gale wind that knocks you into a cave wall!");
        }
    }
}
