using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public double x, y, xSpeed, ySpeed, size, lastX, lastY;
        public Color colour;

        public Ball(double _x, double _y, double _xSpeed, double _ySpeed, double _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
        }

        public void Move()
        {
            LastPositions(x, y);
            x += xSpeed;
            y += ySpeed;
        }

        public bool BlockCollision(Block b)
        {
            Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));

            if (ballRec.IntersectsWith(blockRec))
            {
                x = lastX;
                y = lastY;
                if (b.lastHitTime > 10)
                {
                    if (ySpeed < 0 && (ballRec.Top >= blockRec.Bottom - 5))
                    {
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
                else
                {
                    ySpeed *= -1;
                    xSpeed *= -1;
                }
            }


            return false;
        }

        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(size), Convert.ToInt32(size));
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

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

                if (Math.Abs(ySpeed) > 0)
                {
                    if (GameScreen.rightArrowDown)
                    {
                        if (Math.Abs(ySpeed) > 4)
                        {
                            xSpeed++;
                            ySpeed--;
                        }
                    }
                    else if (GameScreen.leftArrowDown)
                    {
                        if (Math.Abs(xSpeed) > 4)
                        {
                            xSpeed--;
                            ySpeed++;
                        }
                    }
                    else
                    {
                        if (GameScreen.rightArrowDown)
                        {
                            if (Math.Abs(xSpeed) > 4)
                            {
                                xSpeed++;
                                ySpeed--;
                            }
                        }
                        else if (GameScreen.leftArrowDown)
                        {
                            if (Math.Abs(ySpeed) > 4)
                            {
                                xSpeed--;
                                ySpeed++;
                            }
                        }
                    }
                }
                ySpeed *= -1;

                //GameScreen.tiePlayer.Play();
                GameScreen.TrentSounds("Tie");
            }

        }

        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                xSpeed *= -1;
                x = 0;
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
                x = UC.Width - size;
            }
            // Collision with top wall
            if (y <= 2)
            {
                ySpeed *= -1;
                y = 0;
            }
        }

        public void LastPositions(double x, double y)
        {
            double[] xs = new double[5];
            double[] ys = new double[5];

            xs[4] = xs[3];
            xs[3] = xs[2];
            xs[2] = xs[1];
            xs[1] = xs[0];
            xs[0] = x;

            ys[4] = ys[3];
            ys[3] = ys[2];
            ys[2] = ys[1];
            ys[1] = ys[0];
            ys[0] = y;

            lastX = xs[0];
            lastY = ys[0];
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
