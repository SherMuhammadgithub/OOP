using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostGameAdd
{
    public partial class ScoreBoard : Form
    {
        private string score;
        public ScoreBoard(string score)
        {
            InitializeComponent();
            MainMenu.SoundPlayer.Stop();
            this.score = score;
            score_lbl.Text = "Your Score: " + score;
            score_lbl.ForeColor = Color.Black;
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }
    }
}
