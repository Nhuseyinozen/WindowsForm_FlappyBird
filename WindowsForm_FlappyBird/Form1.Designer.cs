namespace WindowsForm_FlappyBird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.grouınd = new System.Windows.Forms.PictureBox();
            this.pipleDown = new System.Windows.Forms.PictureBox();
            this.pipleTop = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouınd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipleDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipleTop)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(34, 206);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(100, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // grouınd
            // 
            this.grouınd.Image = ((System.Drawing.Image)(resources.GetObject("grouınd.Image")));
            this.grouınd.Location = new System.Drawing.Point(-9, 429);
            this.grouınd.Name = "grouınd";
            this.grouınd.Size = new System.Drawing.Size(800, 73);
            this.grouınd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grouınd.TabIndex = 1;
            this.grouınd.TabStop = false;
            // 
            // pipleDown
            // 
            this.pipleDown.Image = ((System.Drawing.Image)(resources.GetObject("pipleDown.Image")));
            this.pipleDown.Location = new System.Drawing.Point(569, 267);
            this.pipleDown.Name = "pipleDown";
            this.pipleDown.Size = new System.Drawing.Size(77, 167);
            this.pipleDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipleDown.TabIndex = 2;
            this.pipleDown.TabStop = false;
            // 
            // pipleTop
            // 
            this.pipleTop.Image = ((System.Drawing.Image)(resources.GetObject("pipleTop.Image")));
            this.pipleTop.Location = new System.Drawing.Point(569, -3);
            this.pipleTop.Name = "pipleTop";
            this.pipleTop.Size = new System.Drawing.Size(77, 117);
            this.pipleTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipleTop.TabIndex = 3;
            this.pipleTop.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE :";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.Honeydew;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scorelbl.Location = new System.Drawing.Point(191, 447);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(36, 39);
            this.scorelbl.TabIndex = 5;
            this.scorelbl.Text = "0";
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.BackColor = System.Drawing.Color.Snow;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOver.Location = new System.Drawing.Point(379, 447);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(240, 39);
            this.gameOver.TabIndex = 6;
            this.gameOver.Text = "FLAPPY BİRD";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(717, 495);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pipleTop);
            this.Controls.Add(this.pipleDown);
            this.Controls.Add(this.grouınd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grouınd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipleDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipleTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox grouınd;
        private System.Windows.Forms.PictureBox pipleDown;
        private System.Windows.Forms.PictureBox pipleTop;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label gameOver;
    }
}

