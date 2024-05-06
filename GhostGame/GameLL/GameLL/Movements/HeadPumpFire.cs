using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class HeadPumpFire : IMovement
    {
        private int speed;
        private System.Drawing.Point boundary;
        System.Drawing.Point location1 = Game.GetHeadPumpFireInstance();
        //private static HeadPumpFire Instance;
        public HeadPumpFire(int speed, System.Drawing.Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }
        public System.Drawing.Point move(System.Drawing.Point location)
        {
            List<GameObject> gameObjects = Game.gameObjectList;
            List<Obstacle> obstacle = Game.obstacles;
            // check if there is an obstacle in the way
            for (int i = 0; i < obstacle.Count; i++)
            {
                if (obstacle[i].pb.Bounds.IntersectsWith(new Rectangle(location1.X + speed, location1.Y, 40, 40)))
                {
                    for (int j = 0; j < gameObjects.Count; j++)
                    {
                        if (gameObjects[j].type == GameConfigurations.Type.HeadPumpFire)
                        {
                            // remove the bullet if it hits the obstacle
                            Game.RemoveObject(gameObjects[j]);
                            break;
                        }
                    }
                    return location1;
                }
            }

            // check boundary and move
            if (location1.X + speed + 40 <= boundary.X)
            {
                location1.X += speed;
            }
            else
            {
                // remove the bullet if it hits the boundary
                for (int i = 0; i < gameObjects.Count; i++)
                {
                    if (gameObjects[i].type == GameConfigurations.Type.HeadPumpFire)
                    {
                        Game.RemoveObject(gameObjects[i]);
                        break;
                    }
                }
            }
            return location1;

        }
    }
}