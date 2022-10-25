using static System.Console;
using System.Text;
using System;
using System.Collections.Generic;
using System.Drawing;


namespace InTheDeep
{
    internal class MainMenu
    {
        ////Color for title
        //static IEnumerable<Color> GetGradients(Color start, Color end, int steps)
        //{
        //    start = (Color.Yellow);
        //    end = (Color.DarkRed);

        //    int stepA = ((end.A - start.A) / (steps - 1));
        //    int stepR = ((end.R - start.R) / (steps - 1));
        //    int stepG = ((end.G - start.G) / (steps - 1));
        //    int stepB = ((end.B - start.B) / (steps - 1));

        //    for (int i = 0; i < steps; i++)
        //    {
        //        yield return Color.FromArgb(start.A + (stepA * i),
        //                                    start.R + (stepR * i),
        //                                    start.G + (stepG * i),
        //                                    start.B + (stepB * i));
        //    }
        //}
        public void Start()
        {
            Title = "In The Deep!";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @" 
                      ██╗███╗   ██╗    ████████╗██╗  ██╗███████╗    ██████╗ ███████╗███████╗██████╗ 
                      ██║████╗  ██║    ╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔════╝██╔════╝██╔══██╗
                      ██║██╔██╗ ██║       ██║   ███████║█████╗      ██║  ██║█████╗  █████╗  ██████╔╝
                      ██║██║╚██╗██║       ██║   ██╔══██║██╔══╝      ██║  ██║██╔══╝  ██╔══╝  ██╔═══╝ 
                      ██║██║ ╚████║       ██║   ██║  ██║███████╗    ██████╔╝███████╗███████╗██║     
                      ╚═╝╚═╝  ╚═══╝       ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═════╝ ╚══════╝╚══════╝╚═╝    
                              Welcome to your new adventure! What would you like to do?
                 (Use the arrow keys to cycle through options and press 'Enter' to select an option)";

            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {
            WriteLine("Press any key to exit");
            ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Clear();
            WriteLine("This game was created by Jeffery Sumner. ");
            WriteLine("It uses ASCII art from https://www.asciiart.eu/ , VK/cf, especially from -Daniel Hunt- whom the griffin, dragon and mtn are from! ");
            WriteLine("This is a class project for Code Kentucky. ");
            WriteLine("Press any key to return to the menu. ");
            ReadKey(true);
            RunMainMenu();
        }

        private void RunFirstChoice()
        {
            string prompt = "What archetypal class would you prefer?";
            string[] options = { "Warrior", "Wizard", "Thief" };
            Menu classMenu = new Menu(prompt, options);
            int selectedIndex = classMenu.Run();

            BackgroundColor = ConsoleColor.Black;
            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("\t The Stout And Hearty Warrior!");
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\t The Wizened And Powerful Wizard!");
                    break;
                case 2:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\t The Cunning And Swift Thief!");
                    break;
            }
            ReadLine();
        }
    }
}