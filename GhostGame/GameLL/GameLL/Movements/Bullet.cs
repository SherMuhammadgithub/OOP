using System.Collections.Generic;
using System.Drawing;

namespace GameLL
{
    public class Bullet : IMovement
    {
        System.Drawing.Point location1 = Game.GetPlayerInstance(); // get the location of the player
        private int speed;
        private System.Drawing.Point boundary;

        public Bullet(int speed, System.Drawing.Point boundary)
        {
            this.speed = speed;
            this.boundary = boundary;
        }

        public System.Drawing.Point move(System.Drawing.Point location)
        {
            List<GameObject> gameObjects = Game.gameObjectList;
            CheckObstacles(location1);
            // check boundary and move
            if (location1.X - speed > 0)
            {
                location1.X -= speed;
            }
            else
            {
                // remove the bullet if it hits the boundary
                for (int i = 0; i < gameObjects.Count; i++)
                {
                    if (gameObjects[i].type == GameConfigurations.Type.Bullet)
                    {
                        Game.RemoveObject(gameObjects[i]);
                    }
                }
            }
            return location1;
        }

        private void CheckObstacles(System.Drawing.Point location)
        {
            List<GameObject> gameObjects = Game.gameObjectList;
            List<Obstacle> obstacles = Game.obstacles;

            // check if there is an obstacle in the way
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].pb.Bounds.IntersectsWith(new Rectangle(location1.X - speed, location1.Y, 10, 10)))
                {
                    for (int j = 0; j < gameObjects.Count; j++)
                    {
                        if (gameObjects[j].type == GameConfigurations.Type.Bullet)
                        {
                            // remove the bullet if it hits the obstacle
                            Game.RemoveObject(gameObjects[j]);
                            break;
                        }
                    }
                }
            }
        }

    }
}
