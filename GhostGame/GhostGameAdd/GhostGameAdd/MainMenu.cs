using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostGameAdd
{
    public partial class MainMenu : Form
    {
        // adding sound player
        public static SoundPlayer SoundPlayer = new SoundPlayer(@"C:\Users\dell\Desktop\gameSong.wav");
        public MainMenu()
        {
            InitializeComponent();
            SoundPlayer.Play();
        }

        private void s_player_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerMenu form1 = new PlayerMenu();
            form1.ShowDialog();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer.Stop();
            this.Close();
        }
        public void RestartGame()
        {
            // Show the main menu form
            this.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
