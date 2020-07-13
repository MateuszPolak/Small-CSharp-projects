using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        
        List<ClBall> listBalls = new List<ClBall>();
        int start_counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        int start_coord = 50;
        

        private void button_ss_Click(object sender, EventArgs e)
        {
            if (start_counter == 0)
            {
                button_generate.Focus();
                SendKeys.Send(" ");
            }
            start_counter = 1;

            if (button_ss.Text == "Start")
            {
                timer1.Start();
                button_ss.Text = "Stop";
            }
            else if (button_ss.Text == "Stop")
            {
                timer1.Stop();
                button_ss.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startBOX.Location = new Point(start_coord, start_coord);

            for (int ii = 0; ii < listBalls.Count; ii++)
            {
                for (int jj = ii + 1; jj < listBalls.Count; jj++)
                {
                    if (listBalls[ii].Bounds.IntersectsWith(listBalls[jj].Bounds))
                    {
                            int firstBallmass = 1;
                            int secondBallmass = 1;
                            //newVelX1 = (firstBall.speed.x * (firstBall.mass – secondBall.mass) +(2 * secondBall.mass * secondBall.speed.x)) / (firstBall.mass + secondBall.mass);
                            double newVelX1 = (listBalls[ii].Vx * (firstBallmass - secondBallmass) + (2 * secondBallmass * listBalls[jj].Vx)) / (firstBallmass + secondBallmass);
                            double newVelX2 = (listBalls[jj].Vx * (firstBallmass - secondBallmass) + (2 * secondBallmass * listBalls[ii].Vx)) / (firstBallmass + secondBallmass);
                            double newVelY1 = (listBalls[ii].Vy * (firstBallmass - secondBallmass) + (2 * secondBallmass * listBalls[jj].Vy)) / (firstBallmass + secondBallmass);
                            double newVelY2 = (listBalls[jj].Vy * (firstBallmass - secondBallmass) + (2 * secondBallmass * listBalls[ii].Vy)) / (firstBallmass + secondBallmass);

                            listBalls[ii].Vx = newVelX1;
                            listBalls[jj].Vx = newVelX2;
                            listBalls[ii].Vy = newVelY1;
                            listBalls[jj].Vy = newVelY2;
                    }
                }
            }
           
            foreach (ClBall good_ball in listBalls)
            {
                //Motion
                good_ball.Location = new Point(good_ball.Location.X + (int)good_ball.Vx, good_ball.Location.Y + (int)good_ball.Vy);
                
                //Boundaries 
                if (good_ball.Location.X < 0)
                {
                    good_ball.Vx = -good_ball.Vx;
                    good_ball.Location = new Point(0, good_ball.Location.Y);
                }
                else if (good_ball.Location.Y < 0)
                {

                    good_ball.Location = new Point(good_ball.Location.X, 0);
                    good_ball.Vy = -good_ball.Vy;
                }
                else if (good_ball.Location.X > panel1.Width - good_ball.Width)
                {
                    
                    good_ball.Vx = -good_ball.Vx;
                    good_ball.Location = new Point(panel1.Width - good_ball.Width, good_ball.Location.Y);
                }
                else if (good_ball.Location.Y > panel1.Height - good_ball.Height)
                {
                    
                    good_ball.Vy = -good_ball.Vy;
                    good_ball.Location = new Point(good_ball.Location.X, panel1.Height - good_ball.Height);
                }

                if (good_ball.Location.Y + good_ball.Height >= Paddle.Location.Y )
                {
                    if (Paddle.Location.X <= (good_ball.Location.X + (good_ball.Width / 2)))
                    {
                        if (good_ball.Location.X + (good_ball.Width / 2) <= (Paddle.Location.X + Paddle.Width))
                        {
                            good_ball.Vy = -good_ball.Vy;
                        }
                    }
                }

                int mouse_step = 6;
                int mouse_tolerance = 5;
                var coordinates = Paddle.PointToClient(Cursor.Position);

                if (coordinates.X - mouse_tolerance > (Paddle.Location.X + (Paddle.Width / 2)))
                {
                    Paddle.Location = new Point(Paddle.Location.X + mouse_step, Paddle.Location.Y);
                }
                else if (coordinates.X + mouse_tolerance < (Paddle.Location.X + (Paddle.Width / 2)))
                {
                    Paddle.Location = new Point(Paddle.Location.X - mouse_step, Paddle.Location.Y);
                }

                if (Paddle.Location.X <= 0)
                {
                    Paddle.Location = new Point(0, Paddle.Location.Y);
                }
                else if (Paddle.Location.X >= panel1.Width - Paddle.Width)
                {
                    Paddle.Location = new Point(panel1.Width - Paddle.Width, Paddle.Location.Y);
                }

                if (good_ball.Bounds.IntersectsWith(startBOX.Bounds))
                {
                    button_generate.Enabled = false;
                }
                else
                {
                    button_generate.Enabled = true;
                }
            }
        }
        private void button_generate_Click(object sender, EventArgs e)
        {
            ClBall newBall = new ClBall();
            newBall.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            newBall.Image = global::WindowsFormsApp1.Properties.Resources.soccer_ball_clip_art_13012;
            newBall.Location = new System.Drawing.Point(start_coord, start_coord);
            newBall.Name = "clBall1";
            newBall.Size = new System.Drawing.Size(30, 30);
            newBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            newBall.TabIndex = 2;
            newBall.TabStop = false;
            newBall.Vx = 2D;
            newBall.Vy = 2D;
            listBalls.Add(newBall);
            panel1.Controls.Add(newBall);

        }

    }
}
