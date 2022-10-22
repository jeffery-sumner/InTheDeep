using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace InTheDeep
{
    internal class Music
    {
        public static void BackGroundMusic()
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer spookyPlayer = new SoundPlayer("133100__klankbeeld__horror-ambience-10.wav");
                spookyPlayer.Load();
                spookyPlayer.PlayLooping();
            }
        }
    }
}
