using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ums
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram InputDegreeProgram()
        {
            Console.WriteLine("Enter Title of Degree Program");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Duration of Degree Program");
            int duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Availabe Seats of Degree Program");
            int availabeSeats = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Subjects in Degree Program");
            int noOfSubjects = Convert.ToInt32(Console.ReadLine());
            List<Subject> subjects = new List<Subject>();
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
                Subject subject = new Subject(code, creditHours, name, fees);
                subjects.Add(subject);
                SubjectDL.AddSubject(subject);
            }
            return new DegreeProgram(title, duration, availabeSeats, subjects);
        }
    }
}
