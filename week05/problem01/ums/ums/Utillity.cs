using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ums
{
    internal class Utillity
    {
        public void AddDegreeProgram(DegreeProgram program)
        {
            DegreeProgramDL.AddDegreeProgram(program);
        }
        public void AddStudent(Student std)
        {
            StudentDL.AddStudent(std);
        }
        public void GenerateMerit()
        {
            StudentDL.GenerateMeritList();
        }
        public void SpecificDegree(string stdName)
        {
            StudentDL.SpecificDegree(stdName);
        }
        public List<Student> RegisteredStudents()
        {
            return StudentDL.RegisteredStudents();
        }
        public void RegisterSubjects(string studentName, int subjectCode)
        {
            StudentDL.RegisterSubjects(studentName, subjectCode);
        }
        public void CalculateMerit()
        {
            StudentDL.CalculateMerit();
        }
        public int GenerateFeeChalan(string stdName)
        {
            return StudentDL.GenerateFeeChallan(stdName);
        }
        public Student InputStdData(List<DegreeProgram> deg)
        {
            return StudentUI.InputStudent(deg);
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
