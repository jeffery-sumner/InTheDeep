using InTheDeep;
using System.Diagnostics;
using System.Media;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace InTheDeep
{
    internal class highScores
    {
        public static void HighScores()
        {
            // Reading the text file  
            string text;
            text = System.IO.File.ReadAllText(@"C:\\HighScore\\InTheDeepScore.txt");
            Console.WriteLine(text);

            WriteLine("Your current fastest time is... " + text);
        }
    }
}