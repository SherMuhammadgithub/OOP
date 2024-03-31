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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void FormDetPage_Click(object sender, EventArgs e)
        {
            AccountForm accountForm = new AccountForm();
            accountForm.Show();

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AccountzDet accountzDet = new AccountzDet();
            accountzDet.Show();
        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            MoneyActions moneyTrans = new MoneyActions();
            moneyTrans.Show();
        }
    }
}
