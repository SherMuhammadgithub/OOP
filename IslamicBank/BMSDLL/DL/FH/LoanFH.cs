using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL.FH
{
    public class LoanFH : ILoanDL
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
               // Console.WriteLine(ex.Message);
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
                    }
                        return true;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return false;
            }
        }
        // updating in file without creating new file
      public bool UpdateLoanInfo(string newAccountHolder, string prevAccountHolder)
        {
            try
            {
               // update only AccountHolder
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
                            sw.WriteLine(newAccountHolder + "," + data[1] + "," + data[2]);
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
               // Console.WriteLine(ex.Message);
                return false;
            }
        }
        // delete loan from list and file
        public bool DeleteLoan(Loan loan)
        {
            if (loan == null)
            {
                return true; // Indicate nothing was deleted 
            }

            // Remove from list only if it exists (prevents errors)
            bool removedFromList = loans.Remove(loan);

            if (removedFromList)
            {
                bool isDeletedFromFile = DeleteLoanFromFile(loan);
                return isDeletedFromFile;
            }
            else
            {
                // Loan not found in list (optional logging or message)
               // MessageBox.Show("Loan not found in list for deletion.");
                return false;
            }
        }

        public bool DeleteLoanFromFile(Loan loan)
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
                        if (data[0] != loan.GetAccountHolder()) // if not equal then write to temp file
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
                //Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
