using System.Text;
using System.Media;
using InTheDeep.Player.cs;

namespace InTheDeep
{
    class Program
    {

        static void Main(string[] args)
        {
            //Spooky Music....!!Does not work on mac
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer spookyPlayer = new SoundPlayer("133100__klankbeeld__horror-ambience-10.wav");
                spookyPlayer.Load();
                spookyPlayer.PlayLooping();
            }


            /*string playerName;

            Console.WriteLine("What's your name stranger?: ");

            playerName = Console.ReadLine();

            Console.WriteLine("Nice to make your acquaintance " + playerName + "Now let me recant what you told me in yer fever dream...ha ha ha.");
            */

            //Intro to adventure---
            Console.WriteLine("\t -While on a journey to find the Gintomony stone of legends past you have discovered a secret passage located \t" +
                              " in mammoth cave. After hours of exploration you stumble across a creature of unimaginable horror, do you try " +
                              " and sneak past or surprise it with the steel of a pickax you carry? 'fight' or 'flee': \t");
            string battle = Console.ReadLine();


            if (battle == "fight")
            {
                Battle();
            }
            else
            {
                Flee();
            }

            //Continue the Journey?---
            Console.WriteLine("\t -You manage to handle one situation, and now are torn between continuing the expedition, or heading home " +
                                          "to the comfort of modern life. Which do you choose, to continue 'c' or return 'r': ");
            string journey = Console.ReadLine();

            if (journey == "c")
            {
                Console.WriteLine("\t -You proceed down the unknown and unforgiving path. The floor here transitions from coarse cave stone to " +
                                  "carefully laid and engraved marble slabs. You spot a dais at the center of the room ahead. " +
                                  "Atop the dais sits a small glittering jade colored stone. You advance your trembling legs with renewed " +
                                  "vigor! Your dreams are within reach. Within a moment you stand at the pedestal, do you take the stone from " +
                                  "it's stand? 'yes' or 'no'?: ");

                string question = Console.ReadLine();

                if (question == "yes")
                {
                    Console.WriteLine("\t -You hear a guttural bellow from behind you and turn to see a primordial beast " +
                                  "with writhing limbs covered in a black metallic sheen and hear a voice, seemingly from nowhere saying " +
                                  "'How dare thee mortal scum, so bold and brash to think ye worthy of such power! Prepare thyself for thy consequence... ");
                    Battle();
                }

                else
                {
                    Console.WriteLine("\t -You hear a voice, seemingly in your ears but with no direction saying, 'Smarter mortals than " +
                                   "ye have sought this treasure, I deem ye wise enough to partake in it's use, if but for a moment. ");
                }
            }
            else
            {
                Console.WriteLine("You decide to head home, you've had enough adventure to last a lifetime...'Never knowing what you missed'");
            }

            //Clock method call---
            Console.WriteLine("\t -To check your pocket watch press 'c': ");
            string watch = Console.ReadLine();

            if (watch == "c")
            {
                Clock();
            }

            else
            {
                Battle();
            }


        }
        //Battle Method---
        static void Battle()
        {
            Random random = new Random();

            int playerHp = 40;

            int enemyHp = random.Next(14, 26);

            int playerAttack = random.Next(5, 8);

            int enemyAttack = random.Next(1, 7);

            int healAmount = random.Next(5, 7);

            do
            {
                //Fight Mechanic---
                {
                    // Player Turn---
                    Console.WriteLine(" @Player Turn ");
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


                    //Enemy Turn---
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

            //Battle Summary---
            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have slain your foe!");
            }
            else
            {
                Console.WriteLine("The enemy roars in victory and begins to feast on your flesh");
            }
        }

        static void Flee()
        {
            Random random = new Random();
            //Flee Mechanic---
            int flee = random.Next(0, 2);

            if (flee == 0)
            {
                Console.WriteLine("You manage to flee from the encounter!");
            }
            else
            {
                Console.WriteLine("To late to run now, stand and deliver!");

                Battle();
            }
        }

        //Current Time
        static decimal Clock()
        {
            Console.WriteLine(DateTime.Now);
            return 00;
        }



    }
}