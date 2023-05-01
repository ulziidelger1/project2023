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
    public partial class bayan_olgii : Form
    {
        public bayan_olgii()
        {
            InitializeComponent();
        }


        private void bayan_olgii_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                var v = pictureBox3.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    j = j - 1;
                    pictureBox3.Location = new Point(j, h);
                }

            }
            else if (e.KeyCode == Keys.Right)
            {
                var v = pictureBox3.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    j = j + 1;
                    pictureBox3.Location = new Point(j, h);
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                var v = pictureBox3.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    h = h - 1;
                    pictureBox3.Location = new Point(j, h);
                }

            }
            else if (e.KeyCode == Keys.A)
            {
                var v = pictureBox1.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    j = j - 1;
                    pictureBox1.Location = new Point(j, h);
                }

            }
            else if (e.KeyCode == Keys.D)
            {
                var v = pictureBox1.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    j = j + 1;
                    pictureBox1.Location = new Point(j, h);
                }

            }

            else if (e.KeyCode == Keys.W)
            {
                var v = pictureBox1.Location;
                int h = v.Y;
                int j = v.X;
                for (int i = 0; i <= 72; i++)
                {
                    h = h - 1;
                    pictureBox1.Location = new Point(j, h);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var v = pictureBox3.Location;
            int h = v.Y;
            int j = v.X;
            if (h <= 284)
            {
                h = h + 4;
                pictureBox3.Location = new Point(j, h);
            }

        }

        private void bayan_olgii_KeyUp(object sender, KeyEventArgs e)
        {
            var v = pictureBox1.Location;
            int h = v.Y;
            int j = v.X;
            var vp = pictureBox3.Location;
            int hp = vp.Y;
            int jp = vp.X;
            if (e.KeyCode == Keys.Down)
            {

                if (h - hp <= 75 && h - hp >= -75 && j - jp <= 75 && j - jp >= -75)
                {
                    int o = Convert.ToInt32(textBox1.Text);
                    o = o - 5;
                    textBox1.Text = Convert.ToString(o);
                    if (h - hp <= 75 && h - hp >= -75 && j == jp)
                    {
                        for (int i = 0; i <= 200; i++)
                        {
                            h = h - 1;
                            pictureBox1.Location = new Point(j, h);
                        }

                    }
                    else if (h - hp <= 75 && j - jp >= -75 && j - jp <= 0)
                    {

                        for (int i = 0; i <= 218; i++)
                        {
                            j = j - 1;
                            h = h - 1;
                            pictureBox1.Location = new Point(j, h);
                        }
                    }
                    else if (h - hp <= 75 && j - jp <= 75 && j - jp >= 0)
                    {

                        for (int i = 0; i <= 218; i++)
                        {
                            j = j + 1;
                            h = h - 1;
                            pictureBox1.Location = new Point(j, h);
                        }
                    }
                }


            }
            if (e.KeyCode == Keys.S)
            {
                 if (h - hp <= 75 && h - hp >= -75 && j - jp <= 75 && j - jp >= -75)
                {
                    int mn = Convert.ToInt32(textBox2.Text);
                    mn = mn - 5;
                    textBox2.Text = Convert.ToString(mn);
                }
                if (hp - h <= 75 && hp - h >= -75 && jp == j)
                {
                    for (int i = 0; i <= 200; i++)
                    {
                        hp = hp - 1;
                        pictureBox3.Location = new Point(jp, hp);
                    }

                }
                else if (hp - h <= 75 && hp - h >= -75 && jp - j <= 0 && jp-j>=-75)
                {

                    for (int i = 0; i <= 218; i++)
                    {
                        jp = jp - 1;
                        hp = hp - 1;
                        pictureBox3.Location = new Point(jp, hp);
                    }
                }
                else if (hp - h <= 75 && hp - h >= -75 && jp - j <= 75 && jp - j >= 0)
                {

                    for (int i = 0; i <= 218; i++)
                    {
                        jp = jp + 1;
                        hp = hp - 1;
                        pictureBox3.Location = new Point(jp, hp);
                    }
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var v = pictureBox1.Location;
            int h = v.Y;
            int j = v.X;
            if (h <= 284)
            {
                h = h + 4;
                pictureBox1.Location = new Point(j, h);
            }
        }

        private void bayan_olgii_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Enabled = true;
            this.KeyPreview = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var v = pictureBox1.Location;
            int h = v.Y;
            int j = v.X;
            var vp = pictureBox3.Location;
            int hp = vp.Y;
            int jp = vp.X;
            if (j <= 0)
                pictureBox1.Location = new Point(0, h);
            if (jp <= 0)
                pictureBox3.Location = new Point(0, hp);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            string f1 = textBox1.Text, v1 = textBox2.Text;
            int f = Convert.ToInt32(f1);
            int v = Convert.ToInt32(v1);
            if (f <= 0)
            {
                this.Close();
                bayan_olgii2 form2 = new bayan_olgii2();
                form2.Show();
                timer4.Stop();
            }
            else if (v <= 0)
            {
                this.Close();
                bayan_olgii3 form2 = new bayan_olgii3();
                form2.Show();
                timer4.Stop();
            }
        }
    }
}
