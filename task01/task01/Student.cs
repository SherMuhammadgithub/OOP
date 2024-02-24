using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float MatricMarks;
        public float Merit;
        public bool IsRegistered;
        public List<DegreeProgram> DegreeProgram;
        Student(string name, int age, float fsc, float matric, List<DegreeProgram> preferences)
        {
            Name = name;
            Age = age;
            FscMarks = fsc;
            Merit = matric;
            DegreeProgram = preferences;
            
        }
        public void CalculateMerit()
        {
            Merit = (FscMarks + MatricMarks) / 200;
        }

       

    }
}
