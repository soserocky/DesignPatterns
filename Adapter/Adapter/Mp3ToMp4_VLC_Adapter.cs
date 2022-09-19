using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    internal class Mp3ToMp4_VLC_Adapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer _advancedMediaPlayer;

        public Mp3ToMp4_VLC_Adapter(IAdvancedMediaPlayer advancedMediaPlayer)
        {
            _advancedMediaPlayer = advancedMediaPlayer;
        }

        public void PlayMedia()
        {
            _advancedMediaPlayer.PlayAdvancedMedia();
        }
    }
}
