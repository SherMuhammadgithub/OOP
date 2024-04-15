using BMS.BL;
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
    public partial class LoanForm : Form
    {
          
        public LoanForm()
        {
            InitializeComponent();
            LoadData();
        }

      
        private void LoadData()
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account account = currentUser.GetAccount();
            IpName.Text = account.GetAccountHolder();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ApplyBtn_Click_1(object sender, EventArgs e)
        {
            bool isValid = ValidateInput();
            if (!isValid)
            {
                return;
            }
            bool isValidAmount = ValidateIpAmount();
            if (!isValidAmount)
            {
                validateAmount.Visible = true;

                return;
            }
            bool isValidMonthlyPay = ValidateMonthlyPay();
                if (!isValidMonthlyPay)
                {
                validateMonthlyPay.Visible = true;
                return;
            }
            validateMonthlyPay.Visible = false;
            validateAmount.Visible = false;
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account account = currentUser.GetAccount();

            Loan loan = new Loan(account.GetAccountHolder(), Convert.ToInt32(IpAmount.Text), 
                Convert.ToInt32(IpMonthlyPay.Text));
            bool isApplied = account.CreateLoan(loan);
            if (isApplied)
            {
                account.SetLoan(loan);
                ObjectHandler.GetLoanDL().SaveLoan(loan);
                MessageBox.Show("Loan Applied");
            }
            else
            {
                MessageBox.Show("Loan already applied....");
            }
        }
        private bool ValidateInput()
        {
            if (IpAmount.Text == "" || IpMonthlyPay.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return false;
            }
            return true;
        }
        private bool ValidateIpAmount()
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(IpAmount.Text, regex) && !Regex.IsMatch(IpMonthlyPay.Text, regex))
            {
                return false;
            }
            return true;
        }
        private bool ValidateMonthlyPay()
        {
            string regex = @"^[0-9]+$";
            if (!Regex.IsMatch(IpMonthlyPay.Text, regex))
            {
                return false;
            }
            return true;
        }
        private void LoanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
