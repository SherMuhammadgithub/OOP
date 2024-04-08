using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL.DB
{
    internal class LoanDB : ILoanDL
    {
        public static List<Loan> loans = new List<Loan>();

        public bool SaveLoan(Loan loan)
        {
            loans.Add(loan);
            bool isSaved = SaveLoanInDbb(loan);
            return isSaved;
        }


        public static List<Loan> GetLoans()
        {
            return loans;
        }

        // saving loan to database
        public bool SaveLoanInDbb(Loan loan)
        {
            string Query = "INSERT INTO Loan (AccountHolder, Amount, MonthlyPayment) VALUES ('{0}',{1},{2})";
            Query = string.Format(Query, loan.GetAccountHolder(), loan.GetLoanAmount(), loan.GetMonthlyPayment());
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
        public  Loan isLoanExists(string AccountHolder)
        {
            foreach (Loan loan in loans)
            {
                if (loan.GetAccountHolder() == AccountHolder)
                {
                    return loan;
                }
            }
            return null;
        }
        public bool LoadLoanData()
        {
            string Query = "SELECT * FROM Loan";
            DataTable dt = utills.GetData(Query);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Loan loan = new Loan(row["AccountHolder"].ToString(), Convert.ToInt32(row["Amount"]), Convert.ToInt32(row["MonthlyPayment"]));
                    loans.Add(loan);
                }
                return true;
            }
            return false;
        }

        // updating accountolder in loan
      
        // updating in database
        public bool UpdateLoanInfo(Loan loan, string prevAccountHolder)
        {
            string Query = $"UPDATE Loan SET AccountHolder = '{loan.GetAccountHolder()}', Amount = {loan.GetLoanAmount()}, MonthlyPayment = {loan.GetMonthlyPayment()} WHERE AccountHolder = '{prevAccountHolder}'";
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
    }
}
