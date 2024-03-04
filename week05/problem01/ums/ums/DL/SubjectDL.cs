using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ums.UI;

namespace ums
{
    internal class SubjectDL
    {
        public static List<Subject> subjects = new List<Subject>();
        public static void AddSubject(Subject subject)
        {
            subjects.Add(subject);
        }
    }
}
