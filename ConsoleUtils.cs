﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InTheDeep
{
    static class ConsoleUtils
    {

        public static void WaitForKeyPress()
        {
            WriteLine("(Press any key to continue.)");
            ReadKey(true);
        }

        public static void QuitConsole()
        {
            WriteLine("(Press any key to exit)");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
