using BMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class LoanForm : Form
    {
          
        public LoanForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account account = currentUser.GetAccount();
            bool isApplied = account.CreateLoan(account.GetAccountHolder(),Convert.ToInt32(IpAmount.Text), Convert.ToInt32(IpMonthlyPay.Text));
            if (isApplied)
            {
                MessageBox.Show("Loan Applied");
            }
            else
            {
                MessageBox.Show("Loan already applied....");
            }
           
           

        }
        private void LoadData()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account account = currentUser.GetAccount();
            IpName.Text = account.GetAccountHolder();
        }
    }
}
