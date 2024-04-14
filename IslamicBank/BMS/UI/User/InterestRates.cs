using BMS.BL;
using BMS.DL;
using BMS.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class InterestRates : Form
    {
        public InterestRates()
        {
            InitializeComponent();
            OnLoad();
        }
        private void OnLoad()
        {
            
            Account account = ObjectHandler.GetUserDL().GetCurrentUser().GetAccount();
            // display the interest rates and monthly fee according to the intial deposit
            int initialDeposit = account.GetIntialDeposit();
            int monthlyFee = initialDeposit / account.MonthlyFee();
            int interestRate = initialDeposit /  account.InterestRate();
            InterestRateLbl.Text = $"${interestRate}";
            BankFeeLbl.Text = $"${monthlyFee}";
            


        }
        private void InterestRates_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
