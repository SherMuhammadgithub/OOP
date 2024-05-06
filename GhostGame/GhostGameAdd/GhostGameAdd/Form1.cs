using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using GameLL;
using GhostGameAdd.Properties;

namespace GhostGameAdd
{
    public partial class Form1 : Form
    {
        // adding sound player
        public static SoundPlayer SoundPlayer = new SoundPlayer(@"C:\Users\dell\Desktop\gameSong.wav");
        Game game;
        System.Drawing.Point boundary;
        public static Image playerImage; // player image
        public Form1()
        {
            InitializeComponent();
            // playing background music
            SoundPlayer.PlayLooping();

            // setting game loop to start the game
            gameLoop.Enabled = true;

            // setting form size
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            boundary = new System.Drawing.Point(this.Width - 200, this.Height - 200);

            // setting player health
            PlayerHealth.Value = 100;
            GhostHealth.Value = 100;
            playerScore.Text = "Score: 0";

            // setting current player img
            palyerImgCell.Image = playerImage;
            LoaForm();
        }
        private void LoaForm()
        {

            game = Game.GetInstance(this);
            Game.SetForm(this);

            // adding Objects

            GameObject obj1 = new GameObject(playerImage
                , 300, 300, new KeyboardHandler(10, boundary, GameConfigurations.Direction.Left, Resources.playerFire), GameConfigurations.Type.Player);


            GameObject obj2 = new GameObject(Resources.enemy1, 100, 10, new VerticalMovement(10, boundary, GameConfigurations.Direction.Down, Resources.enemyFires), GameConfigurations.Type.VerticalEnemy);


            GameObject obj3 = new GameObject(Resources.enemy2, 100, 20, new SquareMovement(10, boundary, GameConfigurations.Direction.Up), GameConfigurations.Type.HorizontalEnemy);

            Game.AddGameObject(obj1);
            Game.AddGameObject(obj2);
            Game.AddGameObject(obj3);


            // adding obstacles

            int obstacleX = (this.Width - 340) / 2;
            int obstacleY = (this.Height - 200) / 2;

            Obstacle obs1 = new Obstacle(obstacleY, obstacleX, Resources.wall, GameConfigurations.ObstacleType.wall);

            Game.AddObstacle(obs1);


            // adding collision detection


            CollionDetection c1 = new CollionDetection(GameConfigurations.Type.HorizontalEnemy, GameConfigurations.Type.Bullet, GameConfigurations.Action.IncreasePlayerPoints);


            CollionDetection c2 = new CollionDetection(GameConfigurations.Type.Player, GameConfigurations.Type.HeadPumpFire, GameConfigurations.Action.DecreasePlayerPoints);


            CollionDetection c3 = new CollionDetection(GameConfigurations.Type.VerticalEnemy, GameConfigurations.Type.Bullet, GameConfigurations.Action.IncreasePlayerPoints);


            CollionDetection c4 = new CollionDetection(GameConfigurations.Type.HorizontalEnemy, GameConfigurations.Type.Player, GameConfigurations.Action.DecreasePlayerPoints);


            Game.AddCollisionDetection(c1);
            Game.AddCollisionDetection(c2);
            Game.AddCollisionDetection(c3);
            Game.AddCollisionDetection(c4);
        }



        private void Game_Loop(object sender, EventArgs e)
        {
            game.Update();


            // updating form values
            PlayerHealth.Value = Game.playerHealth;
            playerScore.Text = $"Score {Game.score}";
            GhostHealth.Value = Game.EnemyHealth;
            string score = playerScore.Text.ToString();


            if (Game.isGameOver)
            {

                // get out from the game loop
                gameLoop.Enabled = false;
                Game.GameOver();
                // showing main form
                MessageBox.Show(score.ToString());
                ScoreBoard scoreBoard = new ScoreBoard(score);
                scoreBoard.Show();
                this.Close();
            }

        }
    }
}
