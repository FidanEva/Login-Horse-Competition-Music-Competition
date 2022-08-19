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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456") 
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Warning! Wrong username or password((");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin"&& textBox2.Text=="123456")
                {
                Form3 yeni = new Form3();
                yeni.Show();
                this.Hide();
                }
            else
            {
                MessageBox.Show("Warning! Wrong username or password((");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
