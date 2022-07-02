namespace ProjectJump_
{
    partial class DontPlayAgain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNoDontPlay = new System.Windows.Forms.Button();
            this.btnYesDontPlay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNoDontPlay
            // 
            this.btnNoDontPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnNoDontPlay.Location = new System.Drawing.Point(221, 194);
            this.btnNoDontPlay.Name = "btnNoDontPlay";
            this.btnNoDontPlay.Size = new System.Drawing.Size(94, 29);
            this.btnNoDontPlay.TabIndex = 4;
            this.btnNoDontPlay.Text = "No";
            this.btnNoDontPlay.UseVisualStyleBackColor = false;
            this.btnNoDontPlay.Click += new System.EventHandler(this.btnNoDontPlay_Click);
            // 
            // btnYesDontPlay
            // 
            this.btnYesDontPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnYesDontPlay.Location = new System.Drawing.Point(17, 194);
            this.btnYesDontPlay.Name = "btnYesDontPlay";
            this.btnYesDontPlay.Size = new System.Drawing.Size(94, 29);
            this.btnYesDontPlay.TabIndex = 5;
            this.btnYesDontPlay.Text = "Yes!";
            this.btnYesDontPlay.UseVisualStyleBackColor = false;
            this.btnYesDontPlay.Click += new System.EventHandler(this.btnYesDontPlay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "You lost the game!\r\nDo you want to continue playing?\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(107, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Game over!";
            // 
            // DontPlayAgain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjectJump_.Properties.Resources.playAgainFormBG_FAILED;
            this.ClientSize = new System.Drawing.Size(332, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNoDontPlay);
            this.Controls.Add(this.btnYesDontPlay);
            this.Controls.Add(this.label2);
            this.Name = "DontPlayAgain";
            this.Text = "Game lost!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNoDontPlay;
        private Button btnYesDontPlay;
        private Label label2;
        private Label label1;
    }
}