namespace VPFinkiBirdProekt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grounds = new System.Windows.Forms.PictureBox();
            this.FinkiBird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinkiBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeTop
            // 
            this.pipeTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeTop.BackgroundImage")));
            this.pipeTop.ErrorImage = null;
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(445, -166);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(106, 335);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 1;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pipeBottom.BackgroundImage")));
            this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
            this.pipeBottom.Location = new System.Drawing.Point(402, 358);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(107, 331);
            this.pipeBottom.TabIndex = 2;
            this.pipeBottom.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(215)))), ((int)(((byte)(152)))));
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 572);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(115, 31);
            this.ScoreLabel.TabIndex = 5;
            this.ScoreLabel.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // grounds
            // 
            this.grounds.Image = ((System.Drawing.Image)(resources.GetObject("grounds.Image")));
            this.grounds.Location = new System.Drawing.Point(0, 536);
            this.grounds.Name = "grounds";
            this.grounds.Size = new System.Drawing.Size(578, 77);
            this.grounds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grounds.TabIndex = 3;
            this.grounds.TabStop = false;
            // 
            // FinkiBird
            // 
            this.FinkiBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FinkiBird.BackgroundImage")));
            this.FinkiBird.Location = new System.Drawing.Point(36, 234);
            this.FinkiBird.Name = "FinkiBird";
            this.FinkiBird.Size = new System.Drawing.Size(80, 80);
            this.FinkiBird.TabIndex = 0;
            this.FinkiBird.TabStop = false;
            this.FinkiBird.Click += new System.EventHandler(this.FinkiBird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(575, 612);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.grounds);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.FinkiBird);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finki Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinkiBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox grounds;
        private System.Windows.Forms.PictureBox FinkiBird;
    }
}

