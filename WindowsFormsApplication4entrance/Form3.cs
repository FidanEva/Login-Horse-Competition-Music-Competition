using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4entrance
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int birleft, ikileft, ucleft;

        Random at = new Random();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 music = new Form2();
            music.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birsekil = pictureBox1.Width;
            int ikisekil = pictureBox2.Width;
            int ucsekil = pictureBox3.Width;

            int theend = label4.Left;

            pictureBox1.Left += at.Next(4, 20);
            pictureBox2.Left += at.Next(4, 20);
            pictureBox3.Left += at.Next(4, 20);

            int time = Convert.ToInt32(label6.Text);
            time++;
            label6.Text = time.ToString();

            if (pictureBox1.Left > pictureBox2.Left + 4 && pictureBox1.Left > pictureBox3.Left + 4)
            {
                label5.Text = "The first horse is very fast:)";
            }
            if (pictureBox2.Left > pictureBox1.Left + 4 && pictureBox2.Left > pictureBox3.Left + 4)
            {
                label5.Text = "The second horse goes to the final...";
            }
            if (pictureBox3.Left > pictureBox2.Left + 4 && pictureBox3.Left > pictureBox1.Left + 4)
            {
                label5.Text = "The third horse will be champioon))";
            }
            if (birsekil + pictureBox1.Left >= theend)
            {
                timer1.Enabled = false;
                label5.Text = "The number one horse is the winner of the race!!!";
            }
            if (ikisekil + pictureBox2.Left >= theend)
            {
                timer1.Enabled = false;
                label5.Text = "The number two horse is the winner of the race!!!";
            }
            if (ucsekil + pictureBox3.Left >= theend)
            {
                timer1.Enabled = false;
                label5.Text = "The number three horse is the winner of the race!!!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label5.Text = " ";
            label6.Text = "0";

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            birleft = pictureBox1.Left;
            ikileft = pictureBox2.Left;
            ucleft = pictureBox3.Left;
        }
    }
}
