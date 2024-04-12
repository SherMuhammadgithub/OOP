﻿using BMS.BL;
using BMS.UI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.Util;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BMS.UI
{
    public partial class SingleUser : Form
    {
        public SingleUser()
        {
            InitializeComponent();
           

        }
        private void isReeported()
        {
            string accountHolder = IpName.Text;
            ReportedAccount reportedAccount = ObjectHandler.GetReportedAccountDL().isReported(accountHolder);
            if (reportedAccount != null)
            {
                DeleteBtn.Enabled = false;
                UnreportBtn.Enabled = true;
                ReportedLbl.Visible = true;
            }
            else
            {
                DeleteBtn.Enabled = true;
                UnreportBtn.Enabled = false;
                ReportedLbl.Visible = false;
            }
        }
        private void LoadTransactions()
        {
            string accountHolder = IpName.Text;
            Loan loan = ObjectHandler.GetLoanDL().isLoanExists(accountHolder);
            if(loan != null)
            {
                IpLoan.Text = loan.GetLoanAmount().ToString();
                IpMonthlyPay.Text = loan.GetMonthlyPayment().ToString();
                IpLoanBtn.Enabled = true;
            }
            else
            {
                // disable the load btn
                IpLoanBtn.Enabled = false;
                IpLoan.Text = "No Loan";
                IpMonthlyPay.Text = "No Loan";
            }
            List<trans> transactions = ObjectHandler.GetTransactionDL().GetTransactionsForSpecificAccount(accountHolder);

            // Assuming your chart series are named "Amount"
            var amountSeries = chart1.Series["Amount"];

            // Check if there are transactions
            if (transactions.Count > 0)
            {
                // Loop through transactions and add data points (existing code)
                foreach (trans transaction in transactions)
                {
                    string type = transaction.GetTransactionType();
                    int amount = transaction.GetAmount();
                    amountSeries.Points.AddXY(type, amount);
                }

                // Hide the "No Transactions" label
                noTransactionsLabel.Visible = false; // Assuming your label name is "noTransactionsLabel"
            }
            else
            {
                // Show the "No Transactions" label
                noTransactionsLabel.Visible = true;

                // Optionally, clear the chart series (optional)
                amountSeries.Points.Clear();
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            ReportAccountForm reportAccountForm = new ReportAccountForm();
            reportAccountForm.IpRepAccountName.Text = IpName.Text;
            reportAccountForm.Show();

        }

        private void IpLoanBtn_Click(object sender, EventArgs e)
        {
            string AccountHolder = IpName.Text;
            Account accountToGiveLoan = ObjectHandler.GetAccountDL().isAccountExists(AccountHolder);
            Loan loan = ObjectHandler.GetLoanDL().isLoanExists(AccountHolder);
            // delete loan after giving the loan to the account holder
            bool isDelivered =  ObjectHandler.GetLoanDL().DeleteLoan(loan);
            bool isDeposited = accountToGiveLoan.Deposit(loan.GetLoanAmount(), accountToGiveLoan); // Deposit the loan amount to the account
            if (isDelivered && isDeposited)
            {
                    // set debt for the account
                    int prevDebt = accountToGiveLoan.GetDebt();
                    int totalDebt = loan.GetLoanAmount() + prevDebt;
                    accountToGiveLoan.SetDebt(totalDebt);
                    MessageBox.Show("Loan delivered successfully");
                   // update the account information
                   bool isUpdated = ObjectHandler.GetAccountDL().UpdateAccountInfo(accountToGiveLoan, AccountHolder);
                   if (isUpdated)
                {
                    MessageBox.Show("Debt Amount Applied successfully");
                }
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();  
            }
            else
            {
                MessageBox.Show("Loan not delivered");
            }
        }

        private void IpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpMontlySalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpMonthlyPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpIntialDeposite_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnreportBtn_Click(object sender, EventArgs e)
        {
            string accountHolder = IpName.Text;
            bool isUnreported = ObjectHandler.GetReportedAccountDL().UnreportAccount(accountHolder);
            if (isUnreported)
            {
                MessageBox.Show("Account unreported successfully");
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Account not unreported");
            }
        }

        private void SingleUser_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            isReeported();
        }
    }
}