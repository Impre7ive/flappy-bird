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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.mainMenuGround = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.MainMenuPanel.Controls.Add(this.panel1);
            this.MainMenuPanel.Controls.Add(this.startGameButton);
            this.MainMenuPanel.Controls.Add(this.mainMenuGround);
            this.MainMenuPanel.Controls.Add(this.pipeTop);
            this.MainMenuPanel.Controls.Add(this.pipeBottom);
            this.MainMenuPanel.Controls.Add(this.gameNameLabel);
            this.MainMenuPanel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 1);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(531, 578);
            this.MainMenuPanel.TabIndex = 0;
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Location = new System.Drawing.Point(0, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 585);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(531, 577);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            this.MainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.PictureBox mainMenuGround;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Panel panel1;
    }
}

