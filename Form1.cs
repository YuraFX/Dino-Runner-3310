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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Dino_Runner_3310
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer startup;
        WindowsMediaPlayer jump;
        WindowsMediaPlayer scoreSound;
        WindowsMediaPlayer death;

        private Random random;

        int Score;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startup = new WindowsMediaPlayer();
            startup.URL = "resources\\sounds\\startup-sound.mp3";
            startup.settings.volume = 10;
            startup.controls.play();

            jump = new WindowsMediaPlayer();
            jump.URL = "resources\\sounds\\jump.mp3";
            jump.settings.volume = 10;
            jump.controls.stop();

            scoreSound = new WindowsMediaPlayer();
            scoreSound.URL = "resources\\sounds\\score.mp3";
            scoreSound.settings.volume = 10;
            scoreSound.controls.stop();

            death = new WindowsMediaPlayer();
            death.URL = "resources\\sounds\\death.mp3";
            death.settings.volume = 10;
            death.controls.stop();

            gameLoading.Image = Image.FromFile(@"resources\game-loading.png");

            option1.Image = Image.FromFile(@"resources\option.png");
            option2.Image = Image.FromFile(@"resources\option.png");
            option3.Image = Image.FromFile(@"resources\option.png");

            ngLight.BackgroundImage = Image.FromFile(@"resources\option.png");
            agLight.BackgroundImage = Image.FromFile(@"resources\option.png");
            qgLight.BackgroundImage = Image.FromFile(@"resources\option.png");

            ngLight.Image = Image.FromFile(@"resources\ng-light.png");
            agLight.Image = Image.FromFile(@"resources\ag-light.png");
            qgLight.Image = Image.FromFile(@"resources\qg-light.png");

            ngDark.Image = Image.FromFile(@"resources\ng-dark.png");
            agDark.Image = Image.FromFile(@"resources\ag-dark.png");
            qgDark.Image = Image.FromFile(@"resources\qg-dark.png");

            ag.Image = Image.FromFile(@"resources\ag.png");

            skyTimer1.Enabled = false;
            skyTimer2.Enabled = false;
            cactusTimer1.Enabled = false;
            cactusTimer2.Enabled = false;
            dinoJumpTimer.Enabled = false;

            this.BackgroundImage = Image.FromFile(@"resources\background.png");

            sky.Image = Image.FromFile(@"resources\sky.png");
            sky.Visible = false;
            sky2.Image = Image.FromFile(@"resources\sky.png");
            sky2.Visible = false;

            ground.Image = Image.FromFile(@"resources\ground.png");
            ground.Visible = false;

            cactus.Enabled = false;
            cactus.Visible = false;

            dino.Image = Image.FromFile(@"resources\dino.gif");
            dino.Visible = false;
            dinoJump.Text = "1";

            score.Text = "Score: 00";
            score.Visible = false;
            score.Image = Image.FromFile(@"resources\ground.png");

            Score = 0;

            restart.Image = Image.FromFile(@"resources\restart.png");
        }

        private void gameLoadingTimer_Tick(object sender, EventArgs e)
        {
            gameLoadingTimer.Enabled = false;
            gameLoading.Visible = false;

            option1.Visible = true;
            ngLight.Visible = true;

            agDark.Visible = true;
            qgDark.Visible = true;
        }

        private void skyTimer1_Tick(object sender, EventArgs e)
        {            
            skyTimer1.Enabled = false;
            skyTimer2.Enabled = true;

            sky.Visible = true;
            sky2.Visible = true;
        }

        private void skyTimer2_Tick(object sender, EventArgs e)
        {
            sky.Location = new Point(sky.Location.X - 30, sky.Location.Y);
            sky2.Location = new Point(sky2.Location.X - 30, sky2.Location.Y);

            if (sky.Location.X >= -70 && sky.Location.X <= -50)
            {
                sky.Location = new Point(290, 14);
            }

            if (sky2.Location.X >= -200 && sky2.Location.X <= -180)
            {
                sky2.Location = new Point(180, 33);
            }
        }

        private void cactusTimer1_Tick(object sender, EventArgs e)
        {
            cactus.Enabled = true;
            cactus.Visible = true;

            int randomX = random.Next(2);

            if (randomX == 0)
            {
                cactus.Image = Image.FromFile(@"resources\cactus-option1.png");
            }
            else
            {
                cactus.Image = Image.FromFile(@"resources\cactus-option2.png");
            }

            cactusTimer1.Enabled = false;
            cactusTimer2.Enabled = true;
        }

        private void cactusTimer2_Tick(object sender, EventArgs e)
        {
            cactus.Location = new Point(cactus.Location.X - 30, cactus.Location.Y);

            Intersect();

            if (cactus.Location.X >= -70 && cactus.Location.X <= -50)
            {
                cactus.Enabled = false;
                cactus.Visible = false;

                cactus.Location = new Point(215, 114);

                cactusTimer2.Enabled = false;
                cactusTimer1.Enabled = true;

                Score += 20;
                score.Text = "Score: " + ((Score < 10) ? "0" + Score.ToString() : Score.ToString());

                if (Score % 100 == 0 && Score > 0)
                {
                    scoreSound.controls.play();
                }
            }
        }

        private void Intersect()
        {
            if (dino.Bounds.IntersectsWith(cactus.Bounds))
            {
                cactus.Enabled = false;
                cactusTimer2.Enabled = false;

                skyTimer2.Enabled = false;

                dinoJump.Text = "1";

                dino.Image = Image.FromFile(@"resources\dino-death.png");
                death.controls.play();

                restart.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (ag.Visible == false)
                {
                    if (option1.Visible == true)
                    {
                        NgToAg.Enabled = true;
                    }

                    if (option2.Visible == true)
                    {
                        agLight.Visible = false;
                        agDark.Visible = true;

                        qgLight.Visible = true;
                        qgDark.Visible = false;

                        option2.Visible = false;
                        option3.Visible = true;
                    }
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (ag.Visible == false)
                {
                    if (option3.Visible == true)
                    {
                        QgToAg.Enabled = true;
                    }

                    if (option2.Visible == true)
                    {
                        ngLight.Visible = true;
                        ngDark.Visible = false;

                        agLight.Visible = false;
                        agDark.Visible = true;

                        option1.Visible = true;
                        option2.Visible = false;
                    }
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (option1.Visible == true)
                {
                    ngLight.Visible = false;
                    agDark.Visible = false;
                    qgDark.Visible = false;

                    option1.Visible = false;

                    skyTimer1.Enabled = true;
                    cactusTimer1.Enabled = true;

                    ground.Visible = true;

                    dino.Visible = true;
                    dinoJump.Text = "0";

                    score.Visible = true;
                }

                if (option2.Visible == true)
                {
                    option2.Visible = false;

                    ngDark.Visible = false;
                    agLight.Visible = false;
                    qgDark.Visible = false;

                    ag.Visible = true;
                }

                if (option3.Visible == true)
                {
                    this.Close();
                }
            }

            if (e.KeyCode == Keys.Back)
            {
                option2.Visible = true;

                ngDark.Visible = true;
                agLight.Visible = true;
                qgDark.Visible = true;

                ag.Visible = false;
            }

            if (e.KeyCode == Keys.R)
            {
                if (restart.Visible == true)
                {
                    restart.Visible = false;

                    sky.Visible = false;
                    sky2.Visible = false;
                    sky.Location = new Point(290, 14);
                    sky2.Location = new Point(180, 33);
                    skyTimer1.Enabled = true;

                    cactus.Enabled = true;
                    cactus.Visible = false;
                    cactus.Location = new Point(215, 114);
                    cactusTimer1.Enabled = true;

                    dinoJump.Text = "0";
                    dino.Image = Image.FromFile(@"resources\dino.gif");

                    Score *= 0;
                    score.Text = "Score: 00";
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (ground.Visible == true)
                {
                    this.Close();
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (dinoJump.Text == "0")
                {
                    jump.controls.play();
                    dinoJump.Text = "1";
                    dinoJumpTimer.Enabled = true;

                    dino.Image = Image.FromFile(@"resources\dino-jump.png");

                    dino.Location = new Point(80, 64);
                }
            }
        }

        private void dinoJumpTimer_Tick(object sender, EventArgs e)
        {
            dinoJump.Text = "0";
            dino.Location = new Point(80, 104);

            dino.Image = Image.FromFile(@"resources\dino.gif");

            dinoJumpTimer.Enabled = false;
        }

        private void NgToAg_Tick(object sender, EventArgs e)
        {
            NgToAg.Enabled = false;

            ngLight.Visible = false;
            ngDark.Visible = true;

            agLight.Visible = true;
            agDark.Visible = false;

            option1.Visible = false;
            option2.Visible = true; 
        }

        private void QgToAg_Tick(object sender, EventArgs e)
        {
            QgToAg.Enabled = false;

            qgLight.Visible = false;
            qgDark.Visible = true;

            agLight.Visible = true;
            agDark.Visible = false;

            option3.Visible = false;
            option2.Visible = true; 
        }       
    }
}
