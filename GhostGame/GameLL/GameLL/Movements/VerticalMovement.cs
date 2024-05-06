using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class VerticalMovement : IMovement
    {
        private int speed;
        private Point boundary;
        GameConfigurations.Direction direction;
        private int offset = 10;
        private Image fireImage;
        public VerticalMovement(int speed, Point boundary, GameConfigurations.Direction direction, Image fireImage)
        {
            this.speed = speed;
            this.boundary = boundary;
            this.direction = direction;
            this.fireImage = fireImage;
            using (ResourceWriter resourceWriter = new ResourceWriter("GameLL.Properties.Resources.resources1"))
            {
                // Add or update image in resources
                resourceWriter.AddResource("fire_image", fireImage);
            }
        }
        private System.Drawing.Image GetImageFromResources(string resourceName)
        {
            using (ResourceReader resourceReader = new ResourceReader("GameLL.Properties.Resources.resources1"))
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
        public Point move(Point location)
        {
            // i want if there is any object in the way it should change the direction
            if ((location.Y + offset) > boundary.Y)
            {
                direction = GameConfigurations.Direction.Up;
            }
            if ((location.Y - offset - 100) <= 0)
            {
                direction = GameConfigurations.Direction.Down;
            }
            if (direction == GameConfigurations.Direction.Up)
            {
                location.Y -= speed;
            }
            else
            {
                location.Y += speed;
            }
            if (location.Y % 200 == 0)
            {
                HeadPumpFire headFire = new HeadPumpFire(20, boundary);
                System.Drawing.Image imgss = GetImageFromResources("fire_image");
                GameObject Bullet = new GameObject(imgss, 0, 0, headFire, GameConfigurations.Type.HeadPumpFire);
                Game.AddGameObject(Bullet);
                headFire.move(location);
            }
            return location;
        }
    }
}
