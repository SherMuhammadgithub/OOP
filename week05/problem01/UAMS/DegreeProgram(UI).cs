<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class DegreeProgramUI
    {
         public static DegreeProgram InputDegreeProgram()
        {
            string SubjectPath = "C:\\Users\\dell\\Pictures\\C#OOP(Programmig)\\UAMS\\UAMS\\Subjects.txt";
            Console.WriteLine("Enter Title of Degree Program");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Duration of Degree Program");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Availabe Seats of Degree Program");
            int availabeSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Subjects in Degree Program");
            int noOfSubjects = Convert.ToInt32(Console.ReadLine());
            List<Subjects> subjects = new List<Subjects>();
            for (int i = 0; i < noOfSubjects; i++)
            {
                Console.WriteLine("Enter Code of Subject");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Credit Hours of Subject");
                int creditHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name of Subject");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Fees of Subject");
                int fees = Convert.ToInt32(Console.ReadLine());
                Subjects subject = new Subjects(code, creditHours, name, fees);
                subjects.Add(subject);
                SubjectDL.AddSubject(subject);
                SubjectDL.StoreInFile(SubjectPath, subject);
            }
            return new DegreeProgram(title, duration, availabeSeats, subjects);
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
    class DegreeProgramUI
    {
         public static DegreeProgram InputDegreeProgram()
        {
            string SubjectPath = "C:\\Users\\dell\\Pictures\\C#OOP(Programmig)\\UAMS\\UAMS\\Subjects.txt";
            Console.WriteLine("Enter Title of Degree Program");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Duration of Degree Program");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Availabe Seats of Degree Program");
            int availabeSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Subjects in Degree Program");
            int noOfSubjects = Convert.ToInt32(Console.ReadLine());
            List<Subjects> subjects = new List<Subjects>();
            for (int i = 0; i < noOfSubjects; i++)
            {
                Console.WriteLine("Enter Code of Subject");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Credit Hours of Subject");
                int creditHours = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name of Subject");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Fees of Subject");
                int fees = Convert.ToInt32(Console.ReadLine());
                Subjects subject = new Subjects(code, creditHours, name, fees);
                subjects.Add(subject);
                SubjectDL.AddSubject(subject);
                SubjectDL.StoreInFile(SubjectPath, subject);
            }
            return new DegreeProgram(title, duration, availabeSeats, subjects);
        }
    }
>>>>>>> 929eb54b0403aac88bf256c4649c760b01f8f8b0
}