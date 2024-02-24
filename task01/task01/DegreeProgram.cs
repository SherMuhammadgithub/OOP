using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class DegreeProgram
    {
        public string Title;
        public string Duration;
        public int Seats;
        public List<Subject> subject;
        DegreeProgram(string title, string duration, Subject subjects , int seats )
        {
            Title = title;
            Duration = duration;
            Seats = seats;
            subject.Add(subjects);
        }

    }
}
