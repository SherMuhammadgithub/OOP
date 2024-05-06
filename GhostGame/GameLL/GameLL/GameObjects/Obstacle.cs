using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLL
{
    public class Obstacle
    {
        public PictureBox pb;
        public GameConfigurations.ObstacleType type;

        public Obstacle(int top, int left, Image obstacleImg, GameConfigurations.ObstacleType type)
        {
            this.pb = new PictureBox();
            this.pb.Image = obstacleImg;
            this.pb.Width = 340;
            this.pb.Height = 200;
            this.pb.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb.BorderStyle = BorderStyle.None;
            this.pb.BackColor = Color.Transparent;
            this.pb.Left = left;
            this.pb.Top = top;
            this.type = type;
        }

    }
}
