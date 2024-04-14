using BMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Util;
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
            dataGridView.Columns[1].Name = "DOB";
            dataGridView.Columns[2].Name = "Address";
            dataGridView.Columns[3].Name = "Phone";
            dataGridView.Columns[4].Name = "SSN";
            dataGridView.Columns[5].Name = "Income";
            dataGridView.Columns[6].Name = "Balance";
            dataGridView.Columns[7].Name = "Account";
            dataGridView.Columns[8].Name = "Account No";
            
            LoadData();
            LoadChartData();
        }
        private void LoadChartData()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
            //
            var amountSeries = chart1.Series["Amount"];
            var monthlySeries = chart1.Series["MonthlyFee"];
            // change the axes colors to white
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LineColor = Color.White;
            // chnage the grid lines to white
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            // change the color of the labels to white
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            // chnage the label font to dosis
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Dosis", 10);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Dosis", 10);
            // hide the grid lines
            //chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            //chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            if (accounts.Count > 0)
            {
                // Loop through transactions and add data points (existing code)
                foreach (Account acc in accounts)
                {
                    string name = acc.GetAccountHolder();
                    int amount = acc.GetIntialDeposit();
                    amountSeries.Points.AddXY(name, amount);
                    monthlySeries.Points.AddXY(name, acc.GetMonthlyIncome());
               }

            }    
        }
        private void LoadData()
        {
            List<Account> accounts = ObjectHandler.GetAccountDL().GetAccounts();
                  // load the data
            foreach (Account account in accounts)
            {
                string[] row = new string[] { account.GetAccountHolder(), account.GetDateOfBirth(), account.GetAddress(), account.GetPhone().ToString(),
                               account.GetSocialSecurityNumber(), account.GetMonthlyIncome().ToString(), account.GetIntialDeposit().ToString(), account.GetAccountType(), account.GetAccountNumber().ToString() };
                dataGridView.Rows.Add(row);
            }
        }
        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            SingleUser singleUser = new SingleUser();
            singleUser.IpName.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            singleUser.IpDOB.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            singleUser.IpAddress.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            singleUser.IpPhone.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            singleUser.IpSSN.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            singleUser.IpMontlySalary.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            singleUser.IpIntialDeposite.Text = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            singleUser.IpAccountNum.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            singleUser.balance.Text = $"Current Amount: {dataGridView.Rows[e.RowIndex].Cells[6].Value}";
            singleUser.Show();
        }
    }
}
