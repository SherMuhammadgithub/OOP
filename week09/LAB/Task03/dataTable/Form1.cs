using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataTable
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            
        }
      
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(AgeTb.Text == "" || NameTb.Text == "" || IdTB.Text == "")
            {
                MessageBox.Show("Please enter the values");
            }
            if(!int.TryParse(IdTB.Text, out int id))
            {
                MessageBox.Show( "Please enter a valid ID");
                return;
            }
            
           string name = NameTb.Text;

            if (!int.TryParse(AgeTb.Text, out int age))
            {
                MessageBox.Show("Please enter a valid Age");
                return;
            }
            dataTable.Rows.Add(id, name, age);

            dataGridView.DataSource = dataTable;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataGridView.DataSource = dataTable;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                MessageBox.Show ("Please select a row to delete");  
                return;
            }
            dataGridView.Rows.RemoveAt(selectedRow);    
        }
        int selectedRow;
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[selectedRow];
            IdTB.Text = row.Cells[0].Value.ToString();
            NameTb.Text = row.Cells[1].Value.ToString();
            AgeTb.Text = row.Cells[2].Value.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            DataGridViewRow row = dataGridView.Rows[selectedRow];
            row.Cells[0].Value = IdTB.Text;
            row.Cells[1].Value = NameTb.Text;
            row.Cells[2].Value = AgeTb.Text;
        }
    }
}
