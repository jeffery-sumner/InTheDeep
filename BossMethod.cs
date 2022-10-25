using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class BossMethod
    {
        public static void Monsters()
        {
            Random random = new Random();

            int enemyHp = random.Next(70, 81);

                ForegroundColor = ConsoleColor.Red;
                WriteLine(@" 
                                                                               ,--,  ,.-..
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

            }
        }
    }

