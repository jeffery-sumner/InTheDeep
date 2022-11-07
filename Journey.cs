using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InTheDeep.Program;
using static System.Console;

namespace InTheDeep
{
    internal class Journey
    {

        public static void Adventure()
        {
            Title = "In The Deep";
            CursorVisible = false;

            //Spooky Music....!!Does not work on mac 𝆏🎵🎵🎵
            Music.BackGroundMusic();

            MainMenu inTheDeep = new MainMenu();
            inTheDeep.Start();

            Stopwatch playTime = new Stopwatch();
            playTime.Start();

            IntroArt.Intro();
            ResetColor();

            //Intro to adventure--- 程 程 程
            WriteLine("\t --While on a journey to find the Gintomony stone of legends past you have discovered a secret passage located");
            WriteLine("in mammoth cave. After hours of exploration you stumble across a creature of unimaginable horror, do you try ");
            Console.WriteLine("and sneak past or surprise it with the steel of a pickax you carry? Fight -'f'- or Run -'r'-: ");
            string battle = Console.ReadLine();


            if (battle == "f")
            {
                MonsterMethod.Monsters();
                BattleMethod.Battle();
                ResetColor();
            }
            else
            {
                FleeMethod.Flee();
            }


            //Continue the Journey?--- 程 程 程
            WriteLine("\t --You manage to handle one situation, and now are torn between continuing the expedition, or heading home");
            Console.WriteLine("to the comfort of modern life. Which do you choose, to continue -'c'- or return -'r'-: ");
            string journey = Console.ReadLine();

            if (journey == "c")
            {
                WriteLine("\t --You proceed down the unknown and unforgiving path. The floor here transitions from coarse cave stone to ");
                WriteLine("carefully laid and engraved marble slabs. You spot a dais at the center of the room ahead.");
                WriteLine("Atop the dais sits a small glittering jade colored stone. You advance your trembling legs with renewed");
                WriteLine("vigor! Your dreams are within reach. Within a moment you stand at the pedestal, do you take the stone from");
                Console.WriteLine("it's stand? Yes -'y'- or No -'n'-?: ");

                string question = Console.ReadLine();

                if (question == "y")
                {
                    BossMethod.Monsters();

                    WriteLine("\t --You hear a guttural bellow from behind you and turn to see a primordial beast!");
                    WriteLine("with writhing limbs covered in a black metallic sheen and hear a voice, seemingly from nowhere saying");
                    WriteLine("How dare thee mortal scum, so bold and brash to think ye worthy of such power! Prepare thyself for thy consequence...");

                    BossBattleMethod.BossBattle();

                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("--You've slain the protector of the stone and now stand to gain immortality! All that is left is to get it home...");
                }

                else
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\t --You hear a voice, seemingly in your ears but with no direction saying, 'Smarter mortals than ");
                    WriteLine("ye have sought this treasure, I deem ye wise enough to partake in it's use, if but for a moment. ");
                }
            }
            else
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("\t --You decide to head home, you've had enough adventure to last a lifetime...'Never knowing what you missed'");
            }

            //Clock method call--- 🕑🕑🕑
            ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t --To check your pocket watch press -'c'-: ");
            string watch = ReadLine();

            if (watch == "c")
            {
                ForegroundColor = ConsoleColor.Cyan;
                ClockMethod.Clock();
            }

            else
            {
                BattleMethod.Battle();
            }


            //Record for current best time
            playTime.Stop();
            WriteLine(" Total play time for In The Deep was : {0} ", playTime.Elapsed);

            //Writing the text file Best Time High Score
            using (StreamWriter writer = new StreamWriter(@"C:\\HighScore\\InTheDeepScore.txt"))
            {
                writer.WriteLine(playTime.Elapsed);
            }
            ResetColor();

            //Reading text file for High Score
            WriteLine("To check your current high score press 'c' ");
            string highScore = ReadLine();

            if (highScore == "c")
            {
                ForegroundColor = ConsoleColor.Cyan;
                highScores.HighScores();
            }
            ResetColor();

            WriteLine("Press any key to exit...");
            ReadKey();
        }

    }
}
