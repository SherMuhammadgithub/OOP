using BMS.BL;
using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class AdminPannel : Form
    {
        public AdminPannel()
        {
            InitializeComponent();
            LoadData();
            LoadTotalBalance();
            LoadReportedAccounts();
        }
        private void LoadData()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
            // clear the chart
            chart1.Series["AccountType"].Points.Clear();
            var amountSeries = chart1.Series["AccountType"];

            // Check if there are transactions
            if (accounts.Count > 0)
            {
                int savings = 0;
                int checkings = 0;
                foreach (Account acc in accounts)
                {
                    if (acc.GetAccountType() == "savings")
                    {
                        savings++;
                    }
                    else
                    {
                        checkings++;
                    }
                }
                    MessageBox.Show("Loading Accounts Data" + savings + " " + checkings);
                    amountSeries.Points.AddXY("Savings", savings);
                amountSeries.Points.AddXY("Checkings", checkings);
                

                // Hide the "No Transactions" label
            }
           
        }
        private void LoadTotalBalance()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
            // 
            double totalBalance = 0;
            int accountCount = 0;
            foreach (Account acc in accounts)
            {
                totalBalance += acc.GetIntialDeposit();
                accountCount++;
            }
            balance.Text = totalBalance.ToString();
            accountslbl.Text = accountCount.ToString();

        }
        private void LoadReportedAccounts()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
            //
            int reportedAccounts = 0;
            foreach (Account acc in accounts)
            {
                if (ObjectHandler.GetReportedAccountDL().isReported(acc.GetAccountHolder()) != null)
                {
                    reportedAccounts++;
                }
            }
            reportedAcc.Text = reportedAccounts.ToString();
        }
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.Show();
        }

        private void VipUsersPg_Click(object sender, EventArgs e)
        {
            VipUsersForm vipUsersForm = new VipUsersForm();
            vipUsersForm.Show();
        }

        private void AdminPannel_Load(object sender, EventArgs e)
        {

        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void viewPgBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewUsers viewUsers = new ViewUsers();
            viewUsers.Show();
        }

        private void RefreshPgBtn_Click(object sender, EventArgs e)
        {
            LoadData();
            LoadTotalBalance();
            LoadReportedAccounts();
        }

        private void vipUsersPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VipUsersForm vipUsersForm = new VipUsersForm();
            vipUsersForm.Show();
        }
    }
}
