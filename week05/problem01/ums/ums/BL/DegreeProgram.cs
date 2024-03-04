using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class DegreeProgram
    {
        public string Title;
        public int Duration;
        public int AvailabeSeats;
        public List<Subject> Subjects;

        public DegreeProgram(string title, int duration, int availabeSeats, List<Subject> subjects)
        {
            Title = title;
            Duration = duration;
            AvailabeSeats = availabeSeats;
            Subjects = subjects;
        }
    }
}
