using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL.FH
{
    internal class LoanFH : ILoanDL
    {
        public static List<Loan> loans = new List<Loan>();

        public bool SaveLoan(Loan loan)
        {
            loans.Add(loan);
            bool isSaved = SaveLoanInFile(loan);
            return isSaved;
        }


        public static List<Loan> GetLoans()
        {
            return loans;
        }

        // saving loan to using file
        public bool SaveLoanInFile(Loan loan)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("loan.txt", true))
                {
                    writer.WriteLine(loan.GetAccountHolder() + "," + loan.GetLoanAmount() + "," + loan.GetMonthlyPayment());
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        
        public Loan isLoanExists(string AccountHolder)
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
       // load data using file 
       public  bool LoadLoanData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("loan.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        Loan loan = new Loan(data[0], Convert.ToInt32(data[1]), Convert.ToInt32(data[2]));
                        // add to list
                        loans.Add(loan);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                return false;
        }
        // updating in file without creating new file
      public bool UpdateLoanInfo(Loan loan, string prevAccountHolder)
        {
            try
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader("loan.txt"))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data[0] == prevAccountHolder)
                        {
                            sw.WriteLine(loan.GetAccountHolder() + "," + loan.GetLoanAmount() + "," + loan.GetMonthlyPayment());
                        }
                        else
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
                File.Delete("loan.txt");
                File.Move(tempFile, "loan.txt");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
