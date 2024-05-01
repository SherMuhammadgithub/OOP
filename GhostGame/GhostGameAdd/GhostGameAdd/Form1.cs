using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLL;
using GhostGameAdd.Properties;

namespace GhostGameAdd
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(10, this);
            Point boundary = new Point(this.Width, this.Height);
            GameObject gameObject2 = new GameObject(Resources.Wraith_03_Moving_Forward_009, 40, 10, new VerticalPatrol(10, boundary, GameControl.Direction.Down));
            GameObject gameObject3 = new GameObject(Resources.Wraith_03_Moving_Forward_009, 100, 20, new ZigZagPatrol(10, boundary, GameControl.Direction.Up));
            game.AddGameObject(gameObject2);
            game.AddGameObject(gameObject3);
        }

        private void Game_Loop(object sender, EventArgs e)
        {
            game.Update();
        }
    }
}
