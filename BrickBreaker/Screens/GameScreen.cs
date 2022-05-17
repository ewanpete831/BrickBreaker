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
        Boolean leftArrowDown, rightArrowDown;

        //extra bools
        bool paused = false;
        bool escunpressed = true;

        int bigpaddletime;
        int slowtime;
        int fasttime;

        // Game values
        int lives;
        int level;
        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;
        Random randGen = new Random();
        int paddleWidth;

        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        public static SoundPlayer tiePlayer = new SoundPlayer(Properties.Resources.TIE_fighter_fire_1);

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
            TrentImages();

        }
        public void ashtonpower(int x, int y)
        {

            int id = randGen.Next(1, 5);

            powerups p = new powerups(x, y, 5, 5, id);

            power.Add(p);
        }
        public void TrentImages()
        {
            BackgroundImage = Properties.Resources.DeathStar4;
        }


        public void TrentSounds()
        {
            //Random randGen = new Random();

            //int tie1 = randGen.Next(1, 3);
            //int tie2 = randGen.Next(1, 3);

            //if (tie1 == 1)
            //{
            //    SoundPlayer player = new SoundPlayer(Properties.Resources.TIE_fighter_fire_1);

            //    player.Play();
            //}
            //else if (tie2 == 2 && tie1 == 1)
            //{

            //}
        }

        public void powerupsmove()
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

            level = 1;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            // setup starting paddle values and create paddle object
            paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.White);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            int xSpeed = 6;
            int ySpeed = 6;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);

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
            //check powerup collision
            foreach (powerups p in power)
            {
                if (p.PowerupCollision(paddle) == true)
                {
                    if (p.id == 1)
                    {
                        lives++;
                    }
                    if (p.id == 2)
                    {
                        bigpaddletime += 1000;
                        paddle.width = 130;
                        paddle.x -= 25;
                    }
                    if (p.id == 3)
                    {
                        slowtime += 1000;
                        ball.xSpeed *= 0.5;
                        ball.ySpeed *= 0.5;
                    }
                    if (p.id == 4)
                    {
                        fasttime += 1000;
                        ball.xSpeed *= 1.5;
                        ball.ySpeed *= 1.5;
                    }
                    power.Remove(p);
                    break;
                }
            }
            if (fasttime == 1)
            {
                ball.xSpeed *= 0.66;
                ball.ySpeed *= 0.66;
            }
            if (slowtime == 1)
            {
                ball.xSpeed *= 2;
                ball.ySpeed *= 2;
            }
            if (bigpaddletime == 1)
            {
                paddle.width = paddleWidth;
            }

            powerupsmove(); //move powerups

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
            ball.Move();

            // Check for collision with top and side walls
            ball.WallCollision(this);

            // Check for ball hitting bottom of screen
            if (ball.BottomCollision(this))
            {
                lives--;

                // Moves the ball back to origin
                ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                ball.y = (this.Height - paddle.height) - 85;

                if (lives == 0)
                {
                    OnEnd();
                }
            }

            // Check for collision of ball with paddle, (incl. paddle movement)
            ball.PaddleCollision(paddle);

            // Check if ball has collided with any blocks
            foreach (Block b in blocks)
            {
                b.lastHitTime++;
                if (ball.BlockCollision(b))
                {
                    if (b.lastHitTime > 5)
                    {
                        b.hp--;
                        b.lastHitTime = 0;
                    }
                    if (b.hp < 1)
                    {
                        blocks.Remove(b);
                        int powerupChance = randGen.Next(0, 100);

                        if (powerupChance > 1)

                        {
                            ashtonpower(b.x, b.y);
                        }
                    }

                    if (blocks.Count == 0)
                    {
                        pauseLabel.Text = $"Level {level} Complete!";
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
                            OnEnd();
                        }
                    }
                    break;
                }
            }
            Refresh();
        }

        private void ResetPaddle()
        {
            paddle.x = this.Width / 2;
            paddle.y = (this.Height - paddle.height) - 60;

            ball.x = this.Width / 2 - 10;
            ball.y = this.Height - paddle.height - 80;
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
            ResetPaddle();

            XmlReader reader = XmlReader.Create($"Resources/testLevel{level}.xml");

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
        {   //draws power up 
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
            }

            // Draws paddle
            if (0 < bigpaddletime && bigpaddletime < 100)
            {
                int opacity = 255 / ((bigpaddletime % 50) + 1);
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

            // Draws ball
            e.Graphics.FillRectangle(ballBrush, Convert.ToInt32(ball.x), Convert.ToInt32(ball.y), Convert.ToInt32(ball.size), Convert.ToInt32(ball.size));
        }
    }
}
