using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class DegreeProgramDL
    {
        List<DegreeProgram> Degree;
        DegreeProgramDL()
        {
            Degree = new List<DegreeProgram>();
        }

        public void AddDegreeProgram(DegreeProgram degree)
        {
            Degree.Add(degree);
        }
    }
}
