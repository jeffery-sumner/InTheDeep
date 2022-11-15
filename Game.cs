using static System.Console;


namespace InTheDeep
{
    partial class Program
    {
        public class Game
        {
            private Player CurrentPlayer;
            private Character CurrentEnemy;
            private List<Character> Enemies;


            public Game()
            {
                Chimera GoldBrand = new Chimera("GoldBrand", 45, ConsoleColor.Red);
                Harpy HardyHarpy = new Harpy("Hardy Harpy", 30, ConsoleColor.Yellow);
                Enemies = new List<Character>() { HardyHarpy, GoldBrand };
            }

            public void Run()
            {
                CurrentPlayer = new Player("No-ob", 50, ConsoleColor.Green);
                CurrentPlayer.DisplayInfo();

                CurrentEnemy = Enemies[0];
            }
            void EnemyIntro()
            {
                Clear();
                ForegroundColor = CurrentEnemy.Color;
                WriteLine("\t Steel yourself adventurer...");
                ResetColor();
                CurrentEnemy.DisplayInfo();
                WriteLine();
                ConsoleUtils.WaitForKeyPress();
            }

            void Battle()
            {
                while (CurrentPlayer.IsAlive && CurrentEnemy.IsAlive)
                {
                    Clear();
                    CurrentPlayer.DisplayHealthBar();
                    CurrentEnemy.DisplayHealthBar();
                    WriteLine();

                    CurrentPlayer.Fight(CurrentEnemy);


                    WriteLine();
                    ConsoleUtils.WaitForKeyPress();

                    if (CurrentPlayer.IsDead || CurrentEnemy.IsDead)
                    {
                        break;
                    }


                    Clear();
                    CurrentPlayer.DisplayHealthBar();
                    CurrentEnemy.DisplayHealthBar();
                    WriteLine();

                    CurrentEnemy.Fight(CurrentPlayer);

                    ConsoleUtils.WaitForKeyPress();

                    if (CurrentPlayer.IsAlive)
                    {
                        WriteLine("--Congratulations, you have slain your foe!");
                    }
                    else
                    {
                        WriteLine("--The enemy roars in victory and begins to feast on your flesh");
                    }

                    ConsoleUtils.WaitForKeyPress();

                }

            }
        }
    }
}
