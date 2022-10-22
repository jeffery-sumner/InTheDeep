﻿using System;
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
            int fight = random.Next(0, 2);

            if (fight == 0)
            {
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
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine(@"        
                                                         ,     .
                                                        /(     )\               A
                                                   .--.( `.___.' ).--.         /_\
                                                   `._ `%_&%#%$_ ' _.'     /| <___> |\
                                                      `|(@\*%%/@)|'       / (  |L|  ) \
                                                       |  |%%#|  |       J d8bo|=|od8b L
                                                        \ \$#%/ /        | 8888|=|8888 |
                                                        |\|%%#|/|        J Y8P""|=|""Y8P F
                                                        | (."".)%|         \ (  |L|  ) /
                                                    ___.'  `-'  `.___      \|  |L|  |/
                                                  .'#*#`-       -'$#*`.       / )|
                                                 /#%^#%*_ *%^%_  #  %$%\    .J (__)
                                                 #&  . %%%#% ###%*.   *%\.-'&# (__)
                                                 %*  J %.%#_|_#$.\J* \ %'#%*^  (__)
                                                 *#% J %$%%#|#$#$ J\%   *   .--|(_)
                                                 |%  J\ `%%#|#%%' / `.   _.'   |L|
                                                 |#$%||` %%%$### '|   `-'      |L|
                                                 (#%%||` #$#$%%% '|            |L|
                                                 | ##||  $%%.%$%  |            |L|
                                                 |$%^||   $%#$%   |            |L|
                                                 |&^ ||  #%#$%#%  |            |L|
                                                 |#$*|| #$%$$#%%$ |\           |L|
                                                 ||||||  %%(@)$#  |\\          |L|
                                                 `|||||  #$$|%#%  | L|         |L|
                                                      |  #$%|$%%  | ||l        |L|
                                                      |  ##$H$%%  | |\\        |L|
                                                      |  #%%H%##  | |\\|       |L|
                                                      |  ##% $%#  | Y|||       |L|
                                                      J $$#* *%#% L  |E/       \:/
                                                      (__ $F J$ __)  F/         |
                                                      J#%$ | |%%#%L
                                                      |$$%#& & %%#|
                                                      J##$ J % %%$F
                                                       %$# * * %#&
                                                       %#$ | |%#$%
                                                       *#$%| | #$*
                                                      /$#' ) ( `%%\
                                                     /#$# /   \ %$%\
                                                    ooooO'     `Ooooo");
            }
        }
    }
}
