using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuscleMayhemPenguinBrawl
{
    public partial class GameScreen : UserControl
    {

        Random randGen = new Random();

        SolidBrush redBrush = new SolidBrush(Color.Red);

        List<Penguins> enemies = new List<Penguins>();
        Player hero;

        public static int width, height;

        bool aKeyDown, dKeyDown, wKeyDown, sKeyDown;

        Penguins chasePenguin;

     //   System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

       

        public void InitializeGame()
        {
            hero = new Player(100, 100);
            height = this.Height;
            width = this.Width;

            chasePenguin = new Penguins(this.Width / 2, this.Height / 2, -8, 8);

            for (int i = 0; i < 3; i++)
            {
                CreateEnPen();
            }

            hero = new Player(100, 100);

        //    backMedia.Open(new Uri(Application.StartupPath + "/Resources/gaga.mp3"));
        //    backMedia.Play();

        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = true;
                    break;
                case Keys.D:
                    dKeyDown = true;
                    break;
                case Keys.W:
                    wKeyDown = true;
                    break;
                case Keys.S:
                    sKeyDown = true;
                    break;
            }
        }


        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aKeyDown = false;
                    break;
                case Keys.D:
                    dKeyDown = false;
                    break;
                case Keys.W:
                    wKeyDown = false;
                    break;
                case Keys.S:
                    sKeyDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move the chase ball
            chasePenguin.Move();

            //move all the enemy balls
            foreach (Penguins enemy in enemies)
            {
                enemy.Move();
            }

            //move the player
            if (wKeyDown)
            {
                hero.Move("up");
            }

            if (sKeyDown)
            {
                hero.Move("down");
            }

            if (dKeyDown)
            {
                hero.Move("right");
            }

            if (aKeyDown)
            {
                hero.Move("left");
            }

            //check for collision between player and chaseball
            if(hero.Collision(chasePenguin))
            {
                Form1.coinPoints++;
                coinLabel.Text = $"{Form1.coinPoints}";
            }

            //check for collision between player and enemies
            foreach(Penguins enemy in enemies)
            {
                if (hero.Collision(enemy))
                {
                    Form1.coinPoints++;
                    coinLabel.Text = $"{Form1.coinPoints}";

                    enemies.Remove(enemy); 
                    break;
                }
            }

            if (enemies.Count == 0)
            {
                gameTimer.Stop();
                Form1.ChangeScreen(this, new ArmArea());
            }
            Refresh();


        }
        private void CreateEnPen()
        {
            int x = randGen.Next(10, width - 20);
            int y = randGen.Next(10, height - 20);
            int xSpeed = randGen.Next(5, 10);
            int ySpeed = randGen.Next(5, 10);

            Penguins newPenguin = new Penguins(x, y, xSpeed, ySpeed);
            enemies.Add(newPenguin);
        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.dude, hero.x, hero.y, 50, 50);

            foreach (Penguins enemy in enemies)
            {
                e.Graphics.DrawImage(Properties.Resources.bad, enemy.x, enemy.y, 50, 50);
            }

        }
    }
         
}
