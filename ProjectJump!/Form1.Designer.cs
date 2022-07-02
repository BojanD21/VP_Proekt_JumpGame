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
            this.skyPlatform3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.platform7 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.pbDoor = new System.Windows.Forms.PictureBox();
            this.skyDoorPlatform = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.key = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.skyPlatform2 = new System.Windows.Forms.PictureBox();
            this.skyPlatform1 = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lava = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyOnePlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyDoorPlatform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // platform1
            // 
            this.platform1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.platform1.BackColor = System.Drawing.Color.Transparent;
            this.platform1.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform1.Location = new System.Drawing.Point(160, 523);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(125, 34);
            this.platform1.TabIndex = 9;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
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
            // skyPlatform3
            // 
            this.skyPlatform3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.skyPlatform3.BackColor = System.Drawing.Color.Transparent;
            this.skyPlatform3.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.skyPlatform3.Location = new System.Drawing.Point(199, 173);
            this.skyPlatform3.Name = "skyPlatform3";
            this.skyPlatform3.Size = new System.Drawing.Size(40, 40);
            this.skyPlatform3.TabIndex = 11;
            this.skyPlatform3.TabStop = false;
            this.skyPlatform3.Tag = "platform";
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
            // platform7
            // 
            this.platform7.BackColor = System.Drawing.Color.Transparent;
            this.platform7.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform7.Location = new System.Drawing.Point(1308, 415);
            this.platform7.Name = "platform7";
            this.platform7.Size = new System.Drawing.Size(125, 35);
            this.platform7.TabIndex = 13;
            this.platform7.TabStop = false;
            this.platform7.Tag = "platform";
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.Transparent;
            this.platform3.Image = global::ProjectJump_.Properties.Resources.platform;
            this.platform3.Location = new System.Drawing.Point(732, 441);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(40, 40);
            this.platform3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.platform3.TabIndex = 14;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
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
            // skyDoorPlatform
            // 
            this.skyDoorPlatform.BackColor = System.Drawing.Color.Transparent;
            this.skyDoorPlatform.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.skyDoorPlatform.Location = new System.Drawing.Point(1345, 133);
            this.skyDoorPlatform.Name = "skyDoorPlatform";
            this.skyDoorPlatform.Size = new System.Drawing.Size(125, 34);
            this.skyDoorPlatform.TabIndex = 7;
            this.skyDoorPlatform.TabStop = false;
            this.skyDoorPlatform.Tag = "platform";
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayer.Image = global::ProjectJump_.Properties.Resources.characterRight;
            this.pbPlayer.Location = new System.Drawing.Point(40, 575);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(40, 60);
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
            // 
            // floor
            // 
            this.floor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.background.Tag = "";
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
            // platform6
            // 
            this.platform6.BackColor = System.Drawing.Color.Transparent;
            this.platform6.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform6.Location = new System.Drawing.Point(1131, 495);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(125, 34);
            this.platform6.TabIndex = 11;
            this.platform6.TabStop = false;
            this.platform6.Tag = "platform";
            // 
            // skyPlatform2
            // 
            this.skyPlatform2.BackColor = System.Drawing.Color.Transparent;
            this.skyPlatform2.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.skyPlatform2.Location = new System.Drawing.Point(960, 173);
            this.skyPlatform2.Name = "skyPlatform2";
            this.skyPlatform2.Size = new System.Drawing.Size(125, 34);
            this.skyPlatform2.TabIndex = 15;
            this.skyPlatform2.TabStop = false;
            this.skyPlatform2.Tag = "platform";
            // 
            // skyPlatform1
            // 
            this.skyPlatform1.BackColor = System.Drawing.Color.Transparent;
            this.skyPlatform1.BackgroundImage = global::ProjectJump_.Properties.Resources.platformInTheSky;
            this.skyPlatform1.Location = new System.Drawing.Point(1143, 225);
            this.skyPlatform1.Name = "skyPlatform1";
            this.skyPlatform1.Size = new System.Drawing.Size(125, 34);
            this.skyPlatform1.TabIndex = 15;
            this.skyPlatform1.TabStop = false;
            this.skyPlatform1.Tag = "platform";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = global::ProjectJump_.Properties.Resources.finkiLogo;
            this.enemy.Location = new System.Drawing.Point(581, 361);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(50, 50);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 19;
            this.enemy.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Source Serif Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(0, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(80, 28);
            this.lblScore.TabIndex = 20;
            this.lblScore.Text = "Time: 0";
            // 
            // lava
            // 
            this.lava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lava.Image = ((System.Drawing.Image)(resources.GetObject("lava.Image")));
            this.lava.Location = new System.Drawing.Point(222, 635);
            this.lava.Name = "lava";
            this.lava.Size = new System.Drawing.Size(1267, 62);
            this.lava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lava.TabIndex = 21;
            this.lava.TabStop = false;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Transparent;
            this.wall2.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.wall2.Location = new System.Drawing.Point(720, 67);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(32, 100);
            this.wall2.TabIndex = 9;
            this.wall2.TabStop = false;
            this.wall2.Tag = "platform";
            // 
            // wall3
            // 
            this.wall3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wall3.BackColor = System.Drawing.Color.Transparent;
            this.wall3.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.wall3.Location = new System.Drawing.Point(570, 134);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(32, 33);
            this.wall3.TabIndex = 9;
            this.wall3.TabStop = false;
            this.wall3.Tag = "platform";
            // 
            // wall4
            // 
            this.wall4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.wall4.BackColor = System.Drawing.Color.Transparent;
            this.wall4.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.wall4.Location = new System.Drawing.Point(426, 108);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(32, 59);
            this.wall4.TabIndex = 9;
            this.wall4.TabStop = false;
            this.wall4.Tag = "platform";
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.Transparent;
            this.platform4.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform4.Location = new System.Drawing.Point(861, 362);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(40, 40);
            this.platform4.TabIndex = 14;
            this.platform4.TabStop = false;
            this.platform4.Tag = "platform";
            // 
            // platform5
            // 
            this.platform5.BackColor = System.Drawing.Color.Transparent;
            this.platform5.BackgroundImage = global::ProjectJump_.Properties.Resources.platform;
            this.platform5.Location = new System.Drawing.Point(993, 451);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(40, 40);
            this.platform5.TabIndex = 14;
            this.platform5.TabStop = false;
            this.platform5.Tag = "platform";
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Transparent;
            this.wall1.BackgroundImage = global::ProjectJump_.Properties.Resources.wall;
            this.wall1.Location = new System.Drawing.Point(869, 108);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(32, 59);
            this.wall1.TabIndex = 22;
            this.wall1.TabStop = false;
            this.wall1.Tag = "platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.lava);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.key);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.enemyOnePlatform);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.skyPlatform3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.platform7);
            this.Controls.Add(this.skyPlatform1);
            this.Controls.Add(this.skyPlatform2);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.pbDoor);
            this.Controls.Add(this.skyDoorPlatform);
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
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyDoorPlatform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skyPlatform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private PictureBox platform1;
        private PictureBox enemyOnePlatform;
        private PictureBox skyPlatform3;
        private PictureBox pictureBox5;
        private PictureBox platform7;
        private PictureBox platform3;
        private PictureBox pbDoor;
        private PictureBox skyDoorPlatform;
        private PictureBox pbPlayer;
        private PictureBox floor;
        private PictureBox background;
        private PictureBox key;
        private PictureBox platform6;
        private PictureBox skyPlatform2;
        private PictureBox skyPlatform1;
        private PictureBox enemy;
        private Label lblScore;
        private PictureBox lava;
        private PictureBox wall2;
        private PictureBox wall3;
        private PictureBox wall4;
        private PictureBox platform4;
        private PictureBox platform5;
        private PictureBox wall1;
    }
}