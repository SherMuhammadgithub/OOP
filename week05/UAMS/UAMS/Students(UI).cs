using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UAMS
{
    class StudentsUI
    {
         
        public static Student InputStudent(List<DegreeProgram> deg)
        {
            Console.WriteLine("Enter Student Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Student Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Fsc Marks");
            float fscMarks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Student Entry Test Marks");
            float entryTestMarks = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Available Programs!");
            foreach(var d in deg)
            {
                Console.WriteLine(d.Title);
            }
            Console.WriteLine("Enter Number of Degree Programs");
            int degreeProgramsCount = Convert.ToInt32(Console.ReadLine());
            List<DegreeProgram> degreeProgramsForStds = new List<DegreeProgram>();
            Console.WriteLine("Enter Degree Program Title: ");
            for(int i = 0; i < degreeProgramsCount; i++)
            {
                 string title = Console.ReadLine();
                var degreeProgram = deg.Find(x => x.Title == title);
                if(degreeProgram != null)
                {
                    degreeProgramsForStds.Add(degreeProgram);
                }
                else
                {
                    Console.WriteLine("Degree Program Not Found");
                }
                
            }

             Student student = new Student(name, age, fscMarks, entryTestMarks, degreeProgramsForStds);
            return student;
        }
    }
}
