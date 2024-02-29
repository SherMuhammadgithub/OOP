<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
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
        public static void StoreDegreePrograms(string path, DegreeProgram degree)
        {
            StreamWriter f = new StreamWriter(path, true);
            string subjects = "";
            for (int i = 0; i < degree.Subjects.Count - 1; i++)
            {
                subjects = subjects + degree.Subjects[i].name + ";";
            }
            subjects = subjects + degree.Subjects[degree.Subjects.Count - 1].name;
            f.WriteLine(degree.Title + "," + degree.Duration + "," + degree.AvailabeSeats + "," + subjects);
            f.Flush();
            f.Close();
        }
        public static bool LoadData(string path)
        {
            StreamReader f = new StreamReader(path);
            string Record;
            if(File.Exists(path))
            {
                while((Record = f.ReadLine()) != null)
                {
                    string line = f.ReadLine();
                    string[] data = line.Trim().Split(',');
                    string title = data[0];
                    int duration = Convert.ToInt32(data[1]);
                    int availabeSeats = Convert.ToInt32(data[2]);
                    string[] subjects = data[3].Split(';');
                    List<Subjects> subjectsList = new List<Subjects>();
                    foreach (var subject in subjects)
                    {
                        Subjects s = SubjectDL.IsSubjectExists(subject);
                        if(s != null)
                        {

                        subjectsList.Add(s);
                        }
                    }
                    DegreeProgram degree = new DegreeProgram(title, duration, availabeSeats, subjectsList);
                    DegreeProgramDL.AddDegreeProgram(degree);
                }
                f.Close();
                    return true;
            }
            return false;
            
        }
    }
  
    
}
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
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
        public static void StoreDegreePrograms(string path, DegreeProgram degree)
        {
            StreamWriter f = new StreamWriter(path, true);
            string subjects = "";
            for (int i = 0; i < degree.Subjects.Count - 1; i++)
            {
                subjects = subjects + degree.Subjects[i].name + ";";
            }
            subjects = subjects + degree.Subjects[degree.Subjects.Count - 1].name;
            f.WriteLine(degree.Title + "," + degree.Duration + "," + degree.AvailabeSeats + "," + subjects);
            f.Flush();
            f.Close();
        }
        public static bool LoadData(string path)
        {
            StreamReader f = new StreamReader(path);
            string Record;
            if(File.Exists(path))
            {
                while((Record = f.ReadLine()) != null)
                {
                    string line = f.ReadLine();
                    string[] data = line.Trim().Split(',');
                    string title = data[0];
                    int duration = Convert.ToInt32(data[1]);
                    int availabeSeats = Convert.ToInt32(data[2]);
                    string[] subjects = data[3].Split(';');
                    List<Subjects> subjectsList = new List<Subjects>();
                    foreach (var subject in subjects)
                    {
                        Subjects s = SubjectDL.IsSubjectExists(subject);
                        if(s != null)
                        {

                        subjectsList.Add(s);
                        }
                    }
                    DegreeProgram degree = new DegreeProgram(title, duration, availabeSeats, subjectsList);
                    DegreeProgramDL.AddDegreeProgram(degree);
                }
                f.Close();
                    return true;
            }
            return false;
            
        }
    }
  
    
}
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
