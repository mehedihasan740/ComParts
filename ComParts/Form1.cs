using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComParts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }
        bool expand1 = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand1 == false)
            {
                flowLayoutPanel1.Height += 15;
                if (flowLayoutPanel1.Height >= flowLayoutPanel1.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand1 = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 15;
                if (flowLayoutPanel1.Height <= flowLayoutPanel1.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand1 = false;
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            
        }

        private void button27_MouseHover(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button31_MouseHover(object sender, EventArgs e)
        {
            timer2.Start();
        }
        bool expand2 = false;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (expand2 == false)
            {
                flowLayoutPanel2.Height += 15;
                if (flowLayoutPanel2.Height >= flowLayoutPanel2.MaximumSize.Height)
                {
                    timer2.Stop();
                    expand2 = true;
                }
            }
            else
            {
                flowLayoutPanel2.Height -= 15;
                if (flowLayoutPanel2.Height <= flowLayoutPanel2.MinimumSize.Height)
                {
                    timer2.Stop();
                    expand2 = false;
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
