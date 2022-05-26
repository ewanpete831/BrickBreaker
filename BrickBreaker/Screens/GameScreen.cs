/*  Created by: Ewan, Trent, Adrian, Ashton, Drew
 *  Project: Brick Breaker
 *  Date: May 4, 2022
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;
using System.Threading;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        List<powerups> power = new List<powerups>();

        #region global values

        //player1 button control keys - DO NOT CHANGE
        public static Boolean leftArrowDown, rightArrowDown;

        //extra bools
        bool paused = false;
        bool escunpressed = true;

        int bigpaddletime;
        int slowtime;
        int fasttime;
        int ballDamage;
        int damagetime;
        int standardBallSpeed = 6;


        // Game values
        int lives;
        int level;
        // Paddle and Ball objects
        Paddle paddle;
        Random randGen = new Random();
        int paddleWidth;

        public static int soundtimer = 0;

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();
        List<Ball> balls = new List<Ball>();

        public static SoundPlayer tiePlayer = new SoundPlayer(Properties.Resources.TIE_fighter_fire_1);
        public static SoundPlayer tiePlayer2 = new SoundPlayer(Properties.Resources.TIE_fighter_fire_2);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.GameoverSound);
        public static SoundPlayer brickBroken = new SoundPlayer(Properties.Resources.BrickDestroy);

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush healthBrush = new SolidBrush(Color.Black);

        Font healthFont = new Font("Times New Roman", 12.0f);

        #endregion

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }
        public void ashtonpower(int x, int y) // pick a random powerup and spawn it
        {
            int id = randGen.Next(1, 7); 

            powerups p = new powerups(x, y, 3, id);

            power.Add(p);
        }
        public void TrentImages() // shows correct background images
        {
            if (level < 2 || level > 3)
            {
                BackgroundImage = Properties.Resources.DeathStar4;
            }
            else
            {
                BackgroundImage = Properties.Resources.Tie_Fighter_View;
            }
        }


        public static void TrentSounds(string Sound) // sound effects
        {
            if (soundtimer < 1)
            {
                if (Sound == "Tie")
                {
                    Random randGen = new Random();

                    int tie1 = randGen.Next(1, 3);
                    if (tie1 == 1)
                    {
                        tiePlayer.Play();
                    }
                    else
                    {
                        tiePlayer2.Play();
                    }
                    soundtimer = 35;
                }
                if (Sound == "block")
                {
                    brickBroken.Play();
                    soundtimer = 35;
                }
            }
        }

        public void powerupsmove() // move each powerup
        {
            foreach (powerups pow in power)
            {
                Size screenSize;
                screenSize = new Size(this.Width, this.Height);
                pow.Move(screenSize);
            }
        }

        public void OnStart()
        {
            //set life counter
            lives = 3;

            //reset level and highscore
            level = 0;

            Form1.win = false;

            Form1.highscore = 0;

            ballDamage = 1;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // setup starting paddle values and create paddle object
            paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            //spawn new ball
            NewBall();

            //load first level
            LoadLevel(level);


            // start the game engine loop
            gameTimer.Enabled = true;

            pauseLabel.Text = "";
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    tryPause();
                    break;
                case Keys.Enter:
                    if (paused == true)
                    {
                        OnEnd();
                    }
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    escunpressed = true;
                    break;
                default:
                    break;
            }
        }

        private void tryPause()
        {
            if (paused == false)
            {
                if (escunpressed == true)
                {
                    pauseLabel.Text = "paused";
                    leaveLabel.Visible = true;
                    gameTimer.Stop();
                    paused = true;
                    escunpressed = false;
                }
            }
            else
            {
                if (escunpressed == true)
                {
                    pauseLabel.Text = "";
                    leaveLabel.Visible = false;
                    gameTimer.Start();
                    paused = false;
                    escunpressed = false;
                }
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            soundtimer--; // timer for sound effects

            //reduce all powerup timers
            if (fasttime > 0) 
            {
                fasttime--;
            }
            if (slowtime > 0)
            {
                slowtime--;
            }

            if (bigpaddletime > 0)
            {
                bigpaddletime--;
            }
            if (damagetime > 0)
            {
                damagetime--;
            }

            //powerups
            //
            //
            //

            foreach (powerups p in power) // check for powerup collision
            {
                if (p.PowerupCollision(paddle) == true)
                {
                    if (p.id == 1) // life powerup
                    {
                        Form1.highscore++;
                        lives++;
                    }
                    if (p.id == 2) // expand paddle
                    {
                        Form1.highscore++;
                        bigpaddletime += 1000;
                        paddle.width = 130;
                        paddle.x -= 25;
                    }
                    if (p.id == 3) // slow ball
                    {
                        Form1.highscore++;
                        slowtime += 1000;
                        foreach (Ball ball in balls)
                        {
                            if(ball.ySpeed < 0)
                            {
                                ball.ySpeed = -3;
                            }
                            else
                            {
                                ball.ySpeed = 3;
                            }

                            if(ball.xSpeed < 0)
                            {
                                ball.xSpeed = -3;
                            }
                            else
                            {
                                ball.xSpeed = 3;
                            }
                        }
                    }
                    if (p.id == 4) // fast ball
                    {
                        Form1.highscore++;
                        fasttime += 1000;
                        foreach (Ball ball in balls)
                        {
                            if (ball.ySpeed < 0)
                            {
                                ball.ySpeed = -8;
                            }
                            else
                            {
                                ball.ySpeed = 8;
                            }

                            if (ball.xSpeed < 0)
                            {
                                ball.xSpeed = -8;
                            }
                            else
                            {
                                ball.xSpeed = 8;
                            }
                        }
                    }
                    if (p.id == 5) // double damage
                    {
                        Form1.highscore++;
                        ballDamage = 2;
                        damagetime += 1000;
                    }
                    if (p.id == 6) // extra ball
                    {
                        Form1.highscore++;

                        NewBall();
                    }
                    power.Remove(p);
                    break;
                }
            }

            //powerups expire

            if (fasttime == 1) // fast ball
            {
                foreach(Ball ball in balls)
                    {
                    if (ball.ySpeed < 0)
                    {
                        ball.ySpeed = -6;
                    }
                    else
                    {
                        ball.ySpeed = 6;
                    }

                    if (ball.xSpeed < 0)
                    {
                        ball.xSpeed = -6;
                    }
                    else
                    {
                        ball.xSpeed = 6;
                    }
                }
            }
            if (slowtime == 1) // slow ball
            {
                foreach (Ball ball in balls)
                {
                    if (ball.ySpeed < 0)
                    {
                        ball.ySpeed = -6;
                    }
                    else
                    {
                        ball.ySpeed = 6;
                    }

                    if (ball.xSpeed < 0)
                    {
                        ball.xSpeed = -6;
                    }
                    else
                    {
                        ball.xSpeed = 6;
                    }
                }
            }
            if (bigpaddletime == 1) // big paddle
            {
                paddle.width = paddleWidth;
            }
            if (damagetime == 1) // double damage
            {
                ballDamage = 1;
            }

            powerupsmove(); //move powerups
            //
            //
            //

            // Move the paddle
            if (leftArrowDown && paddle.x > 0)
            {
                paddle.Move("left");
            }
            if (rightArrowDown && paddle.x < (this.Width - paddle.width))
            {
                paddle.Move("right");
            }

            // Move ball
            foreach (Ball ball in balls)
            {
                ball.Move();


                // Check for collision with top and side walls
                ball.WallCollision(this);

                // Check for ball hitting bottom of screen
                if (ball.BottomCollision(this))
                {
                    balls.Remove(ball);
                    if (balls.Count < 1)
                    {
                        lives--;
                        NewBall();
                    }
                    break;
                }

                // Check for collision of ball with paddle, (incl. paddle movement)
                ball.PaddleCollision(paddle);
            }

            if (lives == 0) // end game at 0 lives
            {
                gameOverSound.Play();
                OnEnd();
            }

            // Check if ball has collided with any blocks
            foreach (Ball ball in balls)
            {
                foreach (Block b in blocks)
                {
                    b.lastHitTime++;

                    if (ball.BlockCollision(b))
                    {
                        if (b.lastHitTime > 10)
                        {
                            b.hp -= ballDamage;
                            b.lastHitTime = 0;
                        }
                        if (b.hp < 1)
                        {
                            Form1.highscore++;
                            blocks.Remove(b);
                            TrentSounds("block");
                            int powerupChance = randGen.Next(0, 100);

                            if (powerupChance > 30) // spawn powerups

                            {
                                ashtonpower(b.x, b.y);
                            }
                        }

                        if (blocks.Count == 0) // level cleared
                        {
                            pauseLabel.Text = $"Level {level + 1} Complete!";
                            lives++;
                            Refresh();
                            Thread.Sleep(2000);
                            pauseLabel.Text = "";

                            if (level < 4)
                            {
                                level++;
                                LoadLevel(level);
                            }
                            else
                            {
                                Form1.win = true;
                                OnEnd();
                            }
                        }
                        break;
                    }
                }
            }
            Refresh();
        }
        private void NewBall()
        {
            // setup starting ball values
            int ballX = paddle.x + (paddle.width / 2);
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            int ballSize = 20;

            balls.Add(new Ball(ballX, ballY, standardBallSpeed, standardBallSpeed, ballSize));
        }

        private void ResetPaddle()
        {
            paddle.x = this.Width / 2;
            paddle.y = (this.Height - paddle.height) - 60;

            balls[0].x = this.Width / 2 - 10;
            balls[0].y = this.Height - paddle.height - 80;
        }

        public void OnEnd()
        {
            gameTimer.Enabled = false;

            // Goes to the game over screen
            Form form = this.FindForm();
            GameOverScreen go = new GameOverScreen();

            go.Location = new Point((form.Width - go.Width) / 2, (form.Height - go.Height) / 2);

            form.Controls.Add(go);
            form.Controls.Remove(this);
        }

        public void LoadLevel(int level)
        {
            TrentImages();
            ResetPaddle();

            XmlReader reader = XmlReader.Create($"Resources/Level{level}.xml");

            blocks.Clear();
            string x, y, hp, colour;


            while (reader.Read())
            {
                reader.ReadToFollowing("x");
                x = reader.ReadString();

                reader.ReadToFollowing("y");
                y = reader.ReadString();

                reader.ReadToFollowing("hp");
                hp = reader.ReadString();

                reader.ReadToFollowing("colour");
                colour = reader.ReadString();

                if (x != "")
                {
                    blocks.Add(new Block(Convert.ToInt32(x), Convert.ToInt32(y), Convert.ToInt32(hp), Color.FromName($"{colour}")));
                }
            }
            reader.Close();
        }

        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {   
            scoreplay.Text = Convert.ToString(Form1.highscore); // shows score

            //draws power up 
            foreach (powerups powers in power)
            {
                if (powers.id == 1)
                {
                    e.Graphics.FillRectangle(Brushes.Blue, powers.x, powers.y, powers.size, powers.size);
                }
                if (powers.id == 2)
                {
                    e.Graphics.FillRectangle(Brushes.Red, powers.x, powers.y, powers.size, powers.size);
                }
                if (powers.id == 3)
                {
                    e.Graphics.FillRectangle(Brushes.Purple, powers.x, powers.y, powers.size, powers.size);
                }
                if (powers.id == 4)
                {
                    e.Graphics.FillRectangle(Brushes.Gold, powers.x, powers.y, powers.size, powers.size);
                }
                if (powers.id == 5)
                {
                    e.Graphics.FillRectangle(Brushes.Green, powers.x, powers.y, powers.size, powers.size);
                }
                if (powers.id == 6)
                {
                    e.Graphics.FillRectangle(Brushes.White, powers.x, powers.y, powers.size, powers.size);
                }
            }

            // Draws paddle

            if (0 < bigpaddletime && bigpaddletime < 100) // flash paddle when time is low
            {
                int opacity = 255 / ((bigpaddletime % 50) + 3);
                if (opacity < 10)
                {
                    opacity += 20;
                }
                paddleBrush.Color = (Color.FromArgb(opacity, paddle.colour));
            }
            else
            {
                paddleBrush.Color = paddle.colour;
            }

            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            //display lives
            livesLabel.Text = $"Lives: {lives}";

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);
                e.Graphics.DrawString($"{b.hp}", healthFont, healthBrush, b.x + 15, b.y);
            }
            foreach (Ball ball in balls)
            {
                if (damagetime < 1)
                {
                    ballBrush.Color = Color.White;
                }
                else
                {
                    ballBrush.Color = Color.Red;
                }
                    e.Graphics.FillRectangle(ballBrush, Convert.ToInt32(ball.x), Convert.ToInt32(ball.y), Convert.ToInt32(ball.size), Convert.ToInt32(ball.size));
            }
        }
    }
}
