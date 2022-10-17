using System.Text;
using System.Media;
using InTheDeep.Player.cs;
using static System.Console;

namespace InTheDeep
{
    class Program
    {

        //ASCCII INTRO

        static void Main(string[] args)
        {
            WriteLine(@"                     ,                                      ,
                                            |\                                      /|
                                         ,   \'._ ,                           ,  _.'/   ,
                                         |\  {'. '-`\,      ,-._**_.-,      ,/`-' .'}  /|
                                          \`'-'-.  '.`\      \*____*/      /`.'  .-'-'`/
                                        ,'-'-._  '.  ) )     /`    `\     ( (  .'  _.-'-',
                                        |\'- _ '.   , /     /  /""\  \     \ ,  .'  _ -'/|
                                         \'-.   .  ; (      \_|^  ^|_/      ) ;   .  .-'/
                                          `'--, . ;  {`-.      \__/      .-'}  ; . ,--'`
                                          '--`_. ;  { ^  \    _|  |_    /  ^ }  ; ._`--'
                                          `,_.--  ;  { ^  `-'`      `'-`  ^ }  ;  --._,`
                                            ,_.-    ; {^    /        \    ^} ;    -._, 
                                              ,_.-`), /\{^,/\\__/\__//\,^}/\ ,(`-._,
                                               _.'.-` /.'   \        /   `.\ `-.'._
                                              `  _.' `       \      /       ` '._   `
                                                            .-'.  .'-.
                                                          .'    `` ^  '.
                                                         /  ^ ^   ^  ^  \
                                                         | ^    ^   ^   |
                                                        /^   ^/    \  ^  \
                                                        \,_^_/    ^ \_,^./
                                                         /=/  \^   /  \=\
                                                     __ /=/_   | ^|   _\=\ __
                                                   <(=,'=(==,) |  | (,==)=',=)>
                                                     /_/|_\    /  \    /_|\_\
                                                     `V (=|  .'    '.  |=) V`
                                                         V  / _/  \_ \  V
                                                    jgs    ` ` \  / ` `
                                                                \/");
            //Spooky Music....!!Does not work on mac 𝆏🎵🎵🎵
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

            //Intro to adventure--- 程 程 程
            WriteLine("\t --While on a journey to find the Gintomony stone of legends past you have discovered a secret passage located");
            WriteLine("in mammoth cave. After hours of exploration you stumble across a creature of unimaginable horror, do you try ");
            Console.WriteLine("and sneak past or surprise it with the steel of a pickax you carry? 'fight' or 'flee': ");
            string battle = Console.ReadLine();


            if (battle == "fight")
            {
                Battle();
            }
            else
            {
                Flee();
            }

            //Continue the Journey?--- 程 程 程
            WriteLine("\t --You manage to handle one situation, and now are torn between continuing the expedition, or heading home");
            Console.WriteLine("to the comfort of modern life. Which do you choose, to continue 'c' or return 'r': ");
            string journey = Console.ReadLine();

            if (journey == "c")
            {
                WriteLine("\t --You proceed down the unknown and unforgiving path. The floor here transitions from coarse cave stone to ");
                WriteLine("carefully laid and engraved marble slabs. You spot a dais at the center of the room ahead.");
                WriteLine("Atop the dais sits a small glittering jade colored stone. You advance your trembling legs with renewed");
                WriteLine("vigor! Your dreams are within reach. Within a moment you stand at the pedestal, do you take the stone from");
                Console.WriteLine("it's stand? 'yes' or 'no'?: ");

                string question = Console.ReadLine();

                if (question == "yes")
                {
                    //Boss ASCII
                    WriteLine(@"                                                   ,--,  ,.-..
                                                                           ,\,     '-,-`,'-.' | ._
                                                      /|           \    /   |\         }  )/  / `-,',
                                                      [ ,          |\  /|   | |        /  \|  |/`  ,`
                                                      | |       ,.`  `,` `, | |  _,...(   (      .',
                                                      \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
                                                       \  \_\,``,   ` , ,  /  |         )         _,/
                                                        \  '  `  ,_ _`_,-,<._.<        /         /
                                                         ', `>.,`  `  `   ,., |_      |         /
                                                           \/`  `,   `   ,`  | /__,.-`    _,   `\
                                                        ,-..\  _  \  `  /  ,  / `._) _,-\`       \
                                                        \_,,.) /\    ` /  / ) (-,, ``    ,        |
                                                       ,` )  | \_\       '-`  |  `(               \
                                                      /  /```(   , --, ,' \   |`<`    ,            |
                                                     /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
                                               ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
                                              (-, \           ) \ ('_.-._)/ /,`    /
                                              | /  `          `/ \\ V   V, /`     /
                                           ,--\(        ,     <_/`\\     ||      /
                                          (   ,``-     \/|         \-A.A-`|     /
                                         ,>,_ )_,..(    )\          -,,_-`  _--`
                                        (_ \|`   _,/_  /  \_            ,--`
                                         \( `   <.,../`     `-.._   _,-` ");

                    WriteLine("\t --You hear a guttural bellow from behind you and turn to see a primordial beast!");
                    WriteLine("with writhing limbs covered in a black metallic sheen and hear a voice, seemingly from nowhere saying");
                    WriteLine("How dare thee mortal scum, so bold and brash to think ye worthy of such power! Prepare thyself for thy consequence...");
                    BossBattle();

                    WriteLine("\t --You've slain the protector of the stone and now stand to gain immortality! All that is left is to get it home...");
                }

                else
                {
                    Console.WriteLine("\t --You hear a voice, seemingly in your ears but with no direction saying, 'Smarter mortals than " +
                                   "ye have sought this treasure, I deem ye wise enough to partake in it's use, if but for a moment. ");
                }
            }
            else
            {
                Console.WriteLine("\t --You decide to head home, you've had enough adventure to last a lifetime...'Never knowing what you missed'");
            }

            //Clock method call--- 🕑
            Console.WriteLine("\t --To check your pocket watch press 'c': ");
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
        //Battle Method--- ⚔⚔⚔
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

        //Boss Battle Method ⚔⚔⚔⚔⚔⚔
        static void BossBattle()
        {
            Random random = new Random();

            int playerHp =45;

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

        //Flee Mechanic--- 🏃🏃🏃🏃🏃
        static void Flee()
        {
            Random random = new Random();

            int flee = random.Next(0, 2);

            if (flee == 0)
            {
                Console.WriteLine("\t --You manage to flee from the encounter!");
            }
            else
            {
                Console.WriteLine("\t --To late to run now, stand and deliver!");

                Battle();
            }
        }

        //Current Time 🕑
        static decimal Clock()
        {
            Console.WriteLine(DateTime.Now);
            return 00;
        }



    }
}