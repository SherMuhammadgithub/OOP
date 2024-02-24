using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS
{
    class Utility
    {
        
        public void AddDegreeProgram(DegreeProgram program)
        {
            DegreeProgramDL.AddDegreeProgram(program);
        }
        public void AddStudent(Student std)
        {
            StudentsDL.AddStudent(std);
        }
        public void GenerateMerit()
        {
            StudentsDL.GenerateMeritList();
        }
        public void SpecificDegree(string stdName)
        {
            StudentsDL.SpecificDegree(stdName);
        }
        public List<Student> RegisteredStudents()
        {
            return StudentsDL.RegisteredStudents();
        }
        public void RegisterSubjects(string studentName, int subjectCode)
        {
            StudentsDL.RegisterSubjects(studentName, subjectCode);
        }
        public void CalculateMerit()
        {
            StudentsDL.CalculateMerit();
        }
        public int GenerateFeeChalan(string stdName)
        {
            return StudentsDL.GenerateFeeChallan(stdName);
        }
        public Student InputStdData(List<DegreeProgram> deg)
        {
            return StudentsUI.InputStudent(deg);
        }
        public DegreeProgram InputDegree()
        {
           return DegreeProgramUI.InputDegreeProgram();
        }
        public List<DegreeProgram> Avail()
        {
            return DegreeProgramDL.AvaialbeDegreePrograms();
        }
    }
}
