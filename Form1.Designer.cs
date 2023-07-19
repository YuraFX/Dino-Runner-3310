﻿//  Foobar is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Foobar is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Foobar.  If not, see <http://www.gnu.org/licenses/>.

namespace Dino_Runner_3310
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
            this.ground = new System.Windows.Forms.PictureBox();
            this.dino = new System.Windows.Forms.PictureBox();
            this.sky = new System.Windows.Forms.PictureBox();
            this.sky2 = new System.Windows.Forms.PictureBox();
            this.skyTimer1 = new System.Windows.Forms.Timer(this.components);
            this.skyTimer2 = new System.Windows.Forms.Timer(this.components);
            this.cactus = new System.Windows.Forms.PictureBox();
            this.cactusTimer1 = new System.Windows.Forms.Timer(this.components);
            this.cactusTimer2 = new System.Windows.Forms.Timer(this.components);
            this.dinoJump = new System.Windows.Forms.Label();
            this.dinoJumpTimer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.PictureBox();
            this.gameLoading = new System.Windows.Forms.PictureBox();
            this.gameLoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.ngDark = new System.Windows.Forms.PictureBox();
            this.agDark = new System.Windows.Forms.PictureBox();
            this.qgDark = new System.Windows.Forms.PictureBox();
            this.option1 = new System.Windows.Forms.PictureBox();
            this.option2 = new System.Windows.Forms.PictureBox();
            this.option3 = new System.Windows.Forms.PictureBox();
            this.ngLight = new System.Windows.Forms.PictureBox();
            this.agLight = new System.Windows.Forms.PictureBox();
            this.qgLight = new System.Windows.Forms.PictureBox();
            this.NgToAg = new System.Windows.Forms.Timer(this.components);
            this.QgToAg = new System.Windows.Forms.Timer(this.components);
            this.ag = new System.Windows.Forms.PictureBox();
            this.secretGround = new System.Windows.Forms.PictureBox();
            this.secretDino = new System.Windows.Forms.PictureBox();
            this.sDinoTimer1 = new System.Windows.Forms.Timer(this.components);
            this.sDinoTimer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qgDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qgLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretDino)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Location = new System.Drawing.Point(0, 147);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(336, 48);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.Color.Transparent;
            this.dino.Location = new System.Drawing.Point(80, 104);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(40, 43);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dino.TabIndex = 1;
            this.dino.TabStop = false;
            // 
            // sky
            // 
            this.sky.BackColor = System.Drawing.Color.Transparent;
            this.sky.Location = new System.Drawing.Point(290, 14);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(41, 13);
            this.sky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sky.TabIndex = 2;
            this.sky.TabStop = false;
            // 
            // sky2
            // 
            this.sky2.BackColor = System.Drawing.Color.Transparent;
            this.sky2.Location = new System.Drawing.Point(180, 33);
            this.sky2.Name = "sky2";
            this.sky2.Size = new System.Drawing.Size(41, 13);
            this.sky2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sky2.TabIndex = 3;
            this.sky2.TabStop = false;
            // 
            // skyTimer1
            // 
            this.skyTimer1.Interval = 300;
            this.skyTimer1.Tick += new System.EventHandler(this.skyTimer1_Tick);
            // 
            // skyTimer2
            // 
            this.skyTimer2.Interval = 200;
            this.skyTimer2.Tick += new System.EventHandler(this.skyTimer2_Tick);
            // 
            // cactus
            // 
            this.cactus.BackColor = System.Drawing.Color.Transparent;
            this.cactus.Location = new System.Drawing.Point(260, 114);
            this.cactus.Name = "cactus";
            this.cactus.Size = new System.Drawing.Size(32, 33);
            this.cactus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cactus.TabIndex = 4;
            this.cactus.TabStop = false;
            // 
            // cactusTimer1
            // 
            this.cactusTimer1.Interval = 3000;
            this.cactusTimer1.Tick += new System.EventHandler(this.cactusTimer1_Tick);
            // 
            // cactusTimer2
            // 
            this.cactusTimer2.Interval = 150;
            this.cactusTimer2.Tick += new System.EventHandler(this.cactusTimer2_Tick);
            // 
            // dinoJump
            // 
            this.dinoJump.AutoSize = true;
            this.dinoJump.BackColor = System.Drawing.Color.Transparent;
            this.dinoJump.ForeColor = System.Drawing.Color.White;
            this.dinoJump.Location = new System.Drawing.Point(4, 4);
            this.dinoJump.Name = "dinoJump";
            this.dinoJump.Size = new System.Drawing.Size(52, 13);
            this.dinoJump.TabIndex = 5;
            this.dinoJump.Text = "dinoJump";
            this.dinoJump.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.dinoJump.Visible = false;
            // 
            // dinoJumpTimer
            // 
            this.dinoJumpTimer.Interval = 700;
            this.dinoJumpTimer.Tick += new System.EventHandler(this.dinoJumpTimer_Tick);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.score.ForeColor = System.Drawing.Color.White;
            this.score.Location = new System.Drawing.Point(12, 160);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(312, 23);
            this.score.TabIndex = 6;
            this.score.Text = "score";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.Location = new System.Drawing.Point(52, 66);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(233, 24);
            this.restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.restart.TabIndex = 7;
            this.restart.TabStop = false;
            this.restart.Visible = false;
            // 
            // gameLoading
            // 
            this.gameLoading.Location = new System.Drawing.Point(0, 0);
            this.gameLoading.Name = "gameLoading";
            this.gameLoading.Size = new System.Drawing.Size(336, 192);
            this.gameLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gameLoading.TabIndex = 8;
            this.gameLoading.TabStop = false;
            // 
            // gameLoadingTimer
            // 
            this.gameLoadingTimer.Enabled = true;
            this.gameLoadingTimer.Interval = 2500;
            this.gameLoadingTimer.Tick += new System.EventHandler(this.gameLoadingTimer_Tick);
            // 
            // ngDark
            // 
            this.ngDark.BackColor = System.Drawing.Color.Transparent;
            this.ngDark.Location = new System.Drawing.Point(12, 12);
            this.ngDark.Name = "ngDark";
            this.ngDark.Size = new System.Drawing.Size(132, 19);
            this.ngDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ngDark.TabIndex = 9;
            this.ngDark.TabStop = false;
            this.ngDark.Visible = false;
            // 
            // agDark
            // 
            this.agDark.BackColor = System.Drawing.Color.Transparent;
            this.agDark.Location = new System.Drawing.Point(12, 42);
            this.agDark.Name = "agDark";
            this.agDark.Size = new System.Drawing.Size(152, 19);
            this.agDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agDark.TabIndex = 10;
            this.agDark.TabStop = false;
            this.agDark.Visible = false;
            // 
            // qgDark
            // 
            this.qgDark.BackColor = System.Drawing.Color.Transparent;
            this.qgDark.Location = new System.Drawing.Point(12, 72);
            this.qgDark.Name = "qgDark";
            this.qgDark.Size = new System.Drawing.Size(134, 19);
            this.qgDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.qgDark.TabIndex = 11;
            this.qgDark.TabStop = false;
            this.qgDark.Visible = false;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.Black;
            this.option1.Location = new System.Drawing.Point(0, 11);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(336, 23);
            this.option1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.option1.TabIndex = 12;
            this.option1.TabStop = false;
            this.option1.Visible = false;
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.Black;
            this.option2.Location = new System.Drawing.Point(0, 40);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(336, 23);
            this.option2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.option2.TabIndex = 13;
            this.option2.TabStop = false;
            this.option2.Visible = false;
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.Black;
            this.option3.Location = new System.Drawing.Point(0, 69);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(336, 23);
            this.option3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.option3.TabIndex = 14;
            this.option3.TabStop = false;
            this.option3.Visible = false;
            // 
            // ngLight
            // 
            this.ngLight.BackColor = System.Drawing.Color.Transparent;
            this.ngLight.Location = new System.Drawing.Point(12, 12);
            this.ngLight.Name = "ngLight";
            this.ngLight.Size = new System.Drawing.Size(132, 19);
            this.ngLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ngLight.TabIndex = 15;
            this.ngLight.TabStop = false;
            this.ngLight.Visible = false;
            // 
            // agLight
            // 
            this.agLight.BackColor = System.Drawing.Color.Transparent;
            this.agLight.Location = new System.Drawing.Point(12, 42);
            this.agLight.Name = "agLight";
            this.agLight.Size = new System.Drawing.Size(152, 19);
            this.agLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.agLight.TabIndex = 16;
            this.agLight.TabStop = false;
            this.agLight.Visible = false;
            // 
            // qgLight
            // 
            this.qgLight.BackColor = System.Drawing.Color.Transparent;
            this.qgLight.Location = new System.Drawing.Point(12, 72);
            this.qgLight.Name = "qgLight";
            this.qgLight.Size = new System.Drawing.Size(134, 19);
            this.qgLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.qgLight.TabIndex = 17;
            this.qgLight.TabStop = false;
            this.qgLight.Visible = false;
            // 
            // NgToAg
            // 
            this.NgToAg.Tick += new System.EventHandler(this.NgToAg_Tick);
            // 
            // QgToAg
            // 
            this.QgToAg.Tick += new System.EventHandler(this.QgToAg_Tick);
            // 
            // ag
            // 
            this.ag.Location = new System.Drawing.Point(0, 0);
            this.ag.Name = "ag";
            this.ag.Size = new System.Drawing.Size(336, 192);
            this.ag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ag.TabIndex = 18;
            this.ag.TabStop = false;
            this.ag.Visible = false;
            // 
            // secretGround
            // 
            this.secretGround.Enabled = false;
            this.secretGround.Location = new System.Drawing.Point(0, 147);
            this.secretGround.Name = "secretGround";
            this.secretGround.Size = new System.Drawing.Size(336, 48);
            this.secretGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secretGround.TabIndex = 19;
            this.secretGround.TabStop = false;
            this.secretGround.Visible = false;
            // 
            // secretDino
            // 
            this.secretDino.BackColor = System.Drawing.Color.Transparent;
            this.secretDino.Enabled = false;
            this.secretDino.Location = new System.Drawing.Point(145, 104);
            this.secretDino.Name = "secretDino";
            this.secretDino.Size = new System.Drawing.Size(40, 43);
            this.secretDino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.secretDino.TabIndex = 20;
            this.secretDino.TabStop = false;
            this.secretDino.Visible = false;
            this.secretDino.Click += new System.EventHandler(this.secretDino_Click);
            // 
            // sDinoTimer1
            // 
            this.sDinoTimer1.Interval = 200;
            this.sDinoTimer1.Tick += new System.EventHandler(this.sDinoTimer1_Tick);
            // 
            // sDinoTimer2
            // 
            this.sDinoTimer2.Interval = 200;
            this.sDinoTimer2.Tick += new System.EventHandler(this.sDinoTimer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(336, 192);
            this.Controls.Add(this.secretDino);
            this.Controls.Add(this.secretGround);
            this.Controls.Add(this.ag);
            this.Controls.Add(this.qgLight);
            this.Controls.Add(this.agLight);
            this.Controls.Add(this.ngLight);
            this.Controls.Add(this.ngDark);
            this.Controls.Add(this.agDark);
            this.Controls.Add(this.qgDark);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.score);
            this.Controls.Add(this.sky2);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.cactus);
            this.Controls.Add(this.dinoJump);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.gameLoading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dino Runner 3310 1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cactus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qgDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.option3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qgLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretDino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox sky;
        private System.Windows.Forms.PictureBox sky2;
        private System.Windows.Forms.Timer skyTimer1;
        private System.Windows.Forms.Timer skyTimer2;
        private System.Windows.Forms.PictureBox cactus;
        private System.Windows.Forms.Timer cactusTimer1;
        private System.Windows.Forms.Timer cactusTimer2;
        private System.Windows.Forms.Label dinoJump;
        private System.Windows.Forms.Timer dinoJumpTimer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox restart;
        private System.Windows.Forms.PictureBox gameLoading;
        private System.Windows.Forms.Timer gameLoadingTimer;
        private System.Windows.Forms.PictureBox ngDark;
        private System.Windows.Forms.PictureBox agDark;
        private System.Windows.Forms.PictureBox qgDark;
        private System.Windows.Forms.PictureBox option1;
        private System.Windows.Forms.PictureBox option2;
        private System.Windows.Forms.PictureBox option3;
        private System.Windows.Forms.PictureBox ngLight;
        private System.Windows.Forms.PictureBox agLight;
        private System.Windows.Forms.PictureBox qgLight;
        private System.Windows.Forms.Timer NgToAg;
        private System.Windows.Forms.Timer QgToAg;
        private System.Windows.Forms.PictureBox ag;
        private System.Windows.Forms.PictureBox secretGround;
        private System.Windows.Forms.PictureBox secretDino;
        private System.Windows.Forms.Timer sDinoTimer1;
        private System.Windows.Forms.Timer sDinoTimer2;
    }
}

