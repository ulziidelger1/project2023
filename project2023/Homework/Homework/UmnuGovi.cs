using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class UmnuGovi : Form
    {
        public UmnuGovi()
        {
            InitializeComponent();

            int nCount = 0;

            pictureBox1.Visible = false;
            pictureBox3.Visible = false;

            button3.Visible = false;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Green;

            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Green;

            button3.Visible = true;

            string ghole = textBox1.Text;
            int y = Convert.ToInt32(ghole);
                y++;
            textBox1.Text = Convert.ToString(y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(pictureBox2.Visible = true) 
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;

                button1.Visible = false;
                button2.Visible = false;
                label1.Visible = false;

            }
            if(pictureBox1.Visible = true)
            {
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;

                button5.BackColor = Color.White;
                button4.BackColor = Color.White;
            }
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button4.BackColor = Color.Green;

            button3.Visible = true;

            string ghole = textBox1.Text;
            int y = Convert.ToInt32(ghole);
            y++;
            textBox1.Text = Convert.ToString(y);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            button4.BackColor = Color.Green;

            button3.Visible = true;
        }
    }
}
