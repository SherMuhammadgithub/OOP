using BMS.BL;
using DatabaseProject;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void AccountPgBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AccountForm accountForm = new AccountForm();
            accountForm.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void HistoryPgBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
            Account currentAccount = currentUser.GetAccount();
            if (currentAccount != null)
            {
                AddBtn.Enabled = false;
                AddBtn.BackColor = Color.White;
            }
            else
            {
                AddBtn.Enabled = true;
            }
        }
    }
}
