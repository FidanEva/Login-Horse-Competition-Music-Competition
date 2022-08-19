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
    public partial class Form2 : Form
    {

        Random music = new Random();

        int tugkan = 0;
        int batuhan = 0;
        int diyar = 0;
        int gazapizm = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = music.Next(1, 5);
            int b = music.Next(1, 5);
            int c = music.Next(1, 5);
            int d = music.Next(1, 5);

            label28.Text = a.ToString();
            label27.Text = b.ToString();
            label25.Text = c.ToString();
            label23.Text = d.ToString();

            if(Convert.ToInt32(label28.Text)>Convert.ToInt32(label27.Text))
            {
                tugkan = tugkan + 3;
                label15.Text = tugkan.ToString();
            }
            if (Convert.ToInt32(label28.Text) < Convert.ToInt32(label27.Text))
            {
                diyar = diyar + 3;
                label17.Text = diyar.ToString();
            }
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label23.Text))
            {
                batuhan = batuhan + 3;
                label16.Text = batuhan.ToString();
            }
            if (Convert.ToInt32(label25.Text) < Convert.ToInt32(label23.Text))
            {
                gazapizm = gazapizm + 3;
                label18.Text = gazapizm.ToString();
            }
            if (Convert.ToInt32(label28.Text) == Convert.ToInt32(label27.Text))
            {
                tugkan = tugkan + 1;
                label15.Text = tugkan.ToString();
                diyar = diyar + 1;
                label17.Text = diyar.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label23.Text))
            {
                batuhan = batuhan + 1;
                label16.Text = batuhan.ToString();
                gazapizm = gazapizm + 1;
                label18.Text = gazapizm.ToString();
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int a = music.Next(1, 5);
            int b = music.Next(1, 5);
            int c = music.Next(1, 5);
            int d = music.Next(1, 5);

            label5.Text = a.ToString();
            label6.Text = b.ToString();
            label7.Text = c.ToString();
            label8.Text = d.ToString();

            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label6.Text))
            {
                tugkan = tugkan + 3;
                label15.Text = tugkan.ToString();
            }
            if (Convert.ToInt32(label5.Text) < Convert.ToInt32(label6.Text))
            {
                batuhan = batuhan + 3;
                label16.Text = batuhan.ToString();
            }
            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                diyar = diyar + 3;
                label17.Text = diyar.ToString();
            }
            if (Convert.ToInt32(label7.Text) < Convert.ToInt32(label8.Text))
            {
                gazapizm = gazapizm + 3;
                label18.Text = gazapizm.ToString();
            }
            if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label6.Text))
            {
                tugkan = tugkan + 1;
                label15.Text = tugkan.ToString();
                batuhan = batuhan + 1;
                label16.Text = batuhan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                diyar = diyar + 1;
                label17.Text = diyar.ToString();
                gazapizm = gazapizm + 1;
                label18.Text = gazapizm.ToString();
            }
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a = music.Next(1, 5);
            int b = music.Next(1, 5);
            int c = music.Next(1, 5);
            int d = music.Next(1, 5);

            label38.Text = a.ToString();
            label37.Text = b.ToString();
            label35.Text = c.ToString();
            label33.Text = d.ToString();

            if (Convert.ToInt32(label38.Text) > Convert.ToInt32(label37.Text))
            {
                tugkan = tugkan + 3;
                label15.Text = tugkan.ToString();
            }
            if (Convert.ToInt32(label38.Text) < Convert.ToInt32(label37.Text))
            {
                gazapizm = gazapizm + 3;
                label18.Text = gazapizm.ToString();
            }
            if (Convert.ToInt32(label35.Text) > Convert.ToInt32(label33.Text))
            {
                diyar = diyar + 3;
                label17.Text = diyar.ToString();
            }
            if (Convert.ToInt32(label35.Text) < Convert.ToInt32(label33.Text))
            {
                batuhan = batuhan + 3;
                label16.Text = batuhan.ToString();
            }
            if (Convert.ToInt32(label38.Text) == Convert.ToInt32(label37.Text))
            {
                tugkan = tugkan + 1;
                label15.Text = tugkan.ToString();
                gazapizm = gazapizm + 1;
                label18.Text = gazapizm.ToString();
            }
            if (Convert.ToInt32(label35.Text) == Convert.ToInt32(label33.Text))
            {
                diyar = diyar + 1;
                label17.Text = diyar.ToString();
                batuhan = batuhan + 1;
                label16.Text = batuhan.ToString();
            }
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(label15.Text)>Convert.ToInt32(label16.Text)&& Convert.ToInt32(label15.Text) > Convert.ToInt32(label17.Text)&& Convert.ToInt32(label15.Text) > Convert.ToInt32(label18.Text))
            {
                axWindowsMediaPlayer1.URL = ("D:\\PDF-mp3\\tugkan.mp3");
            }
            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label15.Text) && Convert.ToInt32(label16.Text) > Convert.ToInt32(label17.Text) && Convert.ToInt32(label16.Text) > Convert.ToInt32(label18.Text))
            {
                axWindowsMediaPlayer1.URL = ("D:\\PDF-mp3\\batuhan.mp3");
            }
            if (Convert.ToInt32(label17.Text) > Convert.ToInt32(label16.Text) && Convert.ToInt32(label17.Text) > Convert.ToInt32(label15.Text) && Convert.ToInt32(label17.Text) > Convert.ToInt32(label18.Text))
            {
                axWindowsMediaPlayer1.URL = ("D:\\PDF-mp3\\diyarpala.mp3");
            }
            if (Convert.ToInt32(label18.Text) > Convert.ToInt32(label16.Text) && Convert.ToInt32(label18.Text) > Convert.ToInt32(label17.Text) && Convert.ToInt32(label18.Text) > Convert.ToInt32(label15.Text))
            {
                axWindowsMediaPlayer1.URL = ("D:\\PDF-mp3\\gazapizm.mp3");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 yeni= new Form1();
            yeni.Show();
            this.Hide();
        }

        private void competitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 horse = new Form3();
            horse.Show();
            this.Hide();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();

        }
    }
}
