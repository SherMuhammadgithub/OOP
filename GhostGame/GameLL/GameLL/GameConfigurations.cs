using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLL
{
    public class GameConfigurations
    {
        // create a enum functon and retrun enmu
        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
        public enum Type
        {
            HorizontalEnemy,
            VerticalEnemy,
            Player,
            Bullet,
            HeadPumpFire,
            FixedFire,
        }
        public enum ObstacleType
        {
            wall,
        }
        public enum Action
        {
            IncreasePlayerPoints,
            DecreasePlayerPoints,
            DecreaseEnemyHealth,
        }
    }
}
