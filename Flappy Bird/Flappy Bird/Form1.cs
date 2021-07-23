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
        private bool passed = false;
        private int gravity = 3;
        private int score = 0;
        private bool isGameProcess = false;
        private Queue<PictureBox> groundClones = new Queue<PictureBox>();

        public Form1() {
            InitializeComponent();
            InitMenuGround();
        }

        private void GameTimerEvent(object sender, EventArgs e) {
            if (pipeBottom.Left < -100) {
                pipeBottom.Left = 550;
                pipeTop.Left = 550;
            }

            if (!isGameProcess)
                MainMenuGroundMove();
            else
                GameElementsMove();
        }

        private void MainMenuGroundMove() {
            foreach (PictureBox pic in groundClones) {
                pic.Left -= SceneSpeed;
            }

            pipeBottom.Left -= SceneSpeed;
            pipeTop.Left -= SceneSpeed;

            if (isGameProcess)
                flappyBird.Top += gravity;

            if (pipeTop.Left < -pipeTop.Width) {
                pipeBottom.Left = mainMenuPanel.Width + pipeTop.Width;
                pipeTop.Left = mainMenuPanel.Width + pipeTop.Width;
            }

            if ((groundClones.Peek()).Left < -mainMenuGround.Width) {
                PictureBox tmp = groundClones.Dequeue();
                tmp.Left += 3*tmp.Width-10;
                groundClones.Enqueue(tmp);
            }


        }
        private void GameElementsMove() {

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
            flappyBird.Bounds.IntersectsWith(pipeTop.Bounds)) {
                EndGame();
            }

            foreach (PictureBox ground in groundClones) {
                if (flappyBird.Bounds.IntersectsWith(ground.Bounds)) {
                    EndGame();
                }
            }


            foreach (PictureBox pic in groundClones) {
                pic.Left -= SceneSpeed;
            }

            pipeBottom.Left -= SceneSpeed;
            pipeTop.Left -= SceneSpeed;

            flappyBird.Top += gravity;

            //reset pipes
            if (pipeTop.Left < -pipeTop.Width) {
                pipeBottom.Left = mainMenuPanel.Width + pipeTop.Width;
                pipeTop.Left = mainMenuPanel.Width + pipeTop.Width;
                passed = false;
            }

            //set new score
            if (flappyBird.Left > pipeTop.Left) {
                if (!passed) {
                    score++;
                    gameScore.Text = "Score: " + score.ToString();
                }

                passed = true;
            }

            //replace start element next to the last
            if ((groundClones.Peek()).Left < -mainMenuGround.Width) {
                PictureBox tmp = groundClones.Dequeue();
                tmp.Left += 3 * tmp.Width - 10;
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
                mainMenuPanel.Controls.Add(tmp);
            }

            pipeTop.SendToBack();
            pipeBottom.SendToBack();
            gameNameLabel.SendToBack();
        }

        private void GameKeyDown(object sender, KeyEventArgs e) {
            
            if (e.KeyCode == Keys.Space) {

                if (!gameTimer.Enabled) {
                    gameTimer.Start();
                    isGameProcess = true;
                }
                    
               gravity = -10;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                gravity = 3;
               // flappyBird.Top += gravity;
            }
        }

        private void EndGame() {
            gameTimer.Stop();
            flappyBird.Visible = false;
            gamePanel.Visible = false;
            gameOverPanel.Visible = true;
            gameScoreMenu.Text = score.ToString();
        }

        private void StartGameButton_Click(object sender, EventArgs e) {
            gamePanel.Visible = true;
            mainMenuPanel.Visible = false;
            gameOverPanel.Visible = false;
            InitGameProcess();
        }

        private void InitGameProcess() {
            //setup tubes, ground, bird
            //setup pause

            score = 0;
            gameScore.Text = "Score: " + score.ToString();

            gameTimer.Stop();
            mainMenuPanel.Controls.Clear();

            foreach(var ground in groundClones)
                gamePanel.Controls.Add(ground);


            gamePanel.Controls.Add(flappyBird);
            gamePanel.Controls.Add(pipeTop);
            gamePanel.Controls.Add(pipeBottom);

            flappyBird.Visible = true;
            pipeTop.SendToBack();
            pipeBottom.SendToBack();

            pipeBottom.Left = 550;
            pipeTop.Left = 550;
            //Fix for situation when new panel begins visible the click events stop working
            //Form without focus isnt working
            Focus();
        }


    }
}
