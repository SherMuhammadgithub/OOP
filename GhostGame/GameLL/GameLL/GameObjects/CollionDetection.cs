using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLL
{
    public class CollionDetection
    {
        public GameConfigurations.Type gameObjectType;
        public GameConfigurations.Type obstacleType;
        public GameConfigurations.Action action;

        public CollionDetection(GameConfigurations.Type gameObjectType, GameConfigurations.Type obstacleType, GameConfigurations.Action action)
        {
            this.gameObjectType = gameObjectType;
            this.obstacleType = obstacleType;
            this.action = action;
        }

        public bool IsCollide(PictureBox object1, PictureBox object2)
        {
            bool isCollide = false;
            if (object1.Bounds.IntersectsWith(object2.Bounds))
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources.explosion;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Top = object1.Top - 100;
                pictureBox.Left = object1.Left + 20;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.BackColor = System.Drawing.Color.Transparent;

                // Add explosion image to the form
                Game.container.Controls.Add(pictureBox);

                // Set up timer to remove the image after 3 seconds
                Timer timer = new Timer();
                timer.Interval = 1000; // 3 seconds
                timer.Tick += (s, e) =>
                {
                    Game.container.Controls.Remove(pictureBox);
                    timer.Stop(); // Stop the timer after removing the image
                };

                timer.Start(); // Start the timer

                isCollide = true;
            }
            return isCollide;
        }

        public void Collide(GameConfigurations.Type action)
        {
            if (action == GameConfigurations.Type.Bullet)
            {
                if (Game.EnemyHealth - 1  > 0)
                {
                    Game.score += 10;
                    Game.EnemyHealth -= 1;
                    // check for game over
                    if (Game.EnemyHealth == 0)
                    {
                        Game.isGameOver = true; 
                    }
                }
                else
                {
                    Game.EnemyHealth = 0;
                    Game.isGameOver = true;
                }
            }
            else if (action == GameConfigurations.Type.HeadPumpFire)
            {
                if (Game.playerHealth - 1 > 0)
                {
                    Game.playerHealth -= 1;
                    // check for game over
                    if (Game.playerHealth == 0)
                    {
                        Game.isGameOver = true;
                    }
                }
                else
                {
                    Game.isGameOver = true;

                }
            }
            else if (action == GameConfigurations.Type.HorizontalEnemy)
            {
                if (Game.playerHealth - 1 > 0)
                {
                    Game.playerHealth -= 1;
                    // check for game over
                    if (Game.playerHealth == 0)
                    {
                        Game.isGameOver = true;
                    }
                }
                else
                {
                    Game.isGameOver = true;

                }

            }
        }
    }
}
