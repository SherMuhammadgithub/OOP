using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class Loan
    {
        private string AccountHolder;
        private int LoanAmount;
        private int MonthlyPayment;

        public Loan(string AccountHolder, int LoanAmount, int MonthlyPayment)
        {
            this.AccountHolder = AccountHolder;
            this.LoanAmount = LoanAmount;
            this.MonthlyPayment = MonthlyPayment;
        }


        public string GetAccountHolder()
        {
            return AccountHolder;
        }
        public int GetLoanAmount()
        {
            return LoanAmount;
        }
        public int GetMonthlyPayment()
        {
            return MonthlyPayment;
        }
        public void SetAccountHolder(string AccountHolder)
        {
            this.AccountHolder = AccountHolder;
        }
        public void SetLoanAmount(int LoanAmount)
        {
            this.LoanAmount = LoanAmount;
        }
        public void SetMonthlyPayment(int MonthlyPayment)
        {
            this.MonthlyPayment = MonthlyPayment;
        }

    }
}
