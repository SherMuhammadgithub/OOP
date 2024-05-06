using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLL
{
    public class Game
    {
        private static Game instance;
        public static List<GameObject> gameObjectList;
        public static List<Obstacle> obstacles;
        public static List<CollionDetection> collisions;
        public static Form container;
        public static int playerHealth = 100;
        public static int EnemyHealth = 100;
        public static int score = 0;
        public static bool isGameOver = false;
        private Game(Form container)
        {
            gameObjectList = new List<GameObject>();
            obstacles = new List<Obstacle>();
            collisions = new List<CollionDetection>();
            Game.container = container;
        }
        public static Game GetInstance(Form container)
        {
            if (instance == null)
            {
                instance = new Game(container);
            }
            return instance;
        }
        // if the game is over clear all the objects
        public static void GameOver()
        {
            playerHealth = 100;
            EnemyHealth = 100;
            score = 0;
            isGameOver = false;
            container.Controls.Clear();
            gameObjectList.Clear();
            obstacles.Clear();
            collisions.Clear();
        }
        public static void SetForm(Form container) // setting the instance for avoiding prev state
        {
            Game.container = container;
        }
        public void Update()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                GameObject obj = gameObjectList[i];
                obj.Update();
                // cheking for collion between player and headpumpfire
                if (obj.type == GameConfigurations.Type.Player)
                {
                    for (int j = 0; j < gameObjectList.Count; j++)
                    {
                        if (i != j) // avoid self collision
                        {
                            GameObject obj2 = gameObjectList[j];
                            if (obj2.type == GameConfigurations.Type.HeadPumpFire)
                            {
                                foreach (CollionDetection collision in collisions)
                                {
                                    if (collision.IsCollide(obj.pb, obj2.pb))
                                    {
                                        RemoveObject(obj2);
                                        collision.Collide(obj2.type);
                                        // and stop its movement
                                        obj2.movement = null;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                // cheking for collion between VerticalEnemy and bullet
                if (obj.type == GameConfigurations.Type.VerticalEnemy)
                {
                    for (int j = 0; j < gameObjectList.Count; j++)
                    {
                        if (i != j) // avoid self collision
                        {
                            GameObject obj2 = gameObjectList[j];
                            if (obj2.type == GameConfigurations.Type.Bullet)
                            {
                                foreach (CollionDetection collision in collisions)
                                {
                                    if (collision.IsCollide(obj.pb, obj2.pb))
                                    {
                                        collision.Collide(obj2.type);
                                        RemoveObject(obj2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }


                // checking for collion between HorizontalEnemy and bullet
                if (obj.type == GameConfigurations.Type.HorizontalEnemy)
                {
                    for (int j = 0; j < gameObjectList.Count; j++)
                    {
                        if (i != j) // avoid self collision
                        {
                            GameObject obj2 = gameObjectList[j];
                            if (obj2.type == GameConfigurations.Type.Bullet)
                            {
                                foreach (CollionDetection collision in collisions)
                                {
                                    if (collision.IsCollide(obj.pb, obj2.pb))
                                    {
                                        collision.Collide(obj2.type);
                                        RemoveObject(obj2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                // checking for collion between player and HorizontalEnemy
                if (obj.type == GameConfigurations.Type.Player)
                {
                    for (int j = 0; j < gameObjectList.Count; j++)
                    {
                        if (i != j) // avoid self collision
                        {
                            GameObject obj2 = gameObjectList[j];
                            if (obj2.type == GameConfigurations.Type.HorizontalEnemy)
                            {
                                foreach (CollionDetection collision in collisions)
                                {
                                    if (collision.IsCollide(obj.pb, obj2.pb))
                                    {
                                        collision.Collide(obj2.type);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }


        // adding and removing game objects
        public static void AddGameObject(GameObject gameObject)
        {
            gameObjectList.Add(gameObject);
            container.Controls.Add(gameObject.pb);
        }
        public static void RemoveObject(GameObject gameObject)
        {
            gameObjectList.Remove(gameObject);
            container.Controls.Remove(gameObject.pb);
        }
        // adding and removing obstacles
        public static void RemoveObstacle(Obstacle obstacle)
        {
            obstacles.Remove(obstacle);
            container.Controls.Remove(obstacle.pb);
        }
        public static void AddObstacle(Obstacle obstacle)
        {
            if (obstacle != null && obstacle.pb != null)
            {
                obstacles.Add(obstacle);
                container.Controls.Add(obstacle.pb);
            }
        }

        // adding and removing collision detection
        public static void AddCollisionDetection(CollionDetection collision)
        {
            collisions.Add(collision);
        }
        public static void RemoveCollisionDetection(CollionDetection collision)
        {
            collisions.Remove(collision);
        }
        // getting player location
        public static System.Drawing.Point GetPlayerInstance()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i].type == GameConfigurations.Type.Player)
                {
                    return new System.Drawing.Point(gameObjectList[i].pb.Left, gameObjectList[i].pb.Top);
                }
            }
            return new System.Drawing.Point(0, 0);
        }
        // getting enemy fire location
        public static System.Drawing.Point GetHeadPumpFireInstance()
        {
            for (int i = 0; i < gameObjectList.Count; i++)
            {
                if (gameObjectList[i].type == GameConfigurations.Type.VerticalEnemy)
                {
                    return new System.Drawing.Point(gameObjectList[i].pb.Left, gameObjectList[i].pb.Top);
                }
            }
            return new System.Drawing.Point(0, 0);
        }



    }
}
