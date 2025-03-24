using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace animatedgame
{
    public partial class GameScreen : UserControl
    {
        int stopwatch = 500;

        public static int screenWidth;
        public static int screenHeight;
        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
        public int gameTimer = 0;
        guy hero = new guy();
        public int rand;
        Random randGen = new Random();
        Stopwatch myWatch = new Stopwatch();

        Pellets square;
        List<Pellets> pellet = new List<Pellets>();


        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        SolidBrush redBrush = new SolidBrush(Color.Red);
        public GameScreen()
        {
            InitializeComponent();
            screenWidth = this.Width;
            screenHeight = this.Height;
            InitializeGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            stopwatch--;
            
            if (stopwatch == 0)
            {
                timer.Stop();
            }

            //Moving Hero
            if (upArrowDown == true)
            {
                hero.Move("up");
            }

            if (leftArrowDown == true)
            {
                hero.Move("left");
            }

            if (downArrowDown == true)
            {
                hero.Move("down");
            }

            if (rightArrowDown == true)
            {
                hero.Move("right");
            }

            //Spawning balls
            rand = randGen.Next(1, 35);
            if (rand == 11)
            {
                int x = randGen.Next(20, this.Width - 20);
                int y = randGen.Next(20, this.Height - 20);
                Pellets square = new Pellets(x, y);
                pellet.Add(square);

            }

            //Pellet Collision
            foreach (Pellets p in pellet)
            {
                if (hero.Collision(p))
                {
                    pellet.Remove(p);
                    hero.width += p.size;
                    hero.height += p.size;
                    break;
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            outputLabel.Text = $"{stopwatch}";

            //Pellets
            foreach (Pellets p in pellet)
            {
                e.Graphics.FillRectangle(redBrush, p.x, p.y, p.size, p.size);
            }

            //Hero
            e.Graphics.FillRectangle(blueBrush, hero.x, hero.y, hero.width, hero.height);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
            }
        }


        public void InitializeGame()
        {
            hero = new guy();

            int x = randGen.Next(20, this.Width - 50);
            int y = randGen.Next(20, this.Width - 50);

            square = new Pellets(x, y);
        }

        


    }
}
