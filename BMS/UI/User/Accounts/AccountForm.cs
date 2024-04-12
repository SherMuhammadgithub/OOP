﻿using BMS.BL;
using BMS.DL;
using BMS.UI.Accounts;
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            string AccountHolder = IpName.Text.ToString();
            string DateOfBirth = IpDOB.Text.ToString();
            string Address = IpAddress.Text.ToString();
            int Phone = Convert.ToInt32(IpPhone.Text.ToString());
            string SocialSecurityNumber = IpSSN.Text.ToString();
            int MonthlyIncome = Convert.ToInt32(IpMontlySalary.Text.ToString());
            int IntialDeposit = Convert.ToInt32(IpIntialDeposite.Text.ToString());
            string type = AccountTypeCb.SelectedItem.ToString();
            currentUser.CreateAccount(DateOfBirth, Address, Phone, SocialSecurityNumber, MonthlyIncome, IntialDeposit, AccountHolder, type);
           // currentUser.SetCurrentAccount(currentUser.GetAccount());
            currentUser.GetAccount().GenerateAccountNumber(); // generate account number
                                                              // store in the database & list
           bool isSaved = ObjectHandler.GetAccountDL().SaveAccountInfo(currentUser.GetAccount());
            if(isSaved)
            {
            MessageBox.Show("Account created successfully");

            }
            else
            {
                MessageBox.Show("Account not created successfully");
            }
            this.Close();
            Dashboard dashboard = new Dashboard();
            dashboard.BalanceLbl.Text = currentUser.GetAccount().GetIntialDeposit().ToString();
            dashboard.SalaryLbl.Text = currentUser.GetAccount().GetMonthlyIncome().ToString();
            dashboard.DebtLbl.Text = currentUser.GetAccount().GetDebt().ToString();
            dashboard.Show();
            
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
    }
}
