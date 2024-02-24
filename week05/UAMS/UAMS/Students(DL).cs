using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class StudentsDL
    {
        public static List<Student> Std = new List<Student>();
        public static void ShowAllStudents()
        {
            foreach (var student in Std)
            {
                Console.WriteLine($"Name-{student.Name} FSC-{student.FscMarks} Ecat-{student.EntryTestMarks} Age-{student.Age}");
            }
        }
        public static void AddStudent(Student student)
        {
            Std.Add(student);
        }
        public static List<Student> RegisteredStudents()
        {
            var meritList = new List<Student>();
            foreach (var student in Std)
            {
                foreach (var degreeProgram in Student.DegreePrograms)
                {
                    foreach (var studentInList in Std)
                    {
                        studentInList.IsSelected = false;
                    }
                    var studentsForProgram = Std
                        .Where(s => Student.DegreePrograms.Contains(degreeProgram))
                        .OrderByDescending(s => s.Merit)
                        .ToList();

                    int availableSeats = degreeProgram.AvailabeSeats;

                    meritList = studentsForProgram.Take(Math.Min(studentsForProgram.Count, availableSeats)).ToList();


                    foreach (var studentInList in meritList)
                    {
                        studentInList.IsSelected = true;
                    }
                }

            }
            return meritList;
        }
        public static void SpecificDegree(string dereeName)
        {
            Console.WriteLine($"Students registered in {dereeName} are:");
            foreach (var stds in Std)
            {
                if (stds.IsSelected)
                {
                    foreach (var degree in Student.DegreePrograms)
                    {
                        if (degree.Title == dereeName)
                        {
                            Console.WriteLine($"Name-{stds.Name} FSC-{stds.FscMarks} Ecat-{stds.EntryTestMarks} Age-{stds.Age} ");
                        }
                    }
                }

            }
        }
        public static void GenerateMeritList()
        {
            foreach (var student in Std)
            {
                foreach (var degreeProgram in Student.DegreePrograms)
                {
                    if (student.IsSelected)
                    {
                        Console.WriteLine($"{student.Name} is registered in {degreeProgram.Title}");
                    }
                    else
                    {
                        Console.WriteLine($"{student.Name} is not registered in {degreeProgram.Title}");
                    }
                }
            }
        }
        public static string RegisterSubjects(string studentName, int subjectCode)
        {
            foreach (var student in Std)
            {
                if (student.Name == studentName)
                {
                    foreach (var degreeProgram in Student.DegreePrograms)
                    {
                        foreach (var subject in degreeProgram.Subjects)
                        {
                            if (subject.code == subjectCode)
                                return $"{student.Name} is registered in {subject.name}";
                        }
                    }
                }

            }
            return "Student not found";
        }
        public static int GenerateFeeChallan(string studentName)
        {
            foreach (var student in Std)
            {
                if (student.Name == studentName)
                {
                    int totalFee = 0;
                    foreach (var degreeProgram in Student.DegreePrograms)
                    {
                        foreach (var subject in degreeProgram.Subjects)
                        {
                            totalFee += subject.Fees;
                        }
                    }
                    return totalFee;
                }
            }
            return 0;
        }
        public static void CalculateMerit()
        {
            foreach (var student in Std)
            {
                student.Merit = (student.FscMarks / 1100) * 70 + (student.EntryTestMarks / 100) * 30;
            }
        }
        public static void StoreUserData(string path, Student std)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degrees = "";
            for (int i = 0; i < Student.DegreePrograms.Count - 1; i++)
            {
                degrees = degrees + Student.DegreePrograms[i].Title + ";";
            }
            degrees = degrees + Student.DegreePrograms[Student.DegreePrograms.Count - 1].Title;
            f.WriteLine(std.Name + "," + std.Age + "," + std.FscMarks + "," + std.EntryTestMarks + "," + degrees);
            f.Flush();
            f.Close();
        }
        public static bool LoadStdData(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader f = new StreamReader(path))
                {
                    string line;
                    while ((line = f.ReadLine()) != null)
                    {
                        string[] data = line.Trim().Split(',');
                        if (data.Length >= 5)
                        {
                            string name = data[0];
                            int age = Convert.ToInt32(data[1]);
                            float fscMarks = Convert.ToSingle(data[2]);
                            float entryTestMarks = Convert.ToSingle(data[3]);
                            string[] degrees = data[4].Split(';');
                            Console.WriteLine($"{name} {age} {fscMarks} {entryTestMarks}");
                            List<DegreeProgram> degreePrograms = new List<DegreeProgram>();
                            foreach (var degree in degrees)
                            {
                                DegreeProgram d = DegreeProgramDL.IsDegreeExists(degree);
                                if (d != null)
                                {
                                    degreePrograms.Add(d);
                                }
                            }
                            Student std = new Student(name, age, fscMarks, entryTestMarks, degreePrograms);
                            StudentsDL.AddStudent(std);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid data format: {line}");
                        }
                    }
                }
                return true;
            }
            return false;
        }

    }
}