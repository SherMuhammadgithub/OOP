using BMS.BL;
using BMS.DL;
using BMS.DL.FH;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMS.UI.Accounts
{
    public partial class AccountzDet : Form
    {

        public AccountzDet()
        {
            InitializeComponent();
            LoadAccountInfo();
        }
        private void LoadAccountInfo()
        {
        MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
        Account currentAccount = currentUser.GetAccount();

           

            if (currentAccount == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            IpName.Text = currentAccount.GetAccountHolder();
            IpDOB.Text = currentAccount.GetDateOfBirth();
            IpAddress.Text = currentAccount.GetAddress();
            IpPhone.Text = currentAccount.GetPhone().ToString();
            IpSSN.Text = currentAccount.GetSocialSecurityNumber();
            IpMontlySalary.Text = currentAccount.GetMonthlyIncome().ToString();
            IpIntialDeposite.Text = currentAccount.GetIntialDeposit().ToString();
            IpAccountNum.Text = currentAccount.GetAccountNumber().ToString();
            BalanceLbl.Text = currentAccount.GetIntialDeposit().ToString();
            BalanceLbl.Text = $"Current Amount: {currentAccount.GetIntialDeposit()}";
            DebtLbl.Text = $"Debt Amount: {currentAccount.GetDebt()}";
            MessageBox.Show(currentAccount.GetIntialDeposit().ToString());
        }



        private void EditBtn_Click_1(object sender, EventArgs e)
        {

            IAccountDL accountDL = ObjectHandler.GetAccountDL();
            IMUserDL mUserDL = ObjectHandler.GetUserDL();
            ITransactionDL transactionDL = ObjectHandler.GetTransactionDL();
            MUser prevUser = mUserDL.GetCurrentUser();
            Account currentAccount = prevUser.GetAccount();
            // get the previous account holder name
            string prevAccountHolder = currentAccount.GetAccountHolder();
            currentAccount.SetAccountHolder(IpName.Text);
            currentAccount.SetDateOfBirth(IpDOB.Text);
            currentAccount.SetAddress(IpAddress.Text);
            currentAccount.SetPhone(Convert.ToInt32(IpPhone.Text));
            currentAccount.SetSocialSecurityNumber(IpSSN.Text);
            currentAccount.SetMonthlyIncome(Convert.ToInt32(IpMontlySalary.Text));
            currentAccount.SetIntialDeposit(Convert.ToInt32(IpIntialDeposite.Text));
            currentAccount.SetAccountNumber(Convert.ToInt32(IpAccountNum.Text));
            prevUser.SetUsername(IpName.Text);
            // updating loan information if loan exists
            bool isUpdated = true;
            // updating information
            if (!accountDL.UpdateAccountInfo(currentAccount, prevAccountHolder))
            {
                MessageBox.Show("account");
                isUpdated = false;
            }
            if (!mUserDL.UpdateUserInfo(prevUser, prevAccountHolder))
            {
                MessageBox.Show("user");
                isUpdated = false;
            }
            // check if the transactions for the current acccount exists
            if (currentAccount.GetTransactions().Count > 0) // if transactions exists
            {
                MessageBox.Show("transactions");
                isUpdated = transactionDL.UpdtateAccountHolder(prevAccountHolder, IpName.Text);
            }

            if (currentAccount.GetLoan() != null)
            {
                MessageBox.Show("loan");
                currentAccount.GetLoan().SetAccountHolder(IpName.Text);
                isUpdated = ObjectHandler.GetLoanDL().UpdateLoanInfo(IpName.Text, prevAccountHolder);
            }
            if (isUpdated)
            {
                
                MessageBox.Show("Information Updated");
             
                this.Close();
               //Dashboard dashboard = new Dashboard();
               // dashboard.NameLbl.Text = currentAccount.GetAccountHolder();
               // dashboard.BalanceLbl.Text = currentAccount.GetIntialDeposit().ToString();
               // dashboard.SalaryLbl.Text = currentAccount.GetMonthlyIncome().ToString();
               // dashboard.DebtLbl.Text = currentAccount.GetDebt().ToString();
               // dashboard.Show();


                return;
            }
            MessageBox.Show("Error Updating information");
        }
    }
}
