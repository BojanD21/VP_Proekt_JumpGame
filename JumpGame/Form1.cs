namespace JumpGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Start();
        }
        
        public bool left, right, jump = false;
        public int moveSpeed = 10;
        public int jumpHeight = 20;
        public int force = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }

            if (e.KeyCode == Keys.Up && !jump)
            {
                jump = true;
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
            if (jump)
            {
                jump = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpHeight;

            if (right)
            {
                if (player.Right <= 778)
                    player.Left += moveSpeed;
            }
            if (left)
            {
                if (player.Left > 0)
                    player.Left -= moveSpeed;
            }

            if (jump && force < 0)
            {
                jump = false;
            }

            if (jump)
            {
                jumpHeight = -20;
                force -= 1;
            }
            else
            {
                jumpHeight = 20;
            }

            if (player.Bounds.IntersectsWith(floor.Bounds) && !jump)
            {
                force = 10;
                player.Top = floor.Top - player.Height;
            }


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {

                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = 10;
                        player.Top = x.Top - player.Height;
                    }
                }
            }
        }
    }
}