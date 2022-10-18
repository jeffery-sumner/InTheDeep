using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace InTheDeep
{
    internal class Game
    {
        public void Start()
        {
            /*WriteLine("Welcome to your next adventure!");

            ConsoleKeyInfo keyPressed = ReadKey();

            if (keyPressed.Key == ConsoleKey.Enter)
            {
                WriteLine("You pressed enter");
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                WriteLine("You pressed the up arrow");
            }
            else
            {
                WriteLine("You pressed another key");
            }
            */

            string prompt = "Welcome to your new adventure, what would you like to do?";
            string[] options = { "Play", "About", "Options" };
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.DisplayOptions();
            WriteLine("Press any key to exit....");
            ReadKey(true);
        }
    }
}
