namespace WoodCutterGame
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
            this.txtSatiety = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.LabelLose = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.LabelStart = new System.Windows.Forms.Label();
            this.LabelTutorial = new System.Windows.Forms.Label();
            this.LabelExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSatiety
            // 
            this.txtSatiety.AutoSize = true;
            this.txtSatiety.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatiety.ForeColor = System.Drawing.Color.Black;
            this.txtSatiety.Location = new System.Drawing.Point(30, 14);
            this.txtSatiety.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSatiety.Name = "txtSatiety";
            this.txtSatiety.Size = new System.Drawing.Size(301, 39);
            this.txtSatiety.TabIndex = 0;
            this.txtSatiety.Text = "Satiety: 0";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(484, 14);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(228, 39);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(834, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stamina: ";
            // 
            // healthBar
            // 
            this.healthBar.ForeColor = System.Drawing.Color.Red;
            this.healthBar.Location = new System.Drawing.Point(1119, 18);
            this.healthBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.healthBar.Maximum = 600;
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(297, 35);
            this.healthBar.TabIndex = 1;
            this.healthBar.Value = 500;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::WoodCutterGame.Properties.Resources.D1;
            this.player.Location = new System.Drawing.Point(750, 550);
            this.player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(24, 19);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // LabelLose
            // 
            this.LabelLose.AutoSize = true;
            this.LabelLose.BackColor = System.Drawing.Color.Red;
            this.LabelLose.Font = new System.Drawing.Font("Goudy Stout", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLose.ForeColor = System.Drawing.Color.Black;
            this.LabelLose.Location = new System.Drawing.Point(515, 210);
            this.LabelLose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLose.Name = "LabelLose";
            this.LabelLose.Size = new System.Drawing.Size(468, 55);
            this.LabelLose.TabIndex = 0;
            this.LabelLose.Text = "Game Over";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Red;
            this.LabelScore.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScore.ForeColor = System.Drawing.Color.Black;
            this.LabelScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelScore.Location = new System.Drawing.Point(585, 285);
            this.LabelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(326, 50);
            this.LabelScore.TabIndex = 0;
            this.LabelScore.Text = "Srore: 0 ";
            // 
            // LabelStart
            // 
            this.LabelStart.AutoSize = true;
            this.LabelStart.BackColor = System.Drawing.Color.Red;
            this.LabelStart.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelStart.ForeColor = System.Drawing.Color.Black;
            this.LabelStart.Location = new System.Drawing.Point(475, 350);
            this.LabelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(549, 39);
            this.LabelStart.TabIndex = 0;
            this.LabelStart.Text = "Нажмите ENTER что бы начать сначала";
            // 
            // LabelTutorial
            // 
            this.LabelTutorial.AutoSize = true;
            this.LabelTutorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LabelTutorial.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTutorial.ForeColor = System.Drawing.Color.Black;
            this.LabelTutorial.Location = new System.Drawing.Point(65, 130);
            this.LabelTutorial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTutorial.Name = "LabelTutorial";
            this.LabelTutorial.Size = new System.Drawing.Size(1366, 348);
            this.LabelTutorial.TabIndex = 0;
            this.LabelTutorial.Text = resources.GetString("LabelTutorial.Text");
            this.LabelTutorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelExit
            // 
            this.LabelExit.AutoSize = true;
            this.LabelExit.BackColor = System.Drawing.Color.Red;
            this.LabelExit.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExit.ForeColor = System.Drawing.Color.Black;
            this.LabelExit.Location = new System.Drawing.Point(475, 425);
            this.LabelExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelExit.Name = "LabelExit";
            this.LabelExit.Size = new System.Drawing.Size(558, 39);
            this.LabelExit.TabIndex = 0;
            this.LabelExit.Text = "Нажмите ESCAPE что бы выйти из игры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.LabelTutorial);
            this.Controls.Add(this.LabelExit);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.LabelLose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtSatiety);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WoodCutterGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtSatiety;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelLose;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label LabelStart;
        private System.Windows.Forms.Label LabelTutorial;
        private System.Windows.Forms.Label LabelExit;
    }
}

