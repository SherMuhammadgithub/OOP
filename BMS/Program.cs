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
            MessageBox.Show("Loading User Data");
            ObjectHandler.GetUserDL().LoadData();
            // Accounts Data
            MessageBox.Show("Loading Accounts Data");
            ObjectHandler.GetAccountDL().LoadAccounts();
            // Transactions Data
            MessageBox.Show("Loading Transactions Data");
            ObjectHandler.GetTransactionDL().LoadTransactionData();
            // Loans Data
            MessageBox.Show("Loading Loans Data");
            ObjectHandler.GetLoanDL().LoadLoanData(); // bool
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrom());
        }
    }
}
