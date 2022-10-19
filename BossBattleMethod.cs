namespace InTheDeep
{
    internal static class BossBattleMethod
    {

        //Boss Battle Method ⚔⚔⚔⚔⚔⚔
        public static void BossBattle()
        {
            Random random = new Random();

            int playerHp = 45;

            int enemyHp = random.Next(35, 60);

            int playerAttack = random.Next(5, 8);

            int enemyAttack = random.Next(2, 7);

            int healAmount = random.Next(5, 7);

            do
            {
                //Fight Mechanic--- ⚔🛡👹
                {
                    // Player Turn--- 🛡🛡🛡
                    Console.WriteLine(" !!--@Player Turn--!! ");
                    Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                    Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                    string choice = Console.ReadLine();

                    if (choice == "a")
                    {
                        enemyHp -= playerAttack;
                        Console.WriteLine("\t --You attack your enemy and deal " + playerAttack + " damage");
                    }
                    if (choice == "h")
                    {
                        playerHp += healAmount;
                        Console.WriteLine("\t --You heal " + healAmount + " health points!");
                    }


                    //Enemy Turn--- 👹👹👹
                    if (enemyHp > 0)
                    {
                        Console.WriteLine(" !!--@Enemy Turn--!!  ");
                        Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                        int enemyChoice = random.Next(0, 2);

                        if (enemyChoice == 0)
                        {
                            playerHp -= enemyAttack;
                            Console.WriteLine("\t --The enemy slashes and deals " + enemyAttack + " damage!");
                        }
                        else
                        {
                            enemyHp += healAmount;
                            Console.WriteLine("\t --The enemy restores " + healAmount + " health points!");
                        }

                    }
                }
            } while (playerHp > 0 && enemyHp > 0);

            //Battle Summary--- 🕮🕮🕮🕮🕮
            if (playerHp > 0)
            {
                Console.WriteLine("\t --Congratulations, you have slain your foe!");
            }
            else
            {
                Console.WriteLine("\t --The enemy roars in victory and begins to feast on your flesh");
            }
        }
    }
}