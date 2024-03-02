using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Masti");
            Song song2 = new Song("Kamal");
            Playlist playlist = new Playlist();
            playlist.AddSong(song1);
            playlist.AddSong(song2);
        }
    }
}
