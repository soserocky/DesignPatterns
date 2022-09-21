using Adapter.Adapter;
using Adapter.Implementations;
using Adapter.Interfaces;

namespace Adapter
{
    public class AdapterDemo
    {
        //The constraint here is: We have access to IMediaPlayer and Mp3Player, and,
        //We want to play Advanced Media like Mp4 and VLC, but, we do not have access to them from the client side
        //The idea here is: We create and "adapter" class, "Mp3ToMp4_VLC_Adapter", which implements Media Player
        //but internally calls the Advanced Media Players like the "Mp4Player" and "VLCPlayer" classes 
        public static void Start()
        {
            IMediaPlayer mp4Adapter = new Mp3ToMp4_VLC_Adapter(new Mp4Player());
            mp4Adapter.PlayMedia();
            
            IMediaPlayer vlcAdapter = new Mp3ToMp4_VLC_Adapter(new VLCPlayer());
            vlcAdapter.PlayMedia();
        }
    }
}