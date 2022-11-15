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
        public int MaxHealth { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public string TextArt { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public Random random { get; protected set;}
        public bool IsDead { get => Health <= 0; }
        public bool IsAlive { get => Health > 0; }

    public Character(string name, int health, ConsoleColor color, string textArt)
        {
            Name = name;
            Health = health;
            MaxHealth= health;
            Color = color;
            TextArt = textArt;
            random = new Random();
        }

        public void DisplayInfo()
        {
            ForegroundColor = Color;
            Write($"--- {Name} ---");
            ResetColor();
            WriteLine($"\n{TextArt}\n");
            WriteLine($"Health: {Health}");
            WriteLine($"---");
            ResetColor();
        }

        public virtual void Fight(Character otherCharacter)
        {
            WriteLine("Stand and deliver!");
        }

        public void TakeDamage(int damageAmount)
        {
            Health -= damageAmount;
            if ( Health < 0 )
            {
                Health= 0;
            }
        }

        public void DisplayHealthBar()
        {
            ForegroundColor= Color;
            WriteLine($"{Name}'s Health");
            ResetColor();
            Write("[");

            BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Health; i++)
            {
                Write(" ");
            }

            BackgroundColor = ConsoleColor.Black;
            for (int i = Health; i < MaxHealth; i++)
            {
                Write(" ");
            }
            ResetColor();
            Write($"] ({Health}/{MaxHealth})");
        }
    }
}
