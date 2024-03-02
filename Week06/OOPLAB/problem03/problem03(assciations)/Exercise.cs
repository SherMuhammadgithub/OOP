using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem03_assciations_
{
    internal class Exercise
    {
        private string Name { get; set; }
        private List<Set> Sets { get; set; }
        public Exercise( string name) {
            Name = name;
            Sets = new List<Set>();  
        }

        public void AddSet(Set set)
        {
            Sets.Add(set);
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        

    }
}
