using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL.FH
{
    public class ReportedAccountFH : IReportedAccount
    {
       public static List<ReportedAccount> reportedAccounts = new List<ReportedAccount>();
       public bool SaveReportedAccountInfo(ReportedAccount reportedAccount)
        {
            reportedAccounts.Add(reportedAccount);
            // saving to file
            SaveDataToFile(reportedAccount);
            return true;
        }
        // loading from file
        public void LoadReportedAccountData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("reportedAccounts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');

                        try
                        {
                            ReportedAccount reportedAccount = new ReportedAccount(
                                                               data[0],
                                                                                              data[1]
                                                                                                                         );
                            // add to list
                            reportedAccounts.Add(reportedAccount);
                        }
                        catch (FormatException ex)
                        {
                            //Console.WriteLine($"Error parsing data on line: {line} ({ex.Message})");
                        }
                        catch (Exception ex) // Catch other potential exceptions
                        {
                            //Console.WriteLine($"Error loading reported account: {ex.Message}");
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
              //  C//onsole.WriteLine("File not found, no reported accounts loaded.");
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error loading reported accounts: {ex.Message}");
            }
        }
        public bool SaveDataToFile(ReportedAccount reportedAccount)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("reportedAccounts.txt", true))
                {
                    writer.WriteLine($"{reportedAccount.GetAccountHolder()},{reportedAccount.GetReason()}");
                }
                return true;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error saving reported account: {ex.Message}");
                return false;
            }
        }
        public ReportedAccount isReported(string accountHolder)
        {
            foreach (ReportedAccount reportedAccount in reportedAccounts)
            {
                if (reportedAccount.GetAccountHolder() == accountHolder)
                {
                    return reportedAccount;
                }
            }
            return null;
        }
        // delete the reported account from the list
        public bool UnreportAccount(string accountHolder)
        {
            ReportedAccount reportedAccount = isReported(accountHolder);
            if (reportedAccount != null)
            {
                reportedAccounts.Remove(reportedAccount);
                bool isUnreported = UnreportAccountInFile(accountHolder);

                return isUnreported;
            }
            return false;
        }
        // elete the reported account from the file
        public bool UnreportAccountInFile(string accountHolder)
        {
            try
            {
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader("reportedAccounts.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data[0] != accountHolder)
                        {
                            lines.Add(line);
                        }
                    }
                }
                using (StreamWriter writer = new StreamWriter("reportedAccounts.txt"))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
               // Console.WriteLine($"Error unreporting account: {ex.Message}");
                return false;
            }
        }
    }
}
