using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Student : Person
    {
        private string program;
        private double fee;
        private int year;  

        public Student(string name, string address, string program, double fee, int year) : base(name, address)
        {
            this.program = program;
            this.fee = fee;
            this.year = year;
        }
        public string GetProgram()
        {
            return program;
        }
        public void SetProgram(string program)
        {
            this.program = program;
        }
        public double GetFee()
        {
            return fee;
        }
        public void SetFee(double fee)
        {
            this.fee = fee;
        }
        public int GetYear()
        {
            return year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public new string InToString() // override
        {
            string nameAndAddress = base.InToString(); // call base class method
            return $"{nameAndAddress} is studying {program} and is in year {year}";
        }
    }
}
