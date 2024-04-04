using BMS.DL;
using BMS.UI;                                        // Remaing code
using DatabaseProject;                  // enabled or diSabled button will be added
using System;
using System.Collections.Generic;      // Edit Info
using System.Linq;                       // Apply for loan
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // load the data from the database
            MUserDL.LoadData();
            // Accounts Data
            AccountDL.LoadAccounts();
            // Transactions Data
            TransactionDL.LoadTransactionData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrom());
        }
    }
}
