using EZInput;
using GameLL.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GameLL
{
    public class KeyboardHandler : IMovement
    {
        private int speed;
        private System.Drawing.Point boundary;
        private int offset = 10;
        GameConfigurations.Direction direction;
        public KeyboardHandler(int speed, System.Drawing.Point boundary, GameConfigurations.Direction direction, System.Drawing.Image bulletImage)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            SetImageForResources("bullet_img", bulletImage, "resources");

        }
        private void SetImageForResources(string resourceName, System.Drawing.Image image, string name)
        {
            using (ResourceWriter resourceWriter = new ResourceWriter($"GameLL.Properties.Resources.{name}"))
            {
                // Add or update image in resources
                resourceWriter.AddResource(resourceName, image);
            }
        }
        private System.Drawing.Image GetImageFromResources(string resourceName, string name)
        {
            using (ResourceReader resourceReader = new ResourceReader($"GameLL.Properties.Resources.{name}"))
            {
                foreach (DictionaryEntry entry in resourceReader)
                {
                    if (entry.Key.ToString() == resourceName)
                    {
                        return (System.Drawing.Image)entry.Value;
                    }
                }
            }
            return null;
        }
        public System.Drawing.Point move(System.Drawing.Point location)
        {
            List<Obstacle> obstacles = Game.obstacles;
            bool canMoveUp = true;
            bool canMoveDown = true;
            bool canMoveLeft = true;
            bool canMoveRight = true;
            System.Drawing.Point point = Game.GetPlayerInstance(); // Get player location

            foreach (Obstacle obs in obstacles)
            {
                // player pictureBox width is 140 and height is 100
                if (obs.pb.Bounds.IntersectsWith(new Rectangle(point.X, point.Y - offset, 160, 120)))
                {
                    canMoveUp = false;
                }
                if (obs.pb.Bounds.IntersectsWith(new Rectangle(point.X, point.Y + offset, 160, 120)))
                {
                    canMoveDown = false;
                }
                if (obs.pb.Bounds.IntersectsWith(new Rectangle(point.X - offset, point.Y, 160, 120)))
                {
                    canMoveLeft = false;
                }
                if (obs.pb.Bounds.IntersectsWith(new Rectangle(point.X + offset, point.Y, 160, 120)))
                {
                    canMoveRight = false;
                }
            }

            // Move the player based on keyboard input and movement permissions
            if (Keyboard.IsKeyPressed(Key.UpArrow) && canMoveUp && location.Y - offset >= 0)
            {
                location.Y -= speed;
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow) && canMoveDown && location.Y + offset + 10 <= boundary.Y)
            {
                location.Y += speed;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow) && canMoveLeft && location.X - offset >= 0)
            {
                location.X -= speed;
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow) && canMoveRight && location.X + offset + 10 <= boundary.X)
            {
                location.X += speed;
            }
            // Fire bullet when space key is pressed
            if (Keyboard.IsKeyPressed(Key.Space))
            {



                Bullet bullet = new Bullet(30, boundary);
                System.Drawing.Image img = GetImageFromResources("bullet_img", "resources");
                GameObject gameObject = new GameObject(img, location.X, location.Y, bullet, GameConfigurations.Type.Bullet);
                Game.AddGameObject(gameObject);
                bullet.move(location);
            }

            return location;
        }



    }
}
