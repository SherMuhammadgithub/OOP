
using BMS.BL;
using BMS.UI.User;
using BMS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void IpFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOginBtn_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(InputName.Text, InputPass.Text);

            if (ObjectHandler.GetUserDL().SignIn(user))
            {
                MessageBox.Show("User signed in successfully");
                // setting the current user
                ObjectHandler.GetUserDL().StoreCurrentUser(user);

                // setting current customer Account
                MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();

                Account account = ObjectHandler.GetAccountDL().isAccountExists(currentUser.GetUsername());
                if (account != null)
                {
                    // check if the account is reported
                    ReportedAccount reportedAccount = ObjectHandler.GetReportedAccountDL().isReported(account.GetAccountHolder());
                    if (reportedAccount != null)
                    {
                        MessageBox.Show("Account is reported");
                        Reported reported = new Reported();
                        reported.NameLbl.Text = reportedAccount.GetAccountHolder();
                        reported.ReasonLbl.Text = reportedAccount.GetReason();
                        reported.Show();
                        return;
                    }
                    currentUser.SetCurrentAccount(account); // setting the current account
                    // setting the loan for the account
                    Loan loan = ObjectHandler.GetLoanDL().isLoanExists(account.GetAccountHolder());
                    if (loan != null)
                    {
                        account.SetLoan(loan);
                    }
                    else
                    {
                        account.SetLoan(null);
                    }
                    // setting transactions for the account
                    account.SetTransactions(ObjectHandler.GetTransactionDL().GetTransactionsForSpecificAccount(account.GetAccountHolder()));
                    MessageBox.Show("Account found");
                }
                // if account not found
                else
                {
                    MessageBox.Show("Account not found");
                    this.Hide();
                    Dashboard dashboard1 = new Dashboard();
                    dashboard1.NameLbl.Text = currentUser.GetUsername().ToString();
                    dashboard1.Show();
                    currentUser.SetCurrentAccount(null);
                    return;
                }
                // when account found
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.NameLbl.Text = currentUser.GetUsername().ToString();
                dashboard.BalanceLbl.Text = account.GetIntialDeposit().ToString();
                dashboard.SalaryLbl.Text = account.GetMonthlyIncome().ToString();
                dashboard.DebtLbl.Text = account.GetDebt().ToString();
                dashboard.Show();
            }
            else if(InputName.Text == "admin" && InputPass.Text == "admin")
            {
                this.Hide();
                AdminPannel adminPannel = new AdminPannel();
                adminPannel.Show();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPgLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SIgnUpForm sIgnUpForm = new SIgnUpForm();
            sIgnUpForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
