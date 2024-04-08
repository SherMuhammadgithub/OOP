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
    public partial class ViewUsers : Form
    {
        public ViewUsers()
        {
            InitializeComponent();
            // create columns for the grid

            dataGridView.ColumnCount = 9;
            dataGridView.Columns[0].Name = "Account Holder";
            dataGridView.Columns[1].Name = "Date of Birth";
            dataGridView.Columns[2].Name = "Address";
            dataGridView.Columns[3].Name = "Phone";
            dataGridView.Columns[4].Name = "Social Security Number";
            dataGridView.Columns[5].Name = "Monthly Income";
            dataGridView.Columns[6].Name = "Initial Deposit";
            dataGridView.Columns[7].Name = "Account Type";
            dataGridView.Columns[8].Name = "Account Number";
            
            LoadData();

        }
        private void LoadData()
        {
           List<Account> accounts =  ObjectHandler.GetAccountDL().GetAccounts();
            foreach (Account account in accounts)
            {
                string[] row = new string[] { account.GetAccountHolder(), account.GetDateOfBirth(), account.GetAddress(), account.GetPhone().ToString(), account.GetSocialSecurityNumber(), account.GetMonthlyIncome().ToString(), account.GetIntialDeposit().ToString(), account.GetAccountType(), account.GetAccountNumber().ToString() };
                dataGridView.Rows.Add(row);
            }
        }
        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SingleUser singleUser = new SingleUser();
            singleUser.IpName.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            singleUser.IpDOB.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            singleUser.IpAddress.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            singleUser.IpPhone.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            singleUser.IpSSN.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            singleUser.IpMontlySalary.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            singleUser.IpIntialDeposite.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            singleUser.IpAccountNum.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            singleUser.Show();

        }
    }
}
