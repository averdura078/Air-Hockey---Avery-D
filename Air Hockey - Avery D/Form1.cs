using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

//an air hockey game
//Avery Durand
//ICS3U
//Mr. T

namespace Air_Hockey___Avery_D
{
    public partial class Form1 : Form
    {
        //global variables

        //moving rectangles
        Rectangle player1 = new Rectangle(10, 165, 35, 35);
        Rectangle player2 = new Rectangle(542, 165, 35, 35);
        Rectangle puck = new Rectangle(275, 168, 30, 30);
        Rectangle yellowBlob = new Rectangle(-50, -50, 20, 20);

        //static rectangles
        Rectangle net1 = new Rectangle(-10, 95, 50, 180);
        Rectangle net2 = new Rectangle(547, 95, 50, 180);

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 4;
        int player2Speed = 4;

        int puckXSpeed = 0;
        int puckYSpeed = 0;

        //player 1 (blue) buttons
        bool wPressed = false;
        bool sPressed = false;
        bool aPressed = false;
        bool dPressed = false;

        //player 2 (red) buttons
        bool upArrowPressed = false;
        bool downArrowPressed = false;
        bool leftArrowPressed = false;
        bool rightArrowPressed = false;

        //player colours
        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        //puck colour
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        //nets colour
        SolidBrush greyBrush = new SolidBrush(Color.Gray);

        //yellow blob colour
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        //decoration colour
        Pen redPen = new Pen(Color.Salmon, 4);

        //sound players
        SoundPlayer collision = new SoundPlayer(Properties.Resources.intersection);
        SoundPlayer gameOver = new SoundPlayer(Properties.Resources.fanfare);
        SoundPlayer powerUp = new SoundPlayer(Properties.Resources.starpower);

        Random random = new Random();

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
                player1.Y -= player1Speed;
            }
            if (sPressed == true && player1.Y < 330)
            {
                player1.Y += player1Speed;
            }
            if (aPressed == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }
            if (dPressed == true && player1.X < this.Width - 52)
            {
                player1.X += player1Speed;
            }

            //move player 2
            if (upArrowPressed == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }
            if (downArrowPressed == true && player2.Y < 330)
            {
                player2.Y += player2Speed;
            }
            if (leftArrowPressed == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            if (rightArrowPressed == true && player2.X < this.Width - 52)
            {
                player2.X += player2Speed;
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

            //check if puck hit player 1, and which side
            if (player1.IntersectsWith(puck))
            {
                //play sound
                collision.Play();

                if (puckXSpeed == 0)
                {
                    puckXSpeed = 8;
                    puckYSpeed = 8;
                }
                else
                {
                    //create rectangles on sides of player
                    Rectangle topRect = new Rectangle(player1.X + 4, player1.Y, 22, 3);
                    Rectangle bottomRect = new Rectangle(player1.X + 4, player1.Y + 27, 22, 3);
                    Rectangle leftRect = new Rectangle(player1.X, player1.Y + 4, 3, 22);
                    Rectangle rightRect = new Rectangle(player1.X + 27, player1.Y + 25, 3, 22);

                    //check which rectangle the puck hit
                    if (topRect.IntersectsWith(puck))
                    {
                        puckYSpeed *= -1;
                        puck.Y = player1.Y - puck.Height;
                    }
                    else if (bottomRect.IntersectsWith(puck))
                    {
                        puckYSpeed *= -1;
                        puck.Y = player1.Y + player1.Height;
                    }
                    else if (leftRect.IntersectsWith(puck))
                    {
                        puckXSpeed *= -1;
                        puck.X = player1.X - puck.Width;
                    }
                    else if (rightRect.IntersectsWith(puck))
                    {
                        puckXSpeed *= -1;
                        puck.X = player1.X + player1.Width;
                    }
                }
            }

            //check if puck hit player 2, and which side
            if (player2.IntersectsWith(puck))
            {
                //play sound
                collision.Play();

                if (puckXSpeed == 0)
                {
                    puckYSpeed = -8;
                    puckXSpeed = -8;
                }
                else
                {
                    //create rectangles on sides of player
                    Rectangle topRect = new Rectangle(player2.X + 4, player2.Y, 22, 3);
                    Rectangle bottomRect = new Rectangle(player2.X + 4, player2.Y + 27, 22, 3);
                    Rectangle leftRect = new Rectangle(player2.X, player2.Y + 4, 3, 22);
                    Rectangle rightRect = new Rectangle(player2.X + 27, player2.Y + 25, 3, 22);

                    //check which rectangle the puck hit
                    if (topRect.IntersectsWith(puck))
                    {
                        puckYSpeed *= -1;
                        puck.Y = player2.Y - puck.Height;
                    }
                    else if (bottomRect.IntersectsWith(puck))
                    {
                        puckYSpeed *= -1;
                        puck.Y = player2.Y + player2.Height;
                    }
                    else if (leftRect.IntersectsWith(puck))
                    {
                        puckXSpeed *= -1;
                        puck.X = player2.X - puck.Width;
                    }
                    else if (rightRect.IntersectsWith(puck))
                    {
                        puckXSpeed *= -1;
                        puck.X = player2.X + player2.Width;
                    }
                }
            }

            //check if ball hit goal 1 or goal 2, if so, add point to appropriate player and reset
            if (net1.IntersectsWith(puck))
            {
                player2Score++;

                player1.X = 10;
                player1.Y = 165;
                player2.X = 542;
                player2.Y = 165;
                puck.X = 275;
                puck.Y = 168;

                puckXSpeed = 0;
                puckYSpeed = 0;
            }
            if (net2.IntersectsWith(puck))
            {
                player1Score++;

                player1.X = 10;
                player1.Y = 165;
                player2.X = 542;
                player2.Y = 165;
                puck.X = 275;
                puck.Y = 168;

                puckXSpeed = 0;
                puckYSpeed = 0;
            }

            //check if either player reached 3 points (game over)
            if (player1Score >= 3 || player2Score >= 3)
            {
                //stop loop
                gameTimer.Stop();

                //reset positions
                player1.X = 10;
                player1.Y = 165;
                player2.X = 542;
                player2.Y = 165;
                puck.X = 275;
                puck.Y = 168;

                //reset player speeds
                player1Speed = 4;
                player2Speed = 4;

                //display winner
                if (player1Score >= 3)
                {
                    winLabel.ForeColor = Color.DodgerBlue;
                    winLabel.Text = $"GAME OVER! Player 1 wins {player1Score}-{player2Score}";
                }
                else if (player2Score >= 3)
                {
                    winLabel.ForeColor = Color.Red;
                    winLabel.Text = $"GAME OVER! Player 2 wins {player2Score}-{player1Score}";
                }

                //show button
                resetButton.Enabled = true;
                resetButton.Visible = true;

                //play sound
                gameOver.Play();
            }

            //check if player hit yellow blob and speed up player
            if (player1.IntersectsWith(yellowBlob))
            {
                powerUp.Play();

                player1Speed = 6;

                yellowBlob.X = -50;
                yellowBlob.Y = -50;

                speedBoost1.Enabled = true;
                speedBoost1.Interval = 4000;
            }
            if (player2.IntersectsWith(yellowBlob))
            {
                powerUp.Play();

                player2Speed = 6;

                yellowBlob.X = -50;
                yellowBlob.Y = -50;

                speedBoost2.Enabled = true;
                speedBoost1.Interval = 4000;
            }

            //paint screen after all above conditions are checked
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //middle line and circle
            e.Graphics.DrawLine(redPen, 290, 0, 290, 400);
            e.Graphics.DrawEllipse(redPen, 230, 125, 120, 120);

            //nets
            e.Graphics.FillRectangle(greyBrush, net1);
            e.Graphics.FillRectangle(greyBrush, net2);

            //scores
            p1ScoreLabel.Text = $"{player1Score}";
            p2ScoreLabel.Text = $"{player2Score}";

            //players
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(redBrush, player2);

            //puck
            e.Graphics.FillEllipse(blackBrush, puck);

            e.Graphics.FillEllipse(yellowBrush, yellowBlob);
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            //reset everything
            resetButton.Enabled = false;
            resetButton.Visible = false;

            winLabel.Text = "";

            player1Score = 0;
            player2Score = 0;

            puckXSpeed = 0;
            puckYSpeed = 0;

            player1Speed = 4;
            player2Speed = 4;

            wPressed = false;
            sPressed = false;
            aPressed = false;
            dPressed = false;

            upArrowPressed = false;
            downArrowPressed = false;
            leftArrowPressed = false;
            rightArrowPressed = false;

            //restart game
            gameTimer.Start();
        }

        private void blub_Tick(object sender, EventArgs e)
        {
            //get random coordinates
            int yR = random.Next(1, this.Height);
            int xR = random.Next(1, this.Width);

            //change yellow blob position
            yellowBlob.Y = yR;
            yellowBlob.X = xR;
        }

        private void speedBoost1_Tick(object sender, EventArgs e)
        {
            powerUp.Stop();

            player1Speed = 4;

            speedBoost1.Enabled = false;
        }

        private void speedBoost2_Tick(object sender, EventArgs e)
        {
            powerUp.Stop();

            player2Speed = 4;

            speedBoost1.Enabled = false;
        }
    }
}
