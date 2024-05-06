using System.Drawing;
using System.Windows.Forms;

namespace GameLL
{
    public class GameObject
    {
        public PictureBox pb;
        public IMovement movement;
        public GameConfigurations.Type type;
        public GameObject(Image img, int left, int top, IMovement movement, GameConfigurations.Type type)
        {
            pb = new PictureBox
            {
                Image = img,
                Width = 160,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent,
                Left = left,
                Top = top
            };
            this.movement = movement;
            this.type = type;
        }
        public void Update()
        {
            if (pb != null && movement != null)
            {
                this.pb.Location = movement.move(pb.Location);
            }
        }
    }
}
