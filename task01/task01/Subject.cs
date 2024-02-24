using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task01
{
    internal class Subject
    {
        public string SubCode;
        public int CreditHours;
        public string SubType;
        public int SubFee;

        public Subject(string code, int credit, string type, int fee) {
            SubCode = code;
            CreditHours = credit;
            SubType = type;
            SubFee = fee;
        }
    }
}
