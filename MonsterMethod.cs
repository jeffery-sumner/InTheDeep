﻿using static System.Console;

namespace InTheDeep
{
    partial class Program
    {
        //ASCII First Monster
        internal class MonsterMethod
        {
            public static void Monsters()
            {
                Random random = new Random();

                int fight = random.Next(0, 2);

                if (fight == 0)
                {
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine(@"            
                                            ,                                        ,
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
                }
                else
                {
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine(@"
                                                 '-.,;;:;,
                                                 _;\;|\;:;,
                                                ) __ ' \;::,
                                            .--'  e   ':;;;:,           ;,
                                           (^           ;;::;          ;;;,
                                   _        --_.--.___,',:;::;     ,,,;:;;;,
                                  < \        `;     |  ;:;;:;        ':;:;;;,,
                                <`-; \__     ,;    /    ';:;;:,       ';;;'
                                <`_   __',   ; ,  /    ::;;;:         //
                                   `)|  \ \   ` .'      ';;:;,       //
                                    `    \ `\  /        ;;:;;.      //__
                                          \  `/`         ;:;  ~._,=~`   `~=,
                                           \_|      (        ^     ^  ^ _^  \
                                             \    _,`      / ^ ^  ^   .' `.^ ;
                                    <`-.  jgs '-;`       /`  ^   ^  /\    ) ^/
                                    <'- \__..-'` ___,,,-'._ ^  ^ _.'\^`'-' ^/
                                     `)_   ..-''`          `~~~~`    `~===~`
                                     <_.-`-._\");
                }
                ResetColor();
            }
        }
    }
}





    //ht3jlfaac5lfd6263ulfh4tql8@group.calendar.google.com (Calendar address)
