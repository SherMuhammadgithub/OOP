using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreaming
{
    internal class Playlist
    {
        private List<Song> Songs;
        public Playlist() { 
        Songs = new List<Song>();
        }
        public void AddSong(Song song)
        {
            Songs.Add(song);
        }
    }
}
