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
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void LoginPage_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();

        }

        private void SignUpPage_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void FormDetPage_Click(object sender, EventArgs e)
        {
            AccountzDet accountzDet = new AccountzDet();
            accountzDet.Show();
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.Show();
        }

        private void adminPg_Click(object sender, EventArgs e)
        {
            AdminPannel adminPannel = new AdminPannel();
            adminPannel.Show();
        }
    }
}
