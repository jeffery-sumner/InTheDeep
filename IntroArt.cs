using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    internal class IntroArt
    {
        public static void Intro()
        {
            //ASCCII INTRO
            ForegroundColor = ConsoleColor.Yellow;
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

        }
    }
}
