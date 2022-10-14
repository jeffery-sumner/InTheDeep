using System.Xml.Serialization;

namespace InTheDeep
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int playerHp = 40;
            int enemyHp = random.Next(14, 26);

            int playerAttack = random.Next(5, 8);
            int enemyAttack = random.Next(1, 7);

            int healAmount = random.Next(5, 7);


            Console.WriteLine("While on a journey to find the Gintomony stone of ancient legend you have discovered a secret passage located " +
                              " in mammoth cave. After hours of exploration you stumble across a creature of unimaginable horror, do you try " +
                              " and sneak past or surprise it with the steel of a pickax you carry? 'fight' or 'flee': ");
            string battle = Console.ReadLine();

            if (battle == "fight")
            {

                do
                {
                        //Fight Mechanic
                    {
                        // Player Turn
                        Console.WriteLine(" @Player Turn  ");
                        Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                        Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                        string choice = Console.ReadLine();

                        if (choice == "a")
                        {
                            enemyHp -= playerAttack;
                            Console.WriteLine("You attack your enemy and deal " + playerAttack + " damage");
                        }
                        if (choice == "h")
                        {
                            playerHp += healAmount;
                            Console.WriteLine("You heal " + healAmount + " health points!");
                        }
                        else
                        {
                            Console.WriteLine("Be confident and decide what you'll do!");
                        }

                        //Enemy Turn
                        if (enemyHp > 0)
                        {
                            Console.WriteLine(" @Enemy Turn  ");
                            Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                            int enemyChoice = random.Next(0, 2);

                            if (enemyChoice == 0)
                            {
                                playerHp -= enemyAttack;
                                Console.WriteLine("The enemy slashes and deals " + enemyAttack + " damage!");
                            }
                            else
                            {
                                enemyHp += healAmount;
                                Console.WriteLine("The enemy restores " + healAmount + " health points!");
                            }

                        }
                    }
                } while (playerHp > 0 && enemyHp > 0);
 
                //Battle Synopsis
                if (playerHp > 0)
                {
                    Console.WriteLine("Congratulations, you have slain your foe!");
                }
                else
                {
                    Console.WriteLine("The enemy roars in victory and begins to feast on your flesh");
                }
            }
            else
            {
                //Flee Mechanic
             int flee=random.Next(0, 2);

            if (flee == 0)
                {
                    Console.WriteLine("You manage to flee from the encounter!");
                }
                else
                {
                    Console.WriteLine("To late to run now, rend it's flesh!");
                    do
                    {

                        {
                            // Player Turn
                            Console.WriteLine(" @Player Turn  ");
                            Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                            Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                            string choice = Console.ReadLine();

                            if (choice == "a")
                            {
                                enemyHp -= playerAttack;
                                Console.WriteLine("You attack your enemy and deal " + playerAttack + " damage");
                            }
                            else
                            {
                                playerHp += healAmount;
                                Console.WriteLine("You heal " + healAmount + " health points!");
                            }

                            //Enemy Turn
                            if (enemyHp > 0)
                            {
                                Console.WriteLine(" @Enemy Turn  ");
                                Console.WriteLine("Player Hp = " + playerHp + ". Enemy Hp = " + enemyHp);
                                int enemyChoice = random.Next(0, 2);

                                if (enemyChoice == 0)
                                {
                                    playerHp -= enemyAttack;
                                    Console.WriteLine("The enemy slashes and deals " + enemyAttack + " damage!");
                                }
                                else
                                {
                                    enemyHp += healAmount;
                                    Console.WriteLine("The enemy restores " + healAmount + " health points!");
                                }
                            }
                        }
                    } while (playerHp > 0 && enemyHp > 0);

                    //Battle Synopsis
                    if (playerHp > 0)
                    {
                        Console.WriteLine("Congratulations, you have slain your foe!");
                    }
                    else
                    {
                        Console.WriteLine("The enemy roars in victory and begins to feast on your flesh");
                    }

                }
            }
            Console.WriteLine("You manage to slay the beast, and now are torn between continuing the expedition, or heading home" +
                                          "to the comfort of modern life. Which do you choose, to 'continue' or 'return': ");
            Console.ReadLine();
        }
    }
}