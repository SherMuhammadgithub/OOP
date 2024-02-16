using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    internal class Student
    {
        List <Student> students=new List<Student>();
        public Student() // default constructor
        { }
        public Student(string name, int id, int marks) {
            Name = name;
            Id = id;
          Marks = marks;
        }
        public void agreegate()
        {
            foreach(var stds in students)
            {

                stds.agregate = Marks / 100;
            }
        }
        public void showStudents()
        {
            foreach(var stds in students)
            {
                Console.WriteLine($"{stds.Name} has aggregate {stds.agregate}");
            }
        }
        public void Add_Std()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Marks: ");
            Student student = new Student(name, id, marks);
            student.Name = name;
            student.Marks = marks;
            students.Add(student);
        }
        public int Id;
        public string Name;
        public int Marks;
        public float agregate;

    }
}
