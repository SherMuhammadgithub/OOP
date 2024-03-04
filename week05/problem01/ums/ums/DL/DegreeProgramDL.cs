using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ums
{
    internal class DegreeProgramDL
    {
        public static List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
        public static void AddDegreeProgram(DegreeProgram degreeProgram)
        {
            degreePrograms.Add(degreeProgram);
        }
        //publii
        public static DegreeProgram IsDegreeExists(string degreeName)
        {
            foreach (var degree in degreePrograms)
            {
                if (degree.Title == degreeName)
                {
                    return degree;
                }
            }
            return null;
        }
        public static List<DegreeProgram> AvaialbeDegreePrograms()
        {
            return degreePrograms;
        }
    }
}
