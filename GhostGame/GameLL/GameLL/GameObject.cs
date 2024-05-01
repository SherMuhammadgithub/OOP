using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLL
{
    public class GameObject
    {
        public PictureBox pb;
        IMovement movement;
        public GameObject(Image img, int left, int top, IMovement movement)
        {
            pb = new PictureBox();
            pb.Image = img;
            pb.Width = 220;
            pb.Height = 200;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            // remove image background color 
            pb.BackgroundImage = null;
            pb.BackColor = Color.Transparent;
            pb.Left = left;
            pb.Top = top;
            this.movement = movement;
        }
        public void Update()
        {
            // check the if the pb not colides with any other object
            this.pb.Location = movement.move(pb.Location);
        }
    }
}
