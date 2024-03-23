using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utillity utility = new Utillity();
            while (true)
            {
                Console.WriteLine("1. Add Degree Program");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Generate Mrit List");
                Console.WriteLine("4. Show Registered  Students");
                Console.WriteLine("5.Specific Degree");
                Console.WriteLine("6. Register Subjects");
                Console.WriteLine("7. Generate Fee Chalan");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    StudentDL.ShowAllStudents();
                }
                if (choice == 1)
                {
                    DegreeProgram degreeProgram = utility.InputDegree();
                    utility.AddDegreeProgram(degreeProgram);
                }
                else if (choice == 2)
                {
                    List<DegreeProgram> deg = utility.Avail();
                    Student stdData = utility.InputStdData(deg);
                    utility.AddStudent(stdData);
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
                else if (choice == 7)
                {
                    utility.GenerateFeeChalan("Sher");
                }
                else if(choice == 8)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}
