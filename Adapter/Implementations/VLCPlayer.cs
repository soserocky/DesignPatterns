using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Implementations
{
    internal class VLCPlayer : IAdvancedMediaPlayer
    {
        public void PlayAdvancedMedia()
        {
            Console.WriteLine("Playing VLC");
        }
    }
}
