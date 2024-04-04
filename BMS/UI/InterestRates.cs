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
            
            Account account =MUserDL.GetCurrentUser().GetAccount();
            IpBankFee.Text = account.MonthlyFee().ToString();
            IpInterestRate.Text = account.InterestRate().ToString();

        }
        private void InterestRates_Load(object sender, EventArgs e)
        {

        }
    }
}
