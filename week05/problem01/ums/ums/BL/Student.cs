using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ums
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EntryTestMarks;
        public float Merit;
        public bool IsSelected;
        public  List<DegreeProgram> DegreePrograms;

        public Student(string name, int age, float fscMarks, float entryTestMarks, List<DegreeProgram> degreePrograms)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EntryTestMarks = entryTestMarks;
            DegreePrograms = degreePrograms;
        }
        public  void AddDegreeProgram(DegreeProgram degreeProgram)
        {
            DegreePrograms.Add(degreeProgram);
        }
    }
}
