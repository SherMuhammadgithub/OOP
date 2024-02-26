<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EntryTestMarks;
        public float Merit;
        public bool IsSelected;
        public static List<DegreeProgram> DegreePrograms;

        public Student(string name, int age, float fscMarks, float entryTestMarks, List<DegreeProgram> degreePrograms)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EntryTestMarks = entryTestMarks;
            DegreePrograms = degreePrograms;
        }
        public static void AddDegreeProgram(DegreeProgram degreeProgram)
        {
            DegreePrograms.Add(degreeProgram);
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Student
    {
        public string Name;
        public int Age;
        public float FscMarks;
        public float EntryTestMarks;
        public float Merit;
        public bool IsSelected;
        public static List<DegreeProgram> DegreePrograms;

        public Student(string name, int age, float fscMarks, float entryTestMarks, List<DegreeProgram> degreePrograms)
        {
            Name = name;
            Age = age;
            FscMarks = fscMarks;
            EntryTestMarks = entryTestMarks;
            DegreePrograms = degreePrograms;
        }
        public static void AddDegreeProgram(DegreeProgram degreeProgram)
        {
            DegreePrograms.Add(degreeProgram);
        }

    }
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
