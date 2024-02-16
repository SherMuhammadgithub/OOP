using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(150, 150, true);
            float merit_percentage = student.CalculateMerit();
            bool is_eligible = student.IsEligibleForScholarship(merit_percentage);
            if(is_eligible)
            {
                Console.WriteLine("Eligible for Scholarship!");
            }
            else
            {
                Console.WriteLine("Not Eligible!");
            }

        }
    }
}
