using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorForm
{
    public partial class Form1 : Form
    {
        public static Color[] colors = { Color.Red, Color.Green, Color.Blue };
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{i}");
            if(i == colors.Length || i == -1)
            {
                i = 0;
            }
            TB1.BackColor = colors[i];
            if(i < colors.Length)
            i++;
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
                  //MessageBox.Show($"{i}");
            if(i == -1  || i == colors.Length)
            {
                i = colors.Length - 1;
            }
            TB1.BackColor = colors[i];
            if(i >= 0)
            i--;
        }
    }
}
