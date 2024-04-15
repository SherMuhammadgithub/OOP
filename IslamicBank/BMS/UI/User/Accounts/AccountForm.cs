using BMS.BL;
using BMS.DL;
using BMS.UI.Accounts;
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

namespace BMS.UI
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            IpName.Text = ObjectHandler.GetUserDL().GetCurrentUser().GetUsername().ToString();
        }

        private void UserPannel_Load(object sender, EventArgs e)
        {

        }

        private void IpName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void IpDOB_TextChanged(object sender, EventArgs e)
        {
            AddBtn.Enabled = !string.IsNullOrEmpty(IpDOB.Text); 
        }

        private void IpPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpSSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click_1(object sender, EventArgs e)
        {
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidAmount = ValidateAmount(IpMontlySalary.Text);
            if (!isValidAmount)
            {
                validateSalary.Visible = true;
                return;
            }
            bool isValidPhone = ValidatePhone();
            if (!isValidPhone)
            {
                validatePhone.Visible = true;
                return;
            }
            bool isValidIntialDeposite = ValidateAmount(IpIntialDeposite.Text);
            if (!isValidIntialDeposite)
            {
                validateDep.Visible = true;
                return;
            }
            bool isValidSSN = ValidateAmount(IpSSN.Text);
            if (!isValidSSN)
            {
                validateSSN.Visible = true;
                return;
            }
            bool isValidDOB = ValidateDOB();
            if (!isValidDOB)
            {
                validateDOB.Visible = true;
                return;
            }
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            string AccountHolder = IpName.Text.ToString();
            string DateOfBirth = IpDOB.Text.ToString();
            string Address = IpAddress.Text.ToString();
            string Phone = IpPhone.Text.ToString();
            string SocialSecurityNumber = IpSSN.Text.ToString();
            int MonthlyIncome = Convert.ToInt32(IpMontlySalary.Text.ToString());
            int IntialDeposit = Convert.ToInt32(IpIntialDeposite.Text.ToString());
            string type = AccountTypeCb.SelectedItem.ToString();
            currentUser.CreateAccount(DateOfBirth, Address, Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder, type);
            // currentUser.SetCurrentAccount(currentUser.GetAccount());
            currentUser.GetAccount().GenerateAccountNumber(); // generate account number
                                                              // store in the database & list
            bool isSaved = ObjectHandler.GetAccountDL().SaveAccountInfo(currentUser.GetAccount());
            if (isSaved)
            {
                MessageBox.Show("Account created successfully");

            }
            else
            {
                MessageBox.Show("Account not created successfully");
            }
            
            this.Close();
        }
        private bool ValidateInput()
        {
            if (IpName.Text == "" || IpDOB.Text == "" || IpAddress.Text == "" || IpPhone.Text == "" || IpSSN.Text == "" || IpMontlySalary.Text == "" || IpIntialDeposite.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            return true;
        }
        private bool ValidateAmount(string amount)
        {
            string regex = @"^[0-9]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(amount, regex))
            {
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
    }
}
