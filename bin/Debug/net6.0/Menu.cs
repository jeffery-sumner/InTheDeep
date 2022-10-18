using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InTheDeep
{
    public class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for(int i =0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if(i == SelectedIndex)
                {
                    prefix = "*";
                    //ForegroundColor = ConsoleColor.Black;
                    //BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "";
                }

                Console.WriteLine($"{prefix} << {currentOption} >>");
            }

        }

    }
}
