using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Hockey___Avery_D
{
    public partial class Form1 : Form
    {
        //global variables

        Rectangle player1 = new Rectangle(10, 160, 35, 35);
        Rectangle player2 = new Rectangle(542, 160, 35, 35);
        Rectangle puck = new Rectangle(280, 163, 30, 30);

        Rectangle net1 = new Rectangle(20, 160, 100, 100);
        Rectangle net2 = new Rectangle(20, 160, 100, 100);

        int player1Score = 0;
        int player2Score = 0;

        int playerXSpeed = 7;
        int playerYSpeed = 7;

        int puckXSpeed = 6;
        int puckYSpeed = -6;

        //player 1
        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        //player 2
        bool upArrowPressed = false;
        bool downArrowPressed = false;
        bool leftArrowPressed = false;
        bool rightArrowPressed = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        SolidBrush blackBrush = new SolidBrush(Color.Black);

        SolidBrush greyBrush = new SolidBrush(Color.Gray);

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move puck
            puck.X += puckXSpeed;
            puck.Y += puckYSpeed;

            //move player 1 
            if (wPressed == true && player1.Y > 0)
            {
                player1.Y -= playerYSpeed;
            }
            if (sPressed == true && player1.Y < 330)
            {
                player1.Y += playerYSpeed;
            }
            if (aPressed == true && player1.X > 0)
            {
                player1.X -= playerXSpeed;
            }
            if (dPressed == true && player1.X < this.Width - 52)
            {
                player1.X += playerXSpeed;
            }

            //move player 2
            if (upArrowPressed == true && player2.Y > 0)
            {
                player2.Y -= playerYSpeed;
            }
            if (downArrowPressed == true && player2.Y < 330)
            {
                player2.Y += playerYSpeed;
            }
            if (leftArrowPressed == true && player2.X > 0)
            {
                player2.X -= playerXSpeed;
            }
            if (rightArrowPressed == true && player2.X < this.Width - 52)
            {
                player2.X += playerXSpeed;
            }

            //check if ball hit top or bottom, change ball direction if true
            if (puck.Y < 0 || puck.Y > 340)
            {
                puckYSpeed *= -1;
            }
            //check if ball hit either side, change ball direction if true
            if (puck.X < 0 || puck.X > this.Width - 40)
            {
                puckXSpeed *= -1;
            }

            //check if ball hit goal 1 or goal 2, if so, add point to appropriate player

            //check if either player reached 3 points (game over)

            //paint screen
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p1ScoreLabel.Text = $"{player1Score}";
            p2ScoreLabel.Text = $"{player2Score}";

            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);

            e.Graphics.FillEllipse(blackBrush, puck);

            e.Graphics.FillEllipse(greyBrush, net1);
            e.Graphics.FillEllipse(greyBrush, net2);

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upArrowPressed = false;
                    break;
                case Keys.Down:
                    downArrowPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.Left:
                    leftArrowPressed = false;
                    break;
                case Keys.Right:
                    rightArrowPressed = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upArrowPressed = true;
                    break;
                case Keys.Down:
                    downArrowPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Left:
                    leftArrowPressed = true;
                    break;
                case Keys.Right:
                    rightArrowPressed = true;
                    break;
            }
        }
    }
}
