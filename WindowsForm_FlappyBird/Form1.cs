using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_FlappyBird
{
    public partial class Form1 : Form
    {
        bool situation = false;
        int pipleSpeed = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            if (situation == true)
            {
                bird.Top += gravity;

                pipleDown.Left -= pipleSpeed;
                pipleTop.Left -= pipleSpeed;

                scorelbl.Text = score.ToString();


                if (pipleDown.Left < -180)
                {
                    pipleDown.Left = 500;
                    score++;
                }
                if (pipleTop.Left < -180)
                {
                    pipleTop.Left = 500;
                }
            }

            if (bird.Bounds.IntersectsWith(pipleDown.Bounds) || bird.Bounds.IntersectsWith(pipleTop.Bounds) || bird.Bounds.IntersectsWith(grouınd.Bounds))
            {
                Lose();
                Thread.Sleep(2000);
                Application.Restart();
            }
            if (bird.Top < -25)
            {
                Lose();
                Thread.Sleep(2000);
                Application.Restart();

            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                situation = true;
                gravity = -10;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }

        }

        void Lose()
        {
            gameTimer.Stop();
        }

    }
}
