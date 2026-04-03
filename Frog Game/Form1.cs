using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        Point p1;
        int wd;
        int ht;
        int score = 0;
        int time = 60;
        int highscore = 0;
        int levelch = 1;
        public Form1(string username,int level)
        {
            InitializeComponent();
            label2.Text = ("Hello "+username);
            levelch = level; 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score += 1;
            label1.Text = ("Score: " + score);
            p1 = new Point(r.Next(wd - pictureBox1.Width), r.Next(ht - pictureBox1.Height));
            pictureBox1.Location = p1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            wd = panel1.Width;
            ht = panel1.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            p1 = new Point(r.Next(wd - pictureBox1.Width), r.Next(ht - pictureBox1.Height));
            pictureBox1.Location = p1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            pictureBox1.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                time = time - 1;
                label3.Text = (time.ToString());
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                button2.Visible = true;
                if (score > highscore) highscore = score;
                if (score >= 40)
                    MessageBox.Show("Congratulations!!\n    You won!");
                else
                    MessageBox.Show("Game over.");
                pictureBox1.Enabled = false;
                label4.Text = ("Highscore: " + highscore);
                button1.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            timer1.Start();
            timer2.Start();
            score = 0;
            label1.Text = ("Score: " + score);
            time = 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (levelch == 2)
            {
                if (score > 0)
                {
                    score = score - 1;
                    label1.Text = ("Score: " + score);
                }
            }


        }
    }

}
