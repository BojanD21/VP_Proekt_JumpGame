namespace ProjectJump_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.enemyOnePlatform = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.movingBlockY = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbDoor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.movingBlockX = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.enemyOne = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lava = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.enemyOnePlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingBlockY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingBlockX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // platform1
            // 
<<<<<<< HEAD
            this.platform1.BackColor = System.Drawing.Color.Transparent;
            this.platform1.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform1.Location = new System.Drawing.Point(160, 523);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(125, 34);
            this.platform1.TabIndex = 9;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
=======
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.pictureBox8.Location = new System.Drawing.Point(160, 523);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(125, 34);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
>>>>>>> origin/master
            // 
            // enemyOnePlatform
            // 
            this.enemyOnePlatform.BackColor = System.Drawing.Color.Transparent;
            this.enemyOnePlatform.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.enemyOnePlatform.Location = new System.Drawing.Point(349, 410);
            this.enemyOnePlatform.Name = "enemyOnePlatform";
            this.enemyOnePlatform.Size = new System.Drawing.Size(282, 40);
            this.enemyOnePlatform.TabIndex = 10;
            this.enemyOnePlatform.TabStop = false;
            this.enemyOnePlatform.Tag = "platform";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.pictureBox6.Location = new System.Drawing.Point(186, 173);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "platform";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.pictureBox5.Location = new System.Drawing.Point(32, 77);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(125, 34);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "platform";
            // 
            // movingBlockY
            // 
            this.movingBlockY.BackColor = System.Drawing.Color.Transparent;
            this.movingBlockY.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.movingBlockY.Location = new System.Drawing.Point(1310, 410);
            this.movingBlockY.Name = "movingBlockY";
            this.movingBlockY.Size = new System.Drawing.Size(125, 35);
            this.movingBlockY.TabIndex = 13;
            this.movingBlockY.TabStop = false;
            this.movingBlockY.Tag = "platform";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ProjectJump_.Properties.Resources.platform;
<<<<<<< HEAD
            this.pictureBox3.Location = new System.Drawing.Point(732, 436);
=======
            this.pictureBox3.Location = new System.Drawing.Point(705, 410);
>>>>>>> origin/master
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "platform";
            // 
            // pbDoor
            // 
            this.pbDoor.BackColor = System.Drawing.Color.Wheat;
            this.pbDoor.Image = global::ProjectJump_.Properties.Resources.door2;
            this.pbDoor.Location = new System.Drawing.Point(1395, 34);
            this.pbDoor.Name = "pbDoor";
            this.pbDoor.Size = new System.Drawing.Size(75, 100);
            this.pbDoor.TabIndex = 8;
            this.pbDoor.TabStop = false;
            this.pbDoor.Tag = "door";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.pictureBox1.Location = new System.Drawing.Point(1345, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 34);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::ProjectJump_.Properties.Resources.characterRight;
            this.pbPlayer.Location = new System.Drawing.Point(32, 575);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(40, 60);
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Transparent;
            this.floor.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.floor.Location = new System.Drawing.Point(-23, 635);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(247, 62);
            this.floor.TabIndex = 5;
            this.floor.TabStop = false;
            this.floor.Tag = "platform";
            // 
            // background
            // 
            this.background.Image = global::ProjectJump_.Properties.Resources.realBg;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(1489, 660);
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            this.background.Tag = "player";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Image = global::ProjectJump_.Properties.Resources.key1;
            this.key.Location = new System.Drawing.Point(32, 26);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(50, 50);
            this.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key.TabIndex = 18;
            this.key.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.pictureBox10.Location = new System.Drawing.Point(1131, 495);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(125, 34);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // movingBlockX
            // 
            this.movingBlockX.BackColor = System.Drawing.Color.Transparent;
            this.movingBlockX.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.movingBlockX.Location = new System.Drawing.Point(960, 173);
            this.movingBlockX.Name = "movingBlockX";
            this.movingBlockX.Size = new System.Drawing.Size(125, 34);
            this.movingBlockX.TabIndex = 15;
            this.movingBlockX.TabStop = false;
            this.movingBlockX.Tag = "platform";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.pictureBox14.Location = new System.Drawing.Point(1143, 225);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(125, 34);
            this.pictureBox14.TabIndex = 15;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "platform";
            // 
            // enemyOne
            // 
            this.enemyOne.BackColor = System.Drawing.Color.Transparent;
            this.enemyOne.Image = global::ProjectJump_.Properties.Resources.finkiLogo;
            this.enemyOne.Location = new System.Drawing.Point(581, 361);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(50, 50);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyOne.TabIndex = 19;
            this.enemyOne.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
<<<<<<< HEAD
            this.lblScore.Location = new System.Drawing.Point(0, 0);
=======
            this.lblScore.Location = new System.Drawing.Point(2, 0);
>>>>>>> origin/master
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 28);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "Time: 0";
            // 
            // lava
            // 
            this.lava.Image = ((System.Drawing.Image)(resources.GetObject("lava.Image")));
            this.lava.Location = new System.Drawing.Point(222, 635);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(1267, 62);
            this.lava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lava.TabIndex = 21;
            this.lava.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.pictureBox11.Location = new System.Drawing.Point(720, 67);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(32, 100);
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "platform";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.pictureBox12.Location = new System.Drawing.Point(570, 134);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(32, 33);
            this.pictureBox12.TabIndex = 9;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "platform";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.pictureBox15.Location = new System.Drawing.Point(426, 108);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(32, 59);
            this.pictureBox15.TabIndex = 9;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "platform";
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox16.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.pictureBox16.Location = new System.Drawing.Point(861, 362);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(40, 40);
            this.pictureBox16.TabIndex = 14;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "platform";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.pictureBox2.Location = new System.Drawing.Point(993, 451);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "platform";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.pictureBox4.Location = new System.Drawing.Point(869, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 59);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lava);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
<<<<<<< HEAD
            this.Controls.Add(this.platform1);
=======
            this.Controls.Add(this.pictureBox8);
>>>>>>> origin/master
            this.Controls.Add(this.enemyOnePlatform);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.movingBlockY);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.movingBlockX);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbDoor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOnePlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingBlockY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movingBlockX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox platform1;
        private PictureBox enemyOnePlatform;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox movingBlockY;
        private PictureBox pictureBox3;
        private PictureBox pbDoor;
        private PictureBox pictureBox1;
        private PictureBox pbPlayer;
        private PictureBox floor;
        private PictureBox background;
        private PictureBox key;
        private PictureBox pictureBox10;
        private PictureBox movingBlockX;
        private PictureBox pictureBox14;
        private PictureBox enemyOne;
        private Label lblScore;
        private PictureBox lava;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}