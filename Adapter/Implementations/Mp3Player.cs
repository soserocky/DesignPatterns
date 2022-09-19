using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementations
{
    internal class Mp3Player : IMediaPlayer
    {
        public void PlayMedia()
        {
            Console.WriteLine("Playing Mp3");
        }
    }
}
