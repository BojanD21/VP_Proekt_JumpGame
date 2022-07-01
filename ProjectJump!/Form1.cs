namespace ProjectJump_
{

    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Jump!";

            background.BackColor = Color.Transparent;
            pbPlayer.Parent = background;
            enemyOne.Parent = background;
            key.Parent = background;
            lblScore.Parent = background;

            pbPlayer.Height = 60;
            pbPlayer.Width = 40;
            pbPlayer.Left = 40;
            pbPlayer.Top = 575;

            background.Dock = DockStyle.Fill;
            background.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            background.SizeMode = PictureBoxSizeMode.StretchImage;


            floor.MinimumSize = new Size(247, 62);
            floor.MaximumSize = new Size(247, 1500);

            floor.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            lava.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;


            setSizes(platform1, 125, 34);
            setSizes(enemyOnePlatform, 282, 40);
            setSizes(platform3, 40, 40);
            setSizes(platform4, 40, 40);
            setSizes(platform5, 40, 40);
            setSizes(platform6, 125, 34);
            setSizes(platform7, 125, 35);

            setSizes(skyPlatform1, 125, 34);
            setSizes(skyPlatform2, 125, 34);
            setSizes(skyPlatform3, 40, 40);
            setSizes(skyDoorPlatform, 125, 34);

            setSizes(wall1, 32, 59);
            setSizes(wall2, 32, 100);
            setSizes(wall3, 32, 33);
            setSizes(wall4, 32, 59);
        }

        public void setSizes(Control x, int width, int height)
        {
            x.MaximumSize = new Size(width, height);
            //x.MinimumSize = new Size(width, height);
            x.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
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
        public bool upIsDown = false;

        public int playerSpeed = 6;
        public int jumpHeight = 25;
        public int gravity = 0;
        public int fallingSpeed = 0;
        public int enemySpeed = 6;
        public int scoreCounter = 0;
        public int time = 0;

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
                    upIsDown = true;

                    gravity = jumpHeight;
                    grounded = false;
                }
            }

            if(up == true)
            {
                if(e.KeyCode == Keys.Up)
                {
                    upIsDown = true;
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
            if(e.KeyCode == Keys.Up)
            {
                upIsDown = false;
            }
        }

        public void gameOver(String str)
        {
            timer1.Stop();
            upIsDown = false;
            pbPlayer.Left = floor.Left + 50;
            pbPlayer.Top = floor.Top - pbPlayer.Height - 20;
            right = false;
            left = false;
            MessageBox.Show(str);
            hasKey = false;
            shownNoKeyMessage = true;
            key.Visible = true;
            enemyOne.Left = 580;
            pbPlayer.Left = 40;
            pbPlayer.Top = 575;
            scoreCounter = 0;
            time = 0; 
            lblScore.Text = "Time: " + time;
            gravity = 0;
            timer1.Start();
            up = true;
        }

        public void gameWon()
        {
            timer1.Stop();
            upIsDown = false;
            pbPlayer.Left = floor.Left + 50;
            pbPlayer.Top = floor.Top - pbPlayer.Height - 20;
            right = false;
            left = false;
            MessageBox.Show("Congratulations!!! You won in " + time + " seconds.");
            hasKey = false;
            shownNoKeyMessage = true;
            key.Visible = true;
            enemyOne.Left = 580;
            pbPlayer.Left = 40;
            pbPlayer.Top = 575;
            scoreCounter = 0;
            time = 0;
            lblScore.Text = "Time: " + time;
            gravity = 0;
            timer1.Start();
            up = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            scoreCounter += 1;
            if(scoreCounter == 50)
            {
                scoreCounter = 0;
                time++;
                lblScore.Text = "Time: " + time;
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

            if (moveOtherSide)
            {
                if (skyPlatform2.Right >= wall4.Left)
                {

                    if (pbPlayer.Right >= skyPlatform2.Left && pbPlayer.Left <= skyPlatform2.Right && pbPlayer.Bottom == skyPlatform2.Top)
                    {
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
                        pbPlayer.Left -= playerSpeed;
                    }
                    skyPlatform2.Left -= playerSpeed;
                }
                else
                {
                    moveOtherSide = !moveOtherSide;
                }

            }
            else if (!moveOtherSide)
            {
                if (skyPlatform2.Right <= wall4.Left) { skyPlatform2.Left += playerSpeed; }
                if (skyPlatform2.Right >= wall4.Left)
                {

                    if (pbPlayer.Right >= skyPlatform2.Left && pbPlayer.Left <= skyPlatform2.Right && pbPlayer.Bottom == skyPlatform2.Top)
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
                        pbPlayer.Left += playerSpeed;
                    }
                    skyPlatform2.Left += playerSpeed;
                }

                if (skyPlatform2.Right >= skyPlatform1.Left)
                {
                    moveOtherSide = !moveOtherSide;
                }

            }

            if (moveOtherSideVertical)
            {
                if (platform7.Top >= skyPlatform1.Bottom)
                {
                    if (pbPlayer.Bottom == platform7.Top && pbPlayer.Right > platform7.Left && pbPlayer.Left < platform7.Right)
                    {
                        pbPlayer.Top -= playerSpeed;
                    }
                    platform7.Top -= playerSpeed;

                }
                else { moveOtherSideVertical = !moveOtherSideVertical; }
            }
            else if (!moveOtherSideVertical)
            {
                if (pbPlayer.Bottom == platform7.Top && pbPlayer.Right > platform7.Left && pbPlayer.Left < platform7.Right)
                {
                    pbPlayer.Top += playerSpeed;
                }
                platform7.Top += playerSpeed;

                if (platform7.Bottom >= platform5.Top)
                {
                    moveOtherSideVertical = !moveOtherSideVertical;
                }
            }

            if (enemyGoingLeft)
            {
                if (enemyOne.Location.X > enemyOnePlatform.Location.X + 5)
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
                    if (leftWallHit)
                    {
                        leftWallHit = false;
                        pbPlayer.Left = x.Right + 6;
                    }
                    if (rightWallHit)
                    {
                        rightWallHit = false;
                        pbPlayer.Left = x.Left - pbPlayer.Width - 6;
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
                            pbPlayer.Top = x.Top - pbPlayer.Height;

                            up = false;
                            gravity = jumpHeight;
                            if (upIsDown)
                            {
                                up = true;
                            }

                            break;
                        }
                    }
                    else
                    {
                        if (pbPlayer.Bottom == x.Top && ((left && pbPlayer.Location.X + pbPlayer.Width <= x.Location.X) || (right && pbPlayer.Location.X > x.Location.X + x.Width)))
                        {
                            up = true;
                            gravity = 0;
                        }
                    }
                    x.BringToFront();
                }
            }
        }
    }
}