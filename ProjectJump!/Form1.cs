namespace ProjectJump_
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            background.BackColor = Color.Transparent;
            pbPlayer.Parent = background;
            enemyOne.Parent = background;
            key.Parent = background;
            lblScore.Parent = background;
<<<<<<< HEAD
            pbPlayer.Height = 60;
            pbPlayer.Width = 40;

=======
            this.Width = 1500;
            this.Height = 700;
>>>>>>> origin/master
        }
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            timer1.Interval = 20;
            timer1.Start();
        }

        public bool up = true;
        public bool right = false;
        public bool down = false;
        public bool left = false;
        public bool isFalling = false;
        public bool onThisPlatform = false;
        public bool grounded = false;
        public bool hasKey = false;
        public bool shownNoKeyMessage = true;

        public bool moveOtherSide = true;
        public bool moveOtherSideVertical = true;

        public bool rightWallHit = false;
        public bool leftWallHit = false;

        public bool enemyGoingLeft = true;

        public int playerSpeed = 6;
        public int jumpHeight = 25;
        public int gravity = 0;
        public int fallingSpeed = 0;
        public int enemySpeed = 6;
        public int scoreCounter = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !leftWallHit)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right && !rightWallHit)
            {
                right = true;
            }

            if (up != true )
            {
                if (e.KeyCode == Keys.Up)
                {
                    up = true;

                    gravity = jumpHeight;
                    grounded = false;
                }
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }

        /*private void moveGameElements(string direction)
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string) x.Tag == "platform" || (string) x.Tag == "door")
                    {
                        if(direction == "forward")
                        {
                            x.Left += backgroundMoveSpeed;
                        }
                        if(direction == "backwards")
                        {
                            x.Left -= backgroundMoveSpeed;
                        }
                    }
                }
            }
        }*/

        public void gameOver(String str)
        {
            pbPlayer.Left = floor.Left + 50;//25;
            pbPlayer.Top = floor.Top - pbPlayer.Height - 20;
            right = false;
            left = false;
            MessageBox.Show(str);
            hasKey = false;
            shownNoKeyMessage = true;
            key.Visible = true;
            enemyOne.Left = 580;
            timer1.Stop();
            timer1.Start();
        }

        public void gameWon()
        {
            pbPlayer.Left = floor.Left + 50;//25;
            pbPlayer.Top = floor.Top - pbPlayer.Height - 20;
            right = false;
            left = false;
            MessageBox.Show("Congratulations!!! You won.");
            hasKey = false;
            shownNoKeyMessage = true;
            key.Visible = true;
            enemyOne.Left = 580;
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblScore.Text = "Time: " + scoreCounter;

<<<<<<< HEAD
            

=======
>>>>>>> origin/master
            if (moveOtherSide)
            {
                if (movingBlockX.Right >= 420)
                {

                    if (pbPlayer.Right >= movingBlockX.Left && pbPlayer.Left <= movingBlockX.Right && pbPlayer.Bottom == movingBlockX.Top)
                    {
<<<<<<< HEAD
                        foreach (Control x in this.Controls)
                        {
                            if (pbPlayer.Right >= x.Left - 10 && pbPlayer.Right <= x.Left + 10 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 13 && pbPlayer.Location.Y < x.Bottom)
                            {

                                rightWallHit = true;
                            }

                            if (pbPlayer.Left >= x.Right - 10 && pbPlayer.Left <= x.Right + 10 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 3 && pbPlayer.Location.Y < x.Bottom)
                            {


                                leftWallHit = true;
                            }
                            if (leftWallHit)
                            {
                                leftWallHit = false;
                                pbPlayer.Left = x.Right + 3;
                                up = true;
                                gravity = 0;
                                break;
                            }
                            if (rightWallHit)
                            {
                                rightWallHit = false;
                                pbPlayer.Left = x.Left - pbPlayer.Width - 3;
                                up = true;
                                gravity = 0;
                                break;
                            }
                        }
=======
>>>>>>> origin/master
                        pbPlayer.Left -= playerSpeed;
                    }
                    movingBlockX.Left -= playerSpeed;
                }
                else
                {
                    moveOtherSide = !moveOtherSide;
                }

            }
            else if (!moveOtherSide)
            {
                if (movingBlockX.Left >= 294)
                {
<<<<<<< HEAD

                    if (pbPlayer.Right >= movingBlockX.Left && pbPlayer.Left <= movingBlockX.Right && pbPlayer.Bottom == movingBlockX.Top)
                    {
                        foreach (Control x in this.Controls)
                        {
                            if (pbPlayer.Right >= x.Left - 10 && pbPlayer.Right <= x.Left + 10 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 13 && pbPlayer.Location.Y < x.Bottom)
                            {

                                rightWallHit = true;
                            }

                            if (pbPlayer.Left >= x.Right - 3 && pbPlayer.Left <= x.Right + 3 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 3 && pbPlayer.Location.Y < x.Bottom)
                            {


                                leftWallHit = true;
                            }
                            if (leftWallHit)
                            {
                                leftWallHit = false;
                                pbPlayer.Left = x.Right + 3;
                                up = true;
                                gravity = 0;
                                break;
                            }
                            if (rightWallHit)
                            {
                                rightWallHit = false;
                                pbPlayer.Left = x.Left - pbPlayer.Width - 3;
                                up = true;
                                gravity = 0;
                                break;
                            }
                        }
=======
                    movingBlockX.Left += playerSpeed;
                    if (pbPlayer.Right >= movingBlockX.Left && pbPlayer.Left <= movingBlockX.Right && pbPlayer.Bottom == movingBlockX.Top)
                    {
>>>>>>> origin/master
                        pbPlayer.Left += playerSpeed;
                    }
                    movingBlockX.Left += playerSpeed;
                }

                if (movingBlockX.Location.X == 960)
                {
                    moveOtherSide = !moveOtherSide;
                }

            }

            if (moveOtherSideVertical)
            {
<<<<<<< HEAD
                if (movingBlockY.Top >= 282)
                {
                    if (pbPlayer.Bottom == movingBlockY.Top && pbPlayer.Right > movingBlockY.Left && pbPlayer.Left < movingBlockY.Right)
                    {
                        pbPlayer.Top -= playerSpeed;
                    }
                    movingBlockY.Top -= playerSpeed;

=======
                if (pbPlayer.Right > movingBlockY.Left && pbPlayer.Left < movingBlockY.Right  && pbPlayer.Bottom > movingBlockY.Top)
                {
                    pbPlayer.Top = movingBlockY.Location.Y - pbPlayer.Height;
                }

                if (movingBlockY.Top >= 282)
                {
                    movingBlockY.Top -= playerSpeed;
>>>>>>> origin/master
                }
                else { moveOtherSideVertical = !moveOtherSideVertical; }
            }
            else if (!moveOtherSideVertical)
            {
<<<<<<< HEAD
                if (pbPlayer.Bottom == movingBlockY.Top && pbPlayer.Right > movingBlockY.Left && pbPlayer.Left < movingBlockY.Right)
                {
                    pbPlayer.Top += playerSpeed;
                }
                movingBlockY.Top += playerSpeed;
                
                if (movingBlockY.Location.Y >= 410)
=======

                if (pbPlayer.Right > movingBlockY.Left && pbPlayer.Left < movingBlockY.Right && pbPlayer.Bottom > movingBlockY.Top)
                {
                    pbPlayer.Top = movingBlockY.Location.Y - pbPlayer.Height;
                }

                movingBlockY.Top += playerSpeed;
                if (movingBlockY.Location.Y == 410)
>>>>>>> origin/master
                {
                    moveOtherSideVertical = !moveOtherSideVertical;
                }
            }



            if (right && pbPlayer.Right <= this.ClientSize.Width)
            {
                pbPlayer.Left += playerSpeed;
                pbPlayer.Image = ProjectJump_.Properties.Resources.characterRight;
            }
            if (left && pbPlayer.Left >= 0)
            {
                pbPlayer.Left -= playerSpeed;
                pbPlayer.Image = ProjectJump_.Properties.Resources.characterLeft;
            }

            if (up)
            {
                pbPlayer.Top -= gravity;
                gravity -= 3;
                if (gravity < -15)
                {
                    gravity += 3;
                }
            }

            /*if(left == true && background.Left < 0)
            {
                background.Left += backgroundMoveSpeed;
                moveGameElements("forward");
            }
            if(right == true && background.Left > -800)
            {
                background.Left -= backgroundMoveSpeed;
                moveGameElements("backwards");
            }*/

            if (pbPlayer.Bounds.IntersectsWith(pbDoor.Bounds))
            {
                if (hasKey)
                {
                    gameWon();
                }
                else
                {
                    if (shownNoKeyMessage)
                    {
                        shownNoKeyMessage = false;
                        right = false;
                        left = false;
                        MessageBox.Show("You need a key to open this door.");
                    }
                }
            }

            if (pbPlayer.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                gameOver("You have been crushed by the great FINKI. GAME OVER!");
            }

            if (pbPlayer.Bounds.IntersectsWith(lava.Bounds))
            {
                gameOver("You tried to swim in lava, dont do that next time!");
            }

            if (pbPlayer.Bounds.IntersectsWith(key.Bounds))
            {
                key.Visible = false;
                hasKey = true;
            }

            /*foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string) x.Tag == "coins")
                {
                    if (pbPlayer.Right > x.Left && pbPlayer.Left < pbPlayer.Right && pbPlayer.Top < x.Bottom && pbPlayer.Bottom > x.Top && x.Visible == true)
                    {
                        x.Visible = false;
                        scoreCounter += 1;
                    }
                }
            }*/

            if (enemyGoingLeft)
            {
                if (enemyOne.Location.X > enemyOnePlatform.Location.X+5)
                {
                    enemyOne.Left -= enemySpeed;
                }

                else
                {
                    enemyGoingLeft = !enemyGoingLeft;
                }

            }
            else if (!enemyGoingLeft)
            {
                if (enemyOne.Right < enemyOnePlatform.Right - 5)
                {
                    enemyOne.Left += enemySpeed;
                }
                else
                {
                    enemyGoingLeft = !enemyGoingLeft;
                }
            }

            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && (string)x.Tag == "platform")
                {


                    if (right && pbPlayer.Right >= x.Left - 10 && pbPlayer.Right <= x.Left + 10 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 13 && pbPlayer.Location.Y < x.Bottom)
                    {

                        rightWallHit = true;
                    }

                    if (left && pbPlayer.Left >= x.Right - 3 && pbPlayer.Left <= x.Right + 3 && pbPlayer.Location.Y + pbPlayer.Height > x.Top + 3 && pbPlayer.Location.Y < x.Bottom)
                    {


                        leftWallHit = true;
                    }

                    if (up)
                    {

                        if (pbPlayer.Location.Y > x.Location.Y + x.Height - 13 && pbPlayer.Location.Y < x.Location.Y + x.Height + 13 && pbPlayer.Location.X + pbPlayer.Width >= x.Location.X && pbPlayer.Location.X < x.Location.X + x.Width)
                        {
                            gravity = -5;
                            up = true;

                        }
                        if (gravity <= 0 && pbPlayer.Bottom >= x.Top - 5 && pbPlayer.Bottom <= x.Top + 15 && pbPlayer.Location.X + pbPlayer.Width >= x.Location.X && pbPlayer.Location.X <= x.Location.X + x.Width)
                        {
                            pbPlayer.Top = x.Location.Y - pbPlayer.Height;
                            up = false;
                            gravity = jumpHeight;


                        }
                    }
                    else
                    {

                        if (pbPlayer.Bottom >= x.Top - 5 && pbPlayer.Bottom <= x.Top + 5 && ((left && pbPlayer.Location.X + pbPlayer.Width <= x.Location.X) || (right && pbPlayer.Location.X > x.Location.X + x.Width)))
                        {
                            up = true;
                            gravity = 0;

                        }


                    }


                    if (leftWallHit)
                    {
                        leftWallHit = false;
                        pbPlayer.Left = x.Right + 3;
                    }
                    if (rightWallHit)
                    {
                        rightWallHit = false;
                        pbPlayer.Left = x.Left - pbPlayer.Width - 3;
                    }
                    x.BringToFront();
                }
            }
        }
    }
}