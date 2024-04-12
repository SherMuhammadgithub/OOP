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
using System.Xml.Linq;

namespace BMS.UI.Admin
{
    public partial class ReportAccountForm : Form
    {
        public ReportAccountForm()
        {
            InitializeComponent();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            string accountHolder = IpRepAccountName.Text;
            string reason = IpReason.Text;
            // add to reported accounts
            ReportedAccount reportedAccount = new ReportedAccount(accountHolder, reason);
            bool isReported = ObjectHandler.GetReportedAccountDL().SaveReportedAccountInfo(reportedAccount);
            if (isReported)
            {
                MessageBox.Show("Account reported successfully");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                
            }
            else
            {
                MessageBox.Show("Account not reported");
            }
        }
    }
}
