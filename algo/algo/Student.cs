using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    internal class Student
    {
        public string name;
        public int roll_number;
        public float cgpa;
        public int matric_marks;
        public int fsc_marks;
        public int ecat_marks;
        public string home_town;
        public bool is_hostelite;
        public bool is_taking_schloarship;
        //Creating a constructor
        public Student(int matric, int fcs, bool is_hostelite)
        {
            matric_marks = matric;
            fsc_marks = fcs;
            this.is_hostelite = is_hostelite;
        }

        public float CalculateMerit()
        {
            int cal_merit = (fsc_marks + matric_marks)/400;
            cal_merit *= 100;
            return cal_merit;
        }
        public bool IsEligibleForScholarship(float merit_percentage)
        {
            if(merit_percentage > 80 && is_hostelite)
            {
                return true;
            }
            return false;
        }
    }
}
