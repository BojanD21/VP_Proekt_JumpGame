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

        public int playerSpeed = 10;
        public int jumpHeight = 25;
        public int gravity = 0;
        public int fallingSpeed = 0;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if(e.KeyCode == Keys.Right)
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


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (right)
            {
                if(pbPlayer.Right <= this.Width -22)
                    pbPlayer.Left += playerSpeed;
            }
            if (left)
            {
                if(pbPlayer.Left >= 0)
                    pbPlayer.Left -= playerSpeed;
            }
            
            if (up)
            {
                pbPlayer.Top -= gravity;
                gravity -= 3;
                
            }

            foreach (Control x in this.Controls)
            {
                
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (up)
                    {
                        if (pbPlayer.Location.Y > x.Location.Y + x.Height - 20 && pbPlayer.Location.Y < x.Location.Y + x.Height + 20 && pbPlayer.Location.X + pbPlayer.Width>=x.Location.X&&pbPlayer.Location.X<x.Location.X+x.Width)
                        {
                            gravity = -5;
                            up = true;
                        }
                         else if (gravity<0&&pbPlayer.Bottom >= x.Top - 20 && pbPlayer.Bottom <= x.Bottom + 20&&pbPlayer.Location.X+pbPlayer.Width>=x.Location.X&&pbPlayer.Location.X<=x.Location.X+x.Width)
                        {
                            pbPlayer.Top = x.Location.Y - pbPlayer.Height;
                            up = false;
                            gravity = jumpHeight;
                           
                            break;
                        }
                    }
                    else 
                    {
                        if (pbPlayer.Bottom >= x.Top - 20 && pbPlayer.Bottom <= x.Top && ((left && pbPlayer.Location.X+pbPlayer.Width  <= x.Location.X) || (right && pbPlayer.Location.X > x.Location.X + x.Width)))
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