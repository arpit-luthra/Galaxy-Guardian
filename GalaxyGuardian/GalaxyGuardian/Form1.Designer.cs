namespace GalaxyGuardian
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picVenus = new System.Windows.Forms.PictureBox();
            this.picJupiter = new System.Windows.Forms.PictureBox();
            this.picSaturn = new System.Windows.Forms.PictureBox();
            this.picPluto = new System.Windows.Forms.PictureBox();
            this.picSpaceship = new System.Windows.Forms.PictureBox();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.lblInsText = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblConText = new System.Windows.Forms.Label();
            this.tmrExplosion = new System.Windows.Forms.Timer(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLives = new System.Windows.Forms.Label();
            this.tmrHeart = new System.Windows.Forms.Timer(this.components);
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPauseResume = new System.Windows.Forms.Label();
            this.lblPauseRestart = new System.Windows.Forms.Label();
            this.lblPauseExit = new System.Windows.Forms.Label();
            this.lblPauseTitle = new System.Windows.Forms.Label();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblFinalLevel = new System.Windows.Forms.Label();
            this.lblFinalScore = new System.Windows.Forms.Label();
            this.lblGameOverExit = new System.Windows.Forms.Label();
            this.lblGameOverRestart = new System.Windows.Forms.Label();
            this.lblGameOverTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJupiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPluto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceship)).BeginInit();
            this.pnlInstructions.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlPause.SuspendLayout();
            this.pnlGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(529, 73);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Galaxy Guardian";
            // 
            // picVenus
            // 
            this.picVenus.BackColor = System.Drawing.Color.Transparent;
            this.picVenus.Image = global::GalaxyGuardian.Properties.Resources.Venus;
            this.picVenus.Location = new System.Drawing.Point(73, 106);
            this.picVenus.Name = "picVenus";
            this.picVenus.Size = new System.Drawing.Size(107, 101);
            this.picVenus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVenus.TabIndex = 6;
            this.picVenus.TabStop = false;
            // 
            // picJupiter
            // 
            this.picJupiter.BackColor = System.Drawing.Color.Transparent;
            this.picJupiter.Image = global::GalaxyGuardian.Properties.Resources.Jupiter;
            this.picJupiter.Location = new System.Drawing.Point(27, 266);
            this.picJupiter.Name = "picJupiter";
            this.picJupiter.Size = new System.Drawing.Size(120, 103);
            this.picJupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJupiter.TabIndex = 7;
            this.picJupiter.TabStop = false;
            // 
            // picSaturn
            // 
            this.picSaturn.BackColor = System.Drawing.Color.Transparent;
            this.picSaturn.Image = global::GalaxyGuardian.Properties.Resources.Saturn;
            this.picSaturn.Location = new System.Drawing.Point(624, 111);
            this.picSaturn.Name = "picSaturn";
            this.picSaturn.Size = new System.Drawing.Size(155, 113);
            this.picSaturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaturn.TabIndex = 8;
            this.picSaturn.TabStop = false;
            // 
            // picPluto
            // 
            this.picPluto.BackColor = System.Drawing.Color.Transparent;
            this.picPluto.Image = global::GalaxyGuardian.Properties.Resources.Pluto;
            this.picPluto.Location = new System.Drawing.Point(651, 296);
            this.picPluto.Name = "picPluto";
            this.picPluto.Size = new System.Drawing.Size(128, 110);
            this.picPluto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPluto.TabIndex = 9;
            this.picPluto.TabStop = false;
            // 
            // picSpaceship
            // 
            this.picSpaceship.BackColor = System.Drawing.Color.Transparent;
            this.picSpaceship.Image = global::GalaxyGuardian.Properties.Resources.Space_ship;
            this.picSpaceship.Location = new System.Drawing.Point(373, 370);
            this.picSpaceship.Name = "picSpaceship";
            this.picSpaceship.Size = new System.Drawing.Size(43, 36);
            this.picSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceship.TabIndex = 11;
            this.picSpaceship.TabStop = false;
            this.picSpaceship.Visible = false;
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(184, 419);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(95, 25);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Score: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(340, 419);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(133, 32);
            this.lblTimer.TabIndex = 13;
            this.lblTimer.Text = "Time: 0s";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.SystemColors.Control;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(309, 144);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(81, 33);
            this.lblStart.TabIndex = 14;
            this.lblStart.Text = "Start";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Blue;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(252, 213);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(177, 33);
            this.lblInstructions.TabIndex = 15;
            this.lblInstructions.Text = "Instructions";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.SystemColors.Control;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.Location = new System.Drawing.Point(274, 281);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(132, 33);
            this.lblControls.TabIndex = 16;
            this.lblControls.Text = "Controls";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Blue;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(286, 347);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(68, 33);
            this.lblExit.TabIndex = 17;
            this.lblExit.Text = "Exit";
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.Red;
            this.pnlInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlInstructions.Controls.Add(this.lblInsText);
            this.pnlInstructions.Location = new System.Drawing.Point(435, 224);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(48, 22);
            this.pnlInstructions.TabIndex = 20;
            // 
            // lblInsText
            // 
            this.lblInsText.AutoSize = true;
            this.lblInsText.BackColor = System.Drawing.Color.Transparent;
            this.lblInsText.Font = new System.Drawing.Font("Tempus Sans ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsText.ForeColor = System.Drawing.Color.Black;
            this.lblInsText.Location = new System.Drawing.Point(14, 5);
            this.lblInsText.Name = "lblInsText";
            this.lblInsText.Size = new System.Drawing.Size(40, 27);
            this.lblInsText.TabIndex = 21;
            this.lblInsText.Text = "Ins";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlControls.Controls.Add(this.lblConText);
            this.pnlControls.Location = new System.Drawing.Point(415, 281);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(40, 27);
            this.pnlControls.TabIndex = 0;
            // 
            // lblConText
            // 
            this.lblConText.AutoSize = true;
            this.lblConText.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConText.Location = new System.Drawing.Point(5, 0);
            this.lblConText.Name = "lblConText";
            this.lblConText.Size = new System.Drawing.Size(60, 31);
            this.lblConText.TabIndex = 0;
            this.lblConText.Text = "Con";
            // 
            // tmrExplosion
            // 
            this.tmrExplosion.Interval = 500;
            this.tmrExplosion.Tick += new System.EventHandler(this.tmrExplosion_Tick);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLevel.Location = new System.Drawing.Point(664, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(76, 25);
            this.lblLevel.TabIndex = 21;
            this.lblLevel.Text = "Level";
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLives.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLives.Location = new System.Drawing.Point(665, 48);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(100, 25);
            this.lblLives.TabIndex = 22;
            this.lblLives.Text = "Lives: 0";
            // 
            // tmrHeart
            // 
            this.tmrHeart.Interval = 3000;
            this.tmrHeart.Tick += new System.EventHandler(this.tmrHeart_Tick);
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlPause.Controls.Add(this.lblPauseResume);
            this.pnlPause.Controls.Add(this.lblPauseRestart);
            this.pnlPause.Controls.Add(this.lblPauseExit);
            this.pnlPause.Controls.Add(this.lblPauseTitle);
            this.pnlPause.Location = new System.Drawing.Point(443, 170);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(30, 23);
            this.pnlPause.TabIndex = 23;
            this.pnlPause.Visible = false;
            // 
            // lblPauseResume
            // 
            this.lblPauseResume.AutoSize = true;
            this.lblPauseResume.BackColor = System.Drawing.Color.White;
            this.lblPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseResume.Location = new System.Drawing.Point(15, 57);
            this.lblPauseResume.Name = "lblPauseResume";
            this.lblPauseResume.Size = new System.Drawing.Size(119, 33);
            this.lblPauseResume.TabIndex = 3;
            this.lblPauseResume.Text = "resume";
            // 
            // lblPauseRestart
            // 
            this.lblPauseRestart.AutoSize = true;
            this.lblPauseRestart.BackColor = System.Drawing.Color.Blue;
            this.lblPauseRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseRestart.Location = new System.Drawing.Point(18, 41);
            this.lblPauseRestart.Name = "lblPauseRestart";
            this.lblPauseRestart.Size = new System.Drawing.Size(105, 33);
            this.lblPauseRestart.TabIndex = 2;
            this.lblPauseRestart.Text = "restart";
            // 
            // lblPauseExit
            // 
            this.lblPauseExit.AutoSize = true;
            this.lblPauseExit.BackColor = System.Drawing.Color.White;
            this.lblPauseExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseExit.Location = new System.Drawing.Point(18, 21);
            this.lblPauseExit.Name = "lblPauseExit";
            this.lblPauseExit.Size = new System.Drawing.Size(67, 33);
            this.lblPauseExit.TabIndex = 1;
            this.lblPauseExit.Text = "Esc";
            // 
            // lblPauseTitle
            // 
            this.lblPauseTitle.AutoSize = true;
            this.lblPauseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseTitle.ForeColor = System.Drawing.Color.Red;
            this.lblPauseTitle.Location = new System.Drawing.Point(11, 9);
            this.lblPauseTitle.Name = "lblPauseTitle";
            this.lblPauseTitle.Size = new System.Drawing.Size(158, 73);
            this.lblPauseTitle.TabIndex = 0;
            this.lblPauseTitle.Text = "Title";
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlGameOver.Controls.Add(this.lblFinalLevel);
            this.pnlGameOver.Controls.Add(this.lblFinalScore);
            this.pnlGameOver.Controls.Add(this.lblGameOverExit);
            this.pnlGameOver.Controls.Add(this.lblGameOverRestart);
            this.pnlGameOver.Controls.Add(this.lblGameOverTitle);
            this.pnlGameOver.Location = new System.Drawing.Point(467, 296);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(219, 110);
            this.pnlGameOver.TabIndex = 24;
            this.pnlGameOver.Visible = false;
            // 
            // lblFinalLevel
            // 
            this.lblFinalLevel.AutoSize = true;
            this.lblFinalLevel.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalLevel.Location = new System.Drawing.Point(80, 5);
            this.lblFinalLevel.Name = "lblFinalLevel";
            this.lblFinalLevel.Size = new System.Drawing.Size(134, 25);
            this.lblFinalLevel.TabIndex = 26;
            this.lblFinalLevel.Text = "final level";
            // 
            // lblFinalScore
            // 
            this.lblFinalScore.AutoSize = true;
            this.lblFinalScore.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalScore.Location = new System.Drawing.Point(19, 8);
            this.lblFinalScore.Name = "lblFinalScore";
            this.lblFinalScore.Size = new System.Drawing.Size(139, 25);
            this.lblFinalScore.TabIndex = 25;
            this.lblFinalScore.Text = "final score";
            // 
            // lblGameOverExit
            // 
            this.lblGameOverExit.AutoSize = true;
            this.lblGameOverExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameOverExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverExit.Location = new System.Drawing.Point(23, 38);
            this.lblGameOverExit.Name = "lblGameOverExit";
            this.lblGameOverExit.Size = new System.Drawing.Size(65, 33);
            this.lblGameOverExit.TabIndex = 2;
            this.lblGameOverExit.Text = "exit";
            // 
            // lblGameOverRestart
            // 
            this.lblGameOverRestart.AutoSize = true;
            this.lblGameOverRestart.BackColor = System.Drawing.Color.Blue;
            this.lblGameOverRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverRestart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameOverRestart.Location = new System.Drawing.Point(23, 21);
            this.lblGameOverRestart.Name = "lblGameOverRestart";
            this.lblGameOverRestart.Size = new System.Drawing.Size(105, 33);
            this.lblGameOverRestart.TabIndex = 1;
            this.lblGameOverRestart.Text = "restart";
            // 
            // lblGameOverTitle
            // 
            this.lblGameOverTitle.AutoSize = true;
            this.lblGameOverTitle.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverTitle.ForeColor = System.Drawing.Color.Red;
            this.lblGameOverTitle.Location = new System.Drawing.Point(20, 4);
            this.lblGameOverTitle.Name = "lblGameOverTitle";
            this.lblGameOverTitle.Size = new System.Drawing.Size(309, 119);
            this.lblGameOverTitle.TabIndex = 0;
            this.lblGameOverTitle.Text = "title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::GalaxyGuardian.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pnlInstructions);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.picVenus);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picJupiter);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picSpaceship);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picPluto);
            this.Controls.Add(this.picSaturn);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaxy Guardian";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJupiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPluto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceship)).EndInit();
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            this.pnlPause.PerformLayout();
            this.pnlGameOver.ResumeLayout(false);
            this.pnlGameOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picVenus;
        private System.Windows.Forms.PictureBox picJupiter;
        private System.Windows.Forms.PictureBox picSaturn;
        private System.Windows.Forms.PictureBox picPluto;
        private System.Windows.Forms.PictureBox picSpaceship;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblInsText;
        private System.Windows.Forms.Label lblConText;
        private System.Windows.Forms.Timer tmrExplosion;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Timer tmrHeart;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPauseResume;
        private System.Windows.Forms.Label lblPauseRestart;
        private System.Windows.Forms.Label lblPauseExit;
        private System.Windows.Forms.Label lblPauseTitle;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblGameOverTitle;
        private System.Windows.Forms.Label lblGameOverExit;
        private System.Windows.Forms.Label lblGameOverRestart;
        private System.Windows.Forms.Label lblFinalLevel;
        private System.Windows.Forms.Label lblFinalScore;
    }
}

