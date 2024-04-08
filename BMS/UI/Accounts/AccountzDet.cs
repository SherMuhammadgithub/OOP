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

        private void AccountzDet_Load(object sender, EventArgs e)
        {

        }
        private void LoadAccountInfo()
        {
            // loading Balance 
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
            MessageBox.Show(currentAccount.GetIntialDeposit().ToString());
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            IAccountDL accountDL = ObjectHandler.GetAccountDL();
            IMUserDL mUserDL = ObjectHandler.GetUserDL();
            ITransactionDL transactionDL = ObjectHandler.GetTransactionDL();
            // update the account
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
            currentAccount.GetLoan().SetAccountHolder(IpName.Text);
            MessageBox.Show("Account updated successfully..........");
            // updating in the database & list
            accountDL.UpdateAccountInfo(currentAccount, prevAccountHolder);
            transactionDL.UpdtateAccountHolder(prevAccountHolder, IpName.Text); // update account holder in transactions                                                                    
            mUserDL.UpdateUserInfo(prevUser, prevAccountHolder);
            ObjectHandler.GetLoanDL().UpdateLoanInfo(currentAccount.GetLoan(), prevAccountHolder);
        }

        private void BalanceLbl_Click(object sender, EventArgs e)
        {
        
        }
    }
}
