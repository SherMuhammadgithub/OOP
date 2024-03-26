using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jane", "456 Elm St", "Computer Science", 1000, 1);
            Console.WriteLine(student.InToString());
            // staff object
            Staff staff = new Staff("John", "123 Oak St", "High School", 2000);
            Console.WriteLine(staff.InToString());

        }
    }
}
