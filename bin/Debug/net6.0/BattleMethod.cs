using static System.Console;

namespace InTheDeep
{
    public class BattleMethod
    {
        //Battle Method--- ⚔⚔⚔
        public static void Battle()
        {

            Random random = new Random();

            int playerHp = 45;

            int enemyHp = random.Next(35, 60);

            int playerAttack = random.Next(5, 8);

            int enemyAttack = random.Next(2, 7);

            int healAmount = random.Next(5, 7);
            string choice = null;
            do
            {
                //Fight Mechanic--- ⚔🛡👹
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    // Player Turn--- 🛡🛡🛡
                    WriteLine(" !!--@Player Turn--!! ");
                    WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                    WriteLine("Enter 'a' to attack or 'h' to heal");

                    choice = Console.ReadLine();
                    if (choice == "a")
                    {
                        enemyHp -= playerAttack;
                        WriteLine("\t --You attack your enemy and deal " + playerAttack + " damage");
                    }
                    else if (choice == "h")
                    {
                        playerHp += healAmount;
                        WriteLine("\t --You heal " + healAmount + " health points!");
                    }
                    else
                    {
                        WriteLine("You must choose 'a' or 'h' adventurer!");
                        Battle();
                    }

                    //Enemy Turn--- 👹👹👹
                    if (enemyHp > 0)
                    {
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine(" !!--@Enemy Turn--!!  ");
                        WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                        int enemyChoice = random.Next(0, 2);

                        if (enemyChoice == 0)
                        {
                            playerHp -= enemyAttack;
                            WriteLine("\t --The enemy slashes and deals " + enemyAttack + " damage!");
                        }
                        else
                        {
                            enemyHp += healAmount;
                            WriteLine("\t --The enemy restores " + healAmount + " health points!");
                        }

                    }
                }
            } while (playerHp > 0 && enemyHp > 0);

            //Battle Summary--- 🕮🕮🕮🕮🕮
            if (playerHp > 0)
            {
                WriteLine("\t --Congratulations, you have slain your foe!");
            }
            else
            {
                WriteLine("\t --The enemy roars in victory and begins to feast on your flesh");
            }
        }

    }
}