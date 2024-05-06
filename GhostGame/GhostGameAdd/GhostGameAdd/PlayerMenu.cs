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
using System.Xml;

namespace GhostGameAdd
{
    public partial class PlayerMenu : Form
    {
        SoundPlayer SoundPlayer = new SoundPlayer(@"C:\Users\dell\Desktop\chooseFighter.wav");

        private int currentImageIndex = 0;
        private Image[] playerImages = { Properties.Resources.chary01_removebg_preview, Properties.Resources.char02_removebg_preview, Properties.Resources.char03 };

        private string[] playerNames = { "Robbin", "Vampire", "Smart Boy" };

        public PlayerMenu()
        {
            InitializeComponent();
            SoundPlayer.Play();
            nameLabel.Text = playerNames[0];
            pictureBox1.Image = playerImages[0];
            Form1.playerImage = playerImages[0];

        }









        private void M_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                // Increment the index to show the next image
                currentImageIndex = (currentImageIndex + 1) % playerImages.Length;
                pictureBox1.Image = playerImages[currentImageIndex];
                Form1.playerImage = playerImages[currentImageIndex];
                UpdatePlayerNameLabel();
            }
            else if (e.KeyCode == Keys.Left)
            {
                // Decrement the index to show the previous image
                currentImageIndex = (currentImageIndex - 1 + playerImages.Length) % playerImages.Length;
                pictureBox1.Image = playerImages[currentImageIndex];
                Form1.playerImage = playerImages[currentImageIndex];
                UpdatePlayerNameLabel();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void UpdatePlayerNameLabel()
        {
            // Update the label text with the current player's name
            nameLabel.Text = playerNames[currentImageIndex];
        }

        private void StartBtn_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }

}
