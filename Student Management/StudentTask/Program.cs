using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            while(true)
            {
                Console.Clear();
                int option = Print_Board();
                if(option == 1)
                {
                    Console.Clear();
                    student.Add_Std();
                }
                else if(option == 2)
                {
                    student.showStudents();
                }
                Console.ReadKey();
            }

        }
        static int Print_Board()
        {
            Console.WriteLine("1.Add Student ");
            Console.WriteLine("2.Add Student ");
            Console.WriteLine("3.Add Student ");
            Console.Write("Enter your choice  ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        static Student Add_Std()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            Student student = new Student();
            student.Name = name;
            student.Marks = marks;
            return student;
        }
    }
}
