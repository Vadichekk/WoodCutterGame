using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodCutterGame
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 500;
        int speed = 7;
        int satiety = 20;
        Random randNum = new Random();
        int score;
        List<PictureBox> treesList = new List<PictureBox>();
        int size;

        public Form1()
        {
            InitializeComponent();
            LabelLose.Visible = false;
            LabelStart.Visible = false;
            LabelScore.Visible = false;
            LabelExit.Visible = false;
            LabelTutorial.Visible = true;
            RestartGame();
        }
        
        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.D7L;
                GameTimer.Stop();
                LabelLose.Visible = true;
                LabelStart.Visible = true;
                LabelScore.Visible = true;
                LabelExit.Visible = true;
            }

            if (playerHealth > 550)
            {
                playerHealth -= 20;
            }

            txtSatiety.Text = "Satiety: " + satiety;
            txtScore.Text = "Score: " + score;
            LabelScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goUp == true && player.Top > 45)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "satiety")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
//                       satiety += 10;
                        satiety = randNum.Next(10,20);
                        playerHealth += 25;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "tree")
                {
 //                  if (player.Bounds.IntersectsWith(x.Bounds))
 //                  {
 //                      playerHealth -= 1;
 //                  }

                    if (x.Left > player.Left)
                    {
                        ((PictureBox)x).Image = Properties.Resources.B4;
                    } 
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "tree")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;
                            playerHealth += 10;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            treesList.Remove(((PictureBox)x));
                            MakeTrees();
                        }                       
                    }

                    
                }
            }
        }
        
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            size = 70;

            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Left)
            {
                playerHealth -= 1;
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.R1L;              
//                player.Image = Properties.Resources.R2L;
//                player.Image = Properties.Resources.R3L;
//                player.Image = Properties.Resources.R4L;
//                player.Image = Properties.Resources.R5L;
//                player.Image = Properties.Resources.R6L;
//                player.Image = Properties.Resources.R7L;
//                player.Image = Properties.Resources.R8L;
            }

            else
            {
                playerHealth -= 1;
                goLeft = false;                
                player.Image = Properties.Resources.R1;
//                player.Image = Properties.Resources.I2L;
//                player.Image = Properties.Resources.I3L;
//                player.Image = Properties.Resources.I4L;
//                player.Image = Properties.Resources.I5L;
            }

            if (e.KeyCode == Keys.Right)
            {
                playerHealth -= 1;
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.I1;
//                player.Image = Properties.Resources.R2;
//                player.Image = Properties.Resources.R3;
//                player.Image = Properties.Resources.R4;
//                player.Image = Properties.Resources.R5;
//                player.Image = Properties.Resources.R6;
//                player.Image = Properties.Resources.R7;
 //               player.Image = Properties.Resources.R8;
            }

            else
            {
                playerHealth -= 1;
                goRight = false;
                player.Image = Properties.Resources.I1L;
//                player.Image = Properties.Resources.I2;
//                player.Image = Properties.Resources.I3;
//                player.Image = Properties.Resources.I4;
 //               player.Image = Properties.Resources.I5;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.D1;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.D1L;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && satiety > 0 && gameOver == false)
            {
                satiety--;
                ShootBullet(facing);
                player.Image = Properties.Resources.F3;

                if (satiety < 1)
                {
                    DropSatiety();
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {                
                RestartGame();
            }
                        
            if (e.KeyCode == Keys.Enter && gameOver == false)
            {
                LabelTutorial.Visible = false;
                GameTimer.Start();
            }
        }
        
        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);

        }

        private void MakeTrees()
        {
            PictureBox tree = new PictureBox();
            tree.Tag = "tree";
            tree.Image = Properties.Resources.B4;
            tree.Left = randNum.Next(100, this.ClientSize.Width - tree.Width - 100);
            tree.Top = randNum.Next(100, this.ClientSize.Height - tree.Height - 100);
            tree.SizeMode = PictureBoxSizeMode.AutoSize;
            treesList.Add(tree);
            this.Controls.Add(tree);
            tree.SendToBack();
            player.BringToFront();  
        }

        private void DropSatiety()
        {
            PictureBox satiety = new PictureBox();
            satiety.Image = Properties.Resources.ammo_Image;
            satiety.SizeMode = PictureBoxSizeMode.AutoSize;
            satiety.Left = randNum.Next(100, this.ClientSize.Width - satiety.Width);
            satiety.Top = randNum.Next(100, this.ClientSize.Height - satiety.Height);
            satiety.Tag = "satiety";
            this.Controls.Add(satiety);

            satiety.BringToFront();
            player.BringToFront();
        }

        private void RestartGame()
        {
            player.Image = Properties.Resources.I1;

            foreach (PictureBox i in treesList)
            {
                this.Controls.Remove(i);
            }

            treesList.Clear();

            for (int i = 0; i < 5; i++)
            {
                MakeTrees();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 500;
            score = 0;
            satiety = 20;
            LabelLose.Visible = false;
            LabelStart.Visible = false;
            LabelScore.Visible = false;
            LabelExit.Visible = false;

            GameTimer.Start();
        }      
    }
}
