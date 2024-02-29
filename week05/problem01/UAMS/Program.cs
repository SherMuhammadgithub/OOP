<<<<<<< HEAD
﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string DegPath = "C:\\Users\\dell\\Pictures\\C#OOP(Programmig)\\UAMS\\UAMS\\DegreeProgram.txt";
            string StdPath = "C:\\Users\\dell\\Pictures\\C#OOP(Programmig)\\UAMS\\UAMS\\Students.txt";
            string SubjectPath = "C:\\Users\\dell\\Pictures\\C#OOP(Programmig)\\UAMS\\UAMS\\Subjects.txt";
            if (SubjectDL.LoadSubjectData(SubjectPath))
            {
                Console.WriteLine("Subjects Loadede");

            }
            if (DegreeProgramDL.LoadData(DegPath))
            {
                Console.WriteLine("Degrees Data Loaded");
            }
            if (StudentsDL.LoadStdData(StdPath))
              {
                  Console.WriteLine("Stds Data Loaded");
              }
          
             
             
            Utility utility = new Utility();
            while (true)
            {
                Console.WriteLine("1. Add Degree Program");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Generate Mrit List");
                Console.WriteLine("4. Show Registered  Students");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 0)
                {
                    StudentsDL.ShowAllStudents();
                }
                if (choice == 1)
                {
                    DegreeProgram degreeProgram = utility.InputDegree();
                    utility.AddDegreeProgram(degreeProgram);
                    DegreeProgramDL.StoreDegreePrograms(DegPath, degreeProgram);
                }
                else if (choice == 2)
                {
                   List<DegreeProgram> deg = utility.Avail();
                    Student stdData = utility.InputStdData(deg);
                     utility.AddStudent(stdData);
                    StudentsDL.StoreUserData(StdPath, stdData);
                }
                else if (choice == 3)
                {
                    utility.GenerateMerit();
                }
                else if (choice == 4)
                {
                    utility.CalculateMerit();
                    var regStds = utility.RegisteredStudents();
                    foreach (var std in regStds)
                    {
                        Console.WriteLine($"{std.Name} has merit of {std.Merit}");
                    }
                }
                else if (choice == 5)
                {
                    utility.SpecificDegree("BSCS");
                }
                else if (choice == 6)
                {
                    utility.RegisterSubjects("Sher", 1);
                }
                else if(choice == 7)
                {
                    utility.GenerateFeeChalan("Sher");
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}

