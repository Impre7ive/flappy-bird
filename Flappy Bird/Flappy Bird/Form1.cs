using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird {
    public partial class Form1 : Form {
        private int SceneSpeed = 3;
        private int gravity = 5;
        private int score = 0;
        private Queue<PictureBox> groundClones = new Queue<PictureBox>();
        public Form1() {
            InitializeComponent();
            InitMenuGround();
        }

        private void gameTimerEvent(object sender, EventArgs e) {
            /*  flappyBird.Top += gravity;
              pipeBottom.Left -= pipeSpeed;
              pipeTop.Left -= pipeSpeed;

              if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                  flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                  flappyBird.Bounds.IntersectsWith(ground.Bounds)) {
                  EndGame();
              }
              if (pipeBottom.Left < -100) {
                  pipeBottom.Left = 550;
                  pipeTop.Left = 550;
                  score++;
                  scoreValue.Text = "Score: " + score;
              }*/

            MainMenuGroundMove();

        }

        private void MainMenuGroundMove() {
            foreach (PictureBox pic in groundClones) {
                pic.Left -= SceneSpeed;
            }

            pipeBottom.Left -= SceneSpeed;
            pipeTop.Left -= SceneSpeed;

            if (pipeTop.Left < -pipeTop.Width) {
                pipeBottom.Left = MainMenuPanel.Width + pipeTop.Width;
                pipeTop.Left = MainMenuPanel.Width + pipeTop.Width;
            }

            if ((groundClones.Peek()).Left < -mainMenuGround.Width) {
                PictureBox tmp = groundClones.Dequeue();
                tmp.Left += 3*tmp.Width-10;
                groundClones.Enqueue(tmp);
            }
        }

        private void InitMenuGround() {
            for (int i = 0; i <= 2; ++i) {
                PictureBox tmp = new PictureBox();
                tmp.Image = global::Flappy_Bird.Properties.Resources.ground;
                
                if(i == 0) tmp.Location = new System.Drawing.Point(0, 476);
                else if (i == 1) tmp.Location = new System.Drawing.Point(mainMenuGround.Width, 476);
                else tmp.Location = new System.Drawing.Point(2 * mainMenuGround.Width, 476);
                
                tmp.Size = new Size(337, 101);
                tmp.SizeMode = PictureBoxSizeMode.StretchImage;
                groundClones.Enqueue(tmp);
                MainMenuPanel.Controls.Add(tmp);
            }

            pipeTop.SendToBack();
            pipeBottom.SendToBack();
            gameNameLabel.SendToBack();
        }

        private void gameKeyDown(object sender, KeyEventArgs e) {
           // if (e.KeyCode == Keys.Space) {
                //gravity -= 10;
          //  }
        }

        private void gameKeyUp(object sender, KeyEventArgs e) {
           // if (e.KeyCode == Keys.Space) {
           //     gravity = 5;
           // }
        }

        private void EndGame() {
            //gameTimer.Stop();
           // gameOverPanel.Visible = true;
        }

        private void gameOverScore_Click(object sender, EventArgs e) {

        }

        private void continueButton_Click(object sender, EventArgs e) {
           // gameTimer.Start();
           // gameOverPanel.Visible = false;
        }
    }
}
