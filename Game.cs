using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace InTheDeep
{
    internal class Game
    {
        private Harpy HardyHarpy;
        private Item GoldTalons;

        public Game()
        {
            HardyHarpy = new Harpy("Hard Harpy", 100, ConsoleColor.Yellow);
            GoldTalons = new Item("Gold Talons", 2);
        }

        public void Run()
        {
            WriteLine("##### In The Deep #####\n");

            HardyHarpy.DisplayInfo();
            HardyHarpy.Screech();
            HardyHarpy.Claws();

            ConsoleUtils.WaitForKeyPress();
        }
    }
}
