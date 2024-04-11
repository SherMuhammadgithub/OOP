using BMS.BL;
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
    public partial class VipUsersForm : Form
    {
        public VipUsersForm()
        {
            InitializeComponent();
            // crtaeting columns for data grid view

            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Account Holder";
            dataGridView.Columns[1].Name = "Social Security Number";
            dataGridView.Columns[2].Name = "Monthly Income";
            dataGridView.Columns[3].Name = "Initial Deposit";
            dataGridView.Columns[4].Name = "Account Type";
            dataGridView.Columns[5].Name = "Account Number";
            LoadData();

        }
        private void LoadData()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
            bool isVipUserFound = false;
            foreach (Account account in accounts)
            {
                if (account.GetIntialDeposit() > 50000) // checking if the account is a VIP account
                {
                    string[] row = new string[] { account.GetAccountHolder(), account.GetSocialSecurityNumber(), account.GetMonthlyIncome().ToString(), account.GetIntialDeposit().ToString(), account.GetAccountType(), account.GetAccountNumber().ToString() };
                    dataGridView.Rows.Add(row);
                    isVipUserFound = true;
                    noVipUsersLbl.Visible = false;
                    dataGridView.Visible = true;
                }
            }
            if(!isVipUserFound)
            {
                noVipUsersLbl.Visible = true;
                dataGridView.Visible = false;
            }
        }

        private void noVipUsersLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
