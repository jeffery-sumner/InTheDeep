using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class Player : Character
    {
        public Player(string name, int health, ConsoleColor color)
            : base(name, health, color, ArtAssets.Player)
        {

        }

        private void ThrowRockAt(Character otherCharacter)
        {
            Write("You throw a heavy rock ");
            int randPercent = random.Next(1, 101);
            if (randPercent <= 90)
            {
                WriteLine("you hear the rock crack against your foe!");
                otherCharacter.TakeDamage(4);
            }
            else
            {
                WriteLine("and it misses...");
            }
        }

        private void SwingAt(Character otherCharacter)
        {
            Write("You execute a mighty swing ");
            int randPercent = random.Next(1, 101);
            if (randPercent <= 50)
            {
                WriteLine("you feel the pickax sink into your foes flesh!");
                otherCharacter.TakeDamage(8);
            }
            else
            {
                WriteLine("and it misses...");
            }
        }

        public override void Fight(Character otherCharacter)
        {
            ForegroundColor = Color;
            WriteLine($@"You are facing {otherCharacter.Name}. What would you like to do?

1) Pick up a cave rock and throw it (90% chance to do 3 damage).
2) Take a swing with your pickax (50% chance to do 8 damage).
");
            ConsoleKeyInfo keyInfo = ReadKey(true);
            if (keyInfo.Key == ConsoleKey.D1)
            {
                ThrowRockAt(otherCharacter);
            }
            else if (keyInfo.Key == ConsoleKey.D2)
            {
                SwingAt(otherCharacter);
            }
            else
            {
                WriteLine("That's not a valid move. Try again.");
                Fight(otherCharacter);
                return;
            }

            ResetColor();
        }
    }
}
