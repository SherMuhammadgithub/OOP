using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("John", "123 Main St", "Computer Science", 2020, 1000);
            Staff staff = new Staff("School of Computer Science", 100000);
            Console.WriteLine("Student: " + student.GetName() + " " + student.GetAddress() + " " + student.GetProgram() + " " + student.GetYear() + " " + student.GetFee());
            Console.WriteLine("Staff: " + staff.GetName() + " " + staff.GetAddress() + " " + staff.GetSchool() + " " + staff.GetPay());
        }
    }
}
