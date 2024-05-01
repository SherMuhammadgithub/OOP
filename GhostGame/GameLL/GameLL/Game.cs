using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLL
{
    public class Game
    {
        int gravity = 10;
        List<GameObject> gameObjectList;
        Form container;
        public Game(int gravity, Form container)
        {
            this.gravity
            =
            gravity;
            gameObjectList = new List<GameObject>(); this.container = container;
        }
        public void AddGameObject(GameObject gameObject)
        {
            gameObjectList.Add(gameObject);
            container.Controls.Add(gameObject.pb);
        }
        public void Update()
        {
            foreach (GameObject gameObject in gameObjectList)
            {
                gameObject.Update();
            }
        }
    }
}
