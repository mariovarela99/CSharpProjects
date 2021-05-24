using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 10;
        int scored = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            pipeDown.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            Score.Text = "Score: " + scored;

            if (pipeDown.Left < -50)
            {
                pipeDown.Left = 400;
                scored++;
            }
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 550;
                scored++;
            }
            if (Bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(ground.Bounds) || 
                Bird.Top < -25) 
            {
                GameOver();
            }

            if (scored > 5)
            {
                pipeSpeed = 15;
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

            if (e.KeyCode == Keys.Escape)
            {
                GameOver();
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void GameOver()
        {
            gameTime.Stop();
            Score.Text += " Game Over.!";
        }

    }
}
