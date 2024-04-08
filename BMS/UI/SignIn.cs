using BMS.BL;
using BMS.DL;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

        }
        private void SignInBtn_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(InputName.Text, InputPass.Text);

            if (ObjectHandler.GetUserDL().SignIn(user))
            {
                MessageBox.Show("User signed in successfully");
                ObjectHandler.GetUserDL().StoreCurrentUser(user); 
           
                // setting current customer Account
                MUser currentUser = ObjectHandler.GetUserDL().GetCurrentUser();
                Account account = ObjectHandler.GetAccountDL().isAccountExists(currentUser.GetUsername());
                if (account != null)
                {
                    MessageBox.Show("Account found");
                    currentUser.SetCurrentAccount(account);
                    Loan loan = ObjectHandler.GetLoanDL().isLoanExists(account.GetAccountHolder());
                    if (loan != null)
                    {
                        account.SetLoan(loan);
                    }
                    else
                    {
                        account.SetLoan(null);
                    }
                    // setting transactions for the account
                    account.SetTransactions(ObjectHandler.GetTransactionDL().GetTransactionsForSpecificAccount(account.GetAccountHolder()));
                }
                // if account not found
                else
                {
                    MessageBox.Show("Account not found");
                    currentUser.SetCurrentAccount(null); 
                }
                this.Hide();
                Menu menu = new Menu();
                menu.Show();    
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
