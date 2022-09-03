using System;
using System.Windows.Forms;

namespace VPFinkiBirdProekt
{
    public partial class Form1 : Form
    {
        int score = 0;
        int pipeSpeed = 8;
        int gravity = 10;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FinkiBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            ScoreLabel.Text = "Score: " + score;     

            if(pipeTop.Left < -100)
            {
                pipeTop.Left = rnd.Next(65, 100) * 10;
                score++;
            }
            if(pipeBottom.Left < -100)
            {
                pipeBottom.Left = rnd.Next(65, 100) * 10;
                score++;
            }

            if(FinkiBird.Bounds.IntersectsWith(pipeBottom.Bounds)||
                FinkiBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                FinkiBird.Bounds.IntersectsWith(grounds.Bounds) ||
                FinkiBird.Top < -25)
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 15;
            }
            if(score > 15)
            {
                pipeSpeed = 20;
            }
            if (score > 50)
            {
                pipeSpeed = 30;
            }
           
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void endGame()
        {
            timer1.Stop();
            ScoreLabel.Text = "Game over!!! Your score was : " + score ;
        }

        private void FinkiBird_Click(object sender, EventArgs e)
        {

        }
    }
}
