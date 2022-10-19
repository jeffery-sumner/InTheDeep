using System.Text;
using System.Media;
using static System.Console;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Xml;
using Google.Apis.Services;
using Google.Apis.Calendar.v3;
using System.Security.Cryptography.X509Certificates;

namespace InTheDeep
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Start();

            //ASCCII INTRO
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"    
                                            ,   ,
                                         ,-`{-`/
                                      ,-~ , \ {-~~-,
                                    ,~  ,   ,`,-~~-,`,
                                  ,`   ,   { {      } }                                             }/
                                 ;     ,--/`\ \    / /                                     }/      /,/
                                ;  ,-./      \ \  { {  (                                  /,;    ,/ ,/
                                ; /   `       } } `, `-`-.___                            / `,  ,/  `,/
                                 \|         ,`,`    `~.___,---}                         / ,`,,/  ,`,;
                                  `        { {                                     __  /  ,`/   ,`,;
                                        /   \ \                                 _,`, `{  `,{   `,`;`
                                       {     } }       /~\         .-:::-.     (--,   ;\ `,}  `,`;
                                       \\._./ /      /` , \      ,:::::::::,     `~;   \},/  `,`;     ,-=-
                                        `-..-`      /. `  .\_   ;:::::::::::;  __,{     `/  `,`;     {
                                                   / , ~ . ^ `~`\:::::::::::<<~>-,,`,    `-,  ``,_    }
                                                /~~ . `  . ~  , .`~~\:::::::;    _-~  ;__,        `,-`
                                       /`\    /~,  . ~ , '  `  ,  .` \::::;`   <<<~```   ``-,,__   ;
                                      /` .`\ /` .  ^  ,  ~  ,  . ` . ~\~                       \\, `,__
                                     / ` , ,`\.  ` ~  ,  ^ ,  `  ~ . . ``~~~`,                   `-`--, \
                                    / , ~ . ~ \ , ` .  ^  `  , . ^   .   , ` .`-,___,---,__            ``
                                  /` ` . ~ . ` `\ `  ~  ,  .  ,  `  ,  . ~  ^  ,  .  ~  , .`~---,___
                                /` . `  ,  . ~ , \  `  ~  ,  .  ^  ,  ~  .  `  ,  ~  .  ^  ,  ~  .  `-,");

            ResetColor();
            //Spooky Music....!!Does not work on mac 𝆏🎵🎵🎵
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer spookyPlayer = new SoundPlayer("133100__klankbeeld__horror-ambience-10.wav");
                spookyPlayer.Load();
                spookyPlayer.PlayLooping();
            }


            //Intro to adventure--- 程 程 程
            WriteLine("\t --While on a journey to find the Gintomony stone of legends past you have discovered a secret passage located");
            WriteLine("in mammoth cave. After hours of exploration you stumble across a creature of unimaginable horror, do you try ");
            Console.WriteLine("and sneak past or surprise it with the steel of a pickax you carry? 'fight' or 'flee': ");
            string battle = Console.ReadLine();


            if (battle == "fight")
            {
                //ASCII First Monster
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine(@"                  ,                                      ,
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
                ResetColor();
                BattleMethod.Battle();
            }
            else
            {
                FleeMethod.Flee();
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
                    ForegroundColor = ConsoleColor.DarkRed;
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
                    BossBattleMethod.BossBattle();

                    ResetColor();
                    WriteLine("\t --You've slain the protector of the stone and now stand to gain immortality! All that is left is to get it home...");
                }

                else
                {
                    WriteLine("\t --You hear a voice, seemingly in your ears but with no direction saying, 'Smarter mortals than ");
                    WriteLine("ye have sought this treasure, I deem ye wise enough to partake in it's use, if but for a moment. ");
                }
            }
            else
            {
                WriteLine("\t --You decide to head home, you've had enough adventure to last a lifetime...'Never knowing what you missed'");
            }

            //Clock method call--- 🕑🕑🕑
            Console.WriteLine("\t --To check your pocket watch press 'c': ");
            string watch = Console.ReadLine();

            if (watch == "c")
            {
                ClockMethod.Clock();
            }

            else
            {
                BattleMethod.Battle();
            }

            Console.WriteLine("\t --To check the moon phase press 'c': ");
            string moon = Console.ReadLine();

            if (moon == "c")
            {
                CalendarApi.MoonCalendar();
            }

            else
            {
                BattleMethod.Battle();
            }

        }
    }

}




    //ht3jlfaac5lfd6263ulfh4tql8@group.calendar.google.com (Calendar address)
