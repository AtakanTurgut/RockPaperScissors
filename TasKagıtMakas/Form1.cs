using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasKagıtMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int score = 0;
        int cScore = 0;

        private void btnRock_Click(object sender, EventArgs e)
        {
            btnCRock.BackColor = DefaultBackColor;
            btnCPaper.BackColor = DefaultBackColor;
            btnCScissors.BackColor = DefaultBackColor;

            Random random = new Random();

            int value;
            value = random.Next(1, 4);

            if (value == 1)
            {
                lblStatus.Text = "Draw";
                btnCRock.BackColor = Color.Gray;
            }
            else if (value == 2)
            {
                lblStatus.Text = "Lost";
                btnCPaper.BackColor = Color.Red;
                cScore++;
                lblCScore.Text = cScore.ToString();
            }
            else if (value == 3)
            {
                lblStatus.Text = "Win";
                btnCScissors.BackColor = Color.Green;
                score++;
                lblScore.Text = score.ToString();
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            btnCRock.BackColor = DefaultBackColor;
            btnCPaper.BackColor = DefaultBackColor;
            btnCScissors.BackColor = DefaultBackColor;

            Random random = new Random();

            int value;
            value = random.Next(1, 4);

            if (value == 1)
            {
                lblStatus.Text = "Win";
                btnCRock.BackColor = Color.Green;
                score++;
                lblScore.Text = score.ToString();
            }
            else if (value == 2)
            {
                lblStatus.Text = "Draw";
                btnCPaper.BackColor = Color.Gray;
            }
            else if (value == 3)
            {
                lblStatus.Text = "Lost";
                btnCScissors.BackColor = Color.Red;
                cScore++;
                lblCScore.Text = cScore.ToString();
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            btnCRock.BackColor = DefaultBackColor;
            btnCPaper.BackColor = DefaultBackColor;
            btnCScissors.BackColor = DefaultBackColor;

            Random random = new Random();

            int value;
            value = random.Next(1, 4);

            if (value == 1)
            {
                lblStatus.Text = "Lost";
                btnCRock.BackColor = Color.Red;
                cScore++;
                lblCScore.Text = cScore.ToString();
            }
            else if (value == 2)
            {
                lblStatus.Text = "Win";
                btnCPaper.BackColor = Color.Green;
                score++;
                lblScore.Text = score.ToString();
            }
            else if (value == 3)
            {
                lblStatus.Text = "Draw";
                btnCScissors.BackColor = Color.Gray;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString("-");

            cScore = 0;
            lblCScore.Text = cScore.ToString("-");

            lblStatus.Text = "";

            btnCRock.BackColor = DefaultBackColor;
            btnCPaper.BackColor = DefaultBackColor;
            btnCScissors.BackColor = DefaultBackColor;

            btnRock.Enabled = true;
            btnPaper.Enabled = true;
            btnScissors.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cScore == 3)
            {
                lblStatus.Text = "Computer Won!";
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
            else if (score == 3)
            {
                lblStatus.Text = "You Won!";
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;
            }
        }

        private void btnCPaper_Click(object sender, EventArgs e)
        {

        }
    }
}
