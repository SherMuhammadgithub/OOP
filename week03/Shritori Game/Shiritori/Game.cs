using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class Game
    {
        public List<string> words = new List<string>();
        public bool game_over = false;
        public Game() { }
       
        public string  play(string word)   // ser
        {
            if(words.Count == 0)
            {
                return word;
            }
            else
            {
                string last_word = words[words.Count - 1];
                char last_cahr = last_word[last_word.Length - 1]; // 

                // Get the last character of the word
                char fisrt_cahr = word[0];
                if (fisrt_cahr != last_cahr)
                {

                    game_over = true;
                    return "Game Over";
                }
                else
                {
                    return word;
                }
            }
          
        }
        public string restart()
        {
            words.Clear();
            return "game restarted";
        }
    }
}
