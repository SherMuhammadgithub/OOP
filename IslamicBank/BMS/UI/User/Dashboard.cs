using BMS.BL;
using BMS.UI.Accounts;
using BMS.UI.User;
using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void AccountPgBtn_Click(object sender, EventArgs e)
        {
           // this.Close();
            AccountzDet accountzDet = new AccountzDet();
            accountzDet.Show();
        }


        private void HistoryPgBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            History history = new History();
            history.Show();
        }
        private void LoadDashboard()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            NameLbl.Text = currentUser.GetUsername();
         
            if (currentAccount != null)
            {
                AddBtn.Enabled = false;
                AddBtn.BackColor = Color.White;
                AccountPgBtn.Enabled = true;
                TransferBtn.Enabled = true;
                MoneyActionPgBtn.Enabled = true;
                BankFeePgBtn.Enabled = true;
                HistoryPgBtn.Enabled = true;
                LoanPgBtn.Enabled = true;
                settings.Enabled = true;
                restrictionPanel.Visible = false;
                BalanceLbl.Text = currentAccount.GetIntialDeposit().ToString();
                DebtLbl.Text = currentAccount.GetDebt().ToString();
                SalaryLbl.Text = currentAccount.GetMonthlyIncome().ToString();
            }
            else
            {
                AddBtn.Enabled = true;
                AccountPgBtn.Enabled = false;
                TransferBtn.Enabled = false;
                MoneyActionPgBtn.Enabled = false;
                HistoryPgBtn.Enabled = false;
                BankFeePgBtn.Enabled = false;
                LoanPgBtn.Enabled = false;
                settings.Enabled = false;
                restrictionPanel.Visible = true;
            }
        }
        private void BankFeePgBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InterestRates interestRates = new InterestRates();
            interestRates.Show();
        }

        private void LoanPgBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoanForm loanForm = new LoanForm();
            loanForm.Show();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            Transfer transfer = new Transfer();
            transfer.Show();
        }

        private void MoneyActionPgBtn_Click(object sender, EventArgs e)
        {
            MoneyActions moneyActions = new MoneyActions();
            moneyActions.Show();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }


        private void ReadMoreBtn_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void LogoutBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }
    }
}
