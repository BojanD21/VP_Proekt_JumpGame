namespace ProjectJump_
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Interval = 20;
            timer1.Start();
        }

        public bool up = false;
        public bool right = false;
        public bool down = false;
        public bool left = false;
        public bool isFalling = false;
        public bool onThisPlatform = false;
        public bool grounded = false;

        public bool moveOtherSide = true;
        public bool moveOtherSideVertical = true;

        public bool rightWallHit = false;
        public bool leftWallHit = false;

        public int playerSpeed = 10;
        public int jumpHeight = 25;
        public int gravity = 0;
        public int fallingSpeed = 0;

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (moveOtherSide) {
                if (movingBlockX.Right <= 530)
                {
                    if (pbPlayer.Right >= movingBlockX.Left && pbPlayer.Left <= movingBlockX.Right && pbPlayer.Bottom == movingBlockX.Top)
                    {
                        pbPlayer.Left += playerSpeed;
                    }
                    movingBlockX.Left += playerSpeed;
                }

                if(movingBlockX.Right == 530)
                {
                    moveOtherSide = !moveOtherSide;
                }

            }

            else if (!moveOtherSide)
            {
                if(movingBlockX.Left > 0)
                {
                    movingBlockX.Left -= playerSpeed - 6;
                    if (pbPlayer.Right >= movingBlockX.Left && pbPlayer.Left <= movingBlockX.Right && pbPlayer.Bottom == movingBlockX.Top)
                    {
                        pbPlayer.Left -= playerSpeed;
                    }
                }

                if(movingBlockX.Left > -15 && movingBlockX.Left < 0)
                {
                    moveOtherSide = !moveOtherSide;
                }

            }

            if (moveOtherSideVertical)
            {
                if (movingBlockY.Top > 212)
                {

                    movingBlockY.Top -= playerSpeed - 6;
                }
                else { moveOtherSideVertical = !moveOtherSideVertical; }
                
                    
                
            }
            else if (!moveOtherSideVertical)
            {
                movingBlockY.Top += playerSpeed - 6;
                if(movingBlockY.Top == 380)
                {
                    moveOtherSideVertical = !moveOtherSideVertical;
                }
            }
*/


            if (right && pbPlayer.Right <= this.ClientSize.Width)
            {
                pbPlayer.Left += playerSpeed;
            }
            if (left && pbPlayer.Left >= 0)
            {
                pbPlayer.Left -= playerSpeed;
            }

            if (up)
            {
                pbPlayer.Top -= gravity;
                gravity -= 3;
                if (gravity < -10)
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
                //25, 548
                pbPlayer.Left = 25;
                pbPlayer.Top = 548;
                right = false;
                left = false;
                MessageBox.Show("Congratulations!!! You won.");
                timer1.Stop();
                timer1.Start();
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
                        if (gravity <= 0 && pbPlayer.Bottom >= x.Top - 5 && pbPlayer.Bottom <= x.Top + 5 && pbPlayer.Location.X + pbPlayer.Width >= x.Location.X && pbPlayer.Location.X <= x.Location.X + x.Width)
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