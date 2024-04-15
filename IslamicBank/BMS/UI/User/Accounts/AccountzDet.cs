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
using System.Text.RegularExpressions;
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
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidPhone = ValidatePhone();
            if (!isValidPhone)
            {
                validateph.Visible = true;
                return;
            }
            bool isValidDOB = ValidateDOB();
            if (!isValidDOB)
            {
                vlaidateDob.Visible = true;
                return;
            }
            bool isValidMonthlySalary = ValidateNumber(IpMontlySalary.Text);
            if (!isValidMonthlySalary)
            {
                 validateMonthlyPay.Visible = true;
                return;
            }
           bool isValidName = ValidateName();
            if (!isValidName)
            {
                validateName.Visible = true;
                return;
            }
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
            currentAccount.SetPhone(IpPhone.Text);
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
                return;
            }
            MessageBox.Show("Error Updating information");
        }
        private bool ValidateInput()
        {
            // all fields are required
            if (IpName.Text == "" || IpDOB.Text == "" || IpAddress.Text == "" || IpPhone.Text == "" || IpSSN.Text == "" || IpMontlySalary.Text == "" || IpIntialDeposite.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            return true;
        }
        private bool ValidatePhone()
        {
            string regex = @"^[0-9]+$";
            // and must be 11 numbelong
            if (!Regex.IsMatch(IpPhone.Text, regex) || IpPhone.Text.Length != 11)
            {
                return false;
            }
            return true;
        }
        private bool ValidateDOB()
        {
            string regex = @"^(0?[1-9]|[12][0-9]|3[01])[-](0?[1-9]|1[012])[-]\d{4}$";
            // format be like DD/MM/YYYY
            if (!Regex.IsMatch(IpDOB.Text, regex))
            {
                return false;
            }
            return true;
        }
        private bool ValidateNumber(string num)
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(num, regex))
            {
                return false;
            }
            return true;
        }
        private bool ValidateName()
        {
            string regex = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(IpName.Text, regex))
            {
                return false;
            }
            return true;
        }
    }
}
