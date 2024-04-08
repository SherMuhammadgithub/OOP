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
            AccountzDet accountzDet = new AccountzDet();
            accountzDet.Show();

        }

        private void AddAccount_Click(object sender, EventArgs e)
        {



            MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();

            Account account = currentUser.GetAccount();
            if (account != null)
            {
                MessageBox.Show("Account already exists");
                return;
            }
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            MoneyActions moneyTrans = new MoneyActions();
            moneyTrans.Show();
        }

        private void BankFeePgBtn_Click(object sender, EventArgs e)
        {
            InterestRates interestRates = new InterestRates();
            interestRates.Show();
        }

        private void GoToHistoryPg_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

    }
}
