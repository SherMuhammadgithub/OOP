using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class DegreeProgram
    {
        public string Title;
        public int Duration;
        public int AvailabeSeats;
        public List<Subjects> Subjects;

        public DegreeProgram(string title, int duration, int availabeSeats, List<Subjects> subjects)
        {
            Title = title;
            Duration = duration;
            AvailabeSeats = availabeSeats;
            Subjects = subjects;
        }
    }
}
