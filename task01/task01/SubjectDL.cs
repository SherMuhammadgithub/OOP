using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class SubjectDL
    {
        List<Subject> Subjects;
        SubjectDL() {
            Subjects = new List<Subject>();
        }

        public void AddSubject(Subject subjects)
        {
            Subjects.Add(subjects);
        }
    }
}
