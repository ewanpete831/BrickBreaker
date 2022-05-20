using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public double x, y, xSpeed, ySpeed, size, lifeTime;
        public Color colour;

        public static Random rand = new Random();

        public Ball(double _x, double _y, double _xSpeed, double _ySpeed, double _ballSize, double _lifetime)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
            lifeTime = _lifetime;
        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
            lifeTime--;
        }

        public bool BlockCollision(Block b)
        {
            //Random rand = new Random();
            //int randNum = rand.Next(2, 6); 


            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));

            //if (ballRec.IntersectsWith(blockRec))
            //{
            //    ySpeed *= -1;       
            //}

            //ball bounces off of all sides of bricks 
            if (ballRec.IntersectsWith(blockRec))
            {
                if (ySpeed < 0 && (ballRec.Top >= blockRec.Bottom - 5))
                {
                    //xSpeed = randNum;  
                    ySpeed *= -1;
                    return true;
                }
                else if (ySpeed > 0 && (ballRec.Bottom <= blockRec.Top + 5))
                {
                    ySpeed *= -1;
                    return true;
                }
                else
                {
                    xSpeed *= -1;
                    return true;
                }
            }


            return false;
        }

        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);
            //if (ballRec.IntersectsWith(paddleRec))
            //{
            //    //ball bounces up off of paddle
            //    ySpeed *= -1;

            //Ball bounces off of paddle. Ball does not get stuck in paddle if hit from side
            if (ballRec.IntersectsWith(paddleRec))
            {
                if (ySpeed > 0)
                {
                    y = p.y - p.height;
                }
                else
                {
                    y = p.y + p.height;
                }
                ySpeed *= -1;

                //GameScreen.tiePlayer.Play();
                GameScreen.TrentSounds();
                }            

        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                xSpeed *= -1;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
            }
            // Collision with top wall
            if (y <= 2)
            {
                ySpeed *= -1;
            }
        }

        public bool BottomCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y >= UC.Height)
            {
                didCollide = true;
            }

            return didCollide;
        }

    }
}
