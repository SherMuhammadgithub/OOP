using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Subjects
    {
        public int code;
        public int creditHours;
        public string name;
        public int Fees;

        public Subjects(int code, int creditHours, string name, int fees)
        {
            this.code = code;
            this.creditHours = creditHours;
            this.name = name;
            Fees = fees;
        }
        public void StoreInFile(string path, Subjects subject)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(subject.code + "," + subject.name + "," + subject.creditHours + "," + subject.Fees);
        }

    }
}
