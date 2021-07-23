namespace Flappy_Bird {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.startGameButton = new System.Windows.Forms.Button();
            this.mainMenuGround = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameScore = new System.Windows.Forms.Label();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.restartGameButton = new System.Windows.Forms.Button();
            this.gameScoreMenu = new System.Windows.Forms.Label();
            this.gameScoreMenuText = new System.Windows.Forms.Label();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.gamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainMenuPanel.Controls.Add(this.startGameButton);
            this.mainMenuPanel.Controls.Add(this.mainMenuGround);
            this.mainMenuPanel.Controls.Add(this.pipeTop);
            this.mainMenuPanel.Controls.Add(this.pipeBottom);
            this.mainMenuPanel.Controls.Add(this.gameNameLabel);
            this.mainMenuPanel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(531, 578);
            this.mainMenuPanel.TabIndex = 0;
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.startGameButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.startGameButton.FlatAppearance.BorderSize = 0;
            this.startGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.startGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.Location = new System.Drawing.Point(188, 349);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startGameButton.Size = new System.Drawing.Size(156, 92);
            this.startGameButton.TabIndex = 4;
            this.startGameButton.Text = "▶";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // mainMenuGround
            // 
            this.mainMenuGround.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.mainMenuGround.Location = new System.Drawing.Point(0, 477);
            this.mainMenuGround.Name = "mainMenuGround";
            this.mainMenuGround.Size = new System.Drawing.Size(332, 101);
            this.mainMenuGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainMenuGround.TabIndex = 0;
            this.mainMenuGround.TabStop = false;
            this.mainMenuGround.Visible = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(327, -112);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(73, 253);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(327, 330);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(73, 248);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameNameLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.Green;
            this.gameNameLabel.Location = new System.Drawing.Point(0, 0);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(531, 578);
            this.gameNameLabel.TabIndex = 3;
            this.gameNameLabel.Text = "Flappy Bird";
            this.gameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.PaleGreen;
            this.gamePanel.Controls.Add(this.gameScore);
            this.gamePanel.Controls.Add(this.flappyBird);
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(531, 578);
            this.gamePanel.TabIndex = 5;
            this.gamePanel.Visible = false;
            // 
            // gameScore
            // 
            this.gameScore.AutoSize = true;
            this.gameScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameScore.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.gameScore.Location = new System.Drawing.Point(12, 543);
            this.gameScore.Name = "gameScore";
            this.gameScore.Size = new System.Drawing.Size(92, 25);
            this.gameScore.TabIndex = 1;
            this.gameScore.Text = "Score: 0";
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(188, 239);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(60, 47);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            this.flappyBird.Visible = false;
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Yellow;
            this.gameOverPanel.Controls.Add(this.restartGameButton);
            this.gameOverPanel.Controls.Add(this.gameScoreMenu);
            this.gameOverPanel.Controls.Add(this.gameScoreMenuText);
            this.gameOverPanel.Location = new System.Drawing.Point(0, 0);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(531, 578);
            this.gameOverPanel.TabIndex = 2;
            this.gameOverPanel.Visible = false;
            // 
            // restartGameButton
            // 
            this.restartGameButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.restartGameButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.restartGameButton.FlatAppearance.BorderSize = 0;
            this.restartGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restartGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartGameButton.Location = new System.Drawing.Point(188, 349);
            this.restartGameButton.Name = "restartGameButton";
            this.restartGameButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.restartGameButton.Size = new System.Drawing.Size(156, 92);
            this.restartGameButton.TabIndex = 5;
            this.restartGameButton.Text = "▶";
            this.restartGameButton.UseVisualStyleBackColor = false;
            this.restartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // gameScoreMenu
            // 
            this.gameScoreMenu.AutoSize = true;
            this.gameScoreMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameScoreMenu.Location = new System.Drawing.Point(231, 245);
            this.gameScoreMenu.Name = "gameScoreMenu";
            this.gameScoreMenu.Size = new System.Drawing.Size(68, 73);
            this.gameScoreMenu.TabIndex = 1;
            this.gameScoreMenu.Text = "0";
            // 
            // gameScoreMenuText
            // 
            this.gameScoreMenuText.AutoSize = true;
            this.gameScoreMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameScoreMenuText.Location = new System.Drawing.Point(130, 158);
            this.gameScoreMenuText.Name = "gameScoreMenuText";
            this.gameScoreMenuText.Size = new System.Drawing.Size(270, 55);
            this.gameScoreMenuText.TabIndex = 0;
            this.gameScoreMenuText.Text = "Your score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(531, 577);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.mainMenuPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.PictureBox mainMenuGround;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label gameScore;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label gameScoreMenu;
        private System.Windows.Forms.Label gameScoreMenuText;
        private System.Windows.Forms.Button restartGameButton;
    }
}

