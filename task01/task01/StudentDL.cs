using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class StudentDL
    {
        List<Student> Students;
        StudentDL() { 
            Students = new List<Student>();
        }
        public void AddStudent(Student std)
        {
            Students.Add(std);
        }
   


        public void ViewRegisteredStds()
        {
            foreach (var student in Students)
            {
                
            }

        }

        }
}
