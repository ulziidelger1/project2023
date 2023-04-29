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
    public partial class ovor_hangai : Form
    {
        public ovor_hangai()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var v = textBox21.Location;
            int h = v.Y;
            int j = v.X;

            string d = textBox19.Text;
            if (h >= 451)
            {
                if (d.Length == 6)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[1], d[2], d[0], d[3], d[4], d[5] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }
                else if (d.Length == 5)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[1], d[2], d[0], d[3], d[4] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }
                else if (d.Length == 4)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[1], d[2], d[0], d[3] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }
                else if (d.Length == 3)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[1], d[2], d[0] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }
                else if (d.Length == 2)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[1], d[0] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }
                else if (d.Length == 1)
                {
                    Random rand = new Random();
                    List<char> charList = new List<char> { d[0] };
                    int inde = rand.Next(charList.Count);
                    char randomCha = charList[inde];
                    textBox21.Text = randomCha.ToString();
                }

                h = 167;
                j = 222;
            }
            h++;
            textBox21.Location = new Point(j, h);
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            var v = textBox21.Location;
            int h = v.Y;
            int j = v.X;

            if (j <= 12 && h >= 440)
            {
                textBox12.Text = textBox21.Text;
                label1.Text = "0";
            }
            else if (j == 82 && h >= 440)
            {
                textBox2.Text = textBox21.Text;
                label1.Text = "0";
            }
            else if (j == 152 && h >= 440)
            {
                textBox8.Text = textBox21.Text;
                label1.Text = "0";
            }
            else if (j == 222 && h >= 440)
            {
                textBox9.Text = textBox21.Text;
                label1.Text = "0";
            }
            else if (j == 292 && h >= 440)
            {
                textBox10.Text = textBox21.Text;
                label1.Text = "0";
            }
            else if (j == 362 && h >= 440)
            {
                textBox11.Text = textBox21.Text;
                label1.Text = "0";
            }
            string f = textBox12.Text, a = textBox2.Text, t = textBox8.Text, p = textBox9.Text, k = textBox10.Text, g = textBox11.Text, i;
            i = f + a + t + p + k + g;
            textBox1.Text = i;

        }

        private void timer4_Tick_1(object sender, EventArgs e)
        {
            if (label1.Text == "3")
                textBox21.BackColor = Color.Red;
            else if (label1.Text == "2")
                textBox21.BackColor = Color.Orange;
            else if (label1.Text == "3")
                textBox21.BackColor = Color.Yellow;
            else if (label1.Text == "3")
                textBox21.BackColor = Color.Green;
            else if (label1.Text == "3")
                textBox21.BackColor = Color.Cyan;
            else if (label1.Text == "3")
                textBox21.BackColor = Color.Blue;
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox19.Text)
            {
                this.Hide();
                Form5 form2 = new Form5();
                form2.Show();
                timer3.Stop();
            }
        }

        private void ovor_hangai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                var v = textBox21.Location;
                int h = v.Y;
                int j = v.X;
                j = j - 70;
                textBox21.Location = new Point(j, h);
                int y = Convert.ToInt32(label1.Text);
                y++;
                label1.Text = Convert.ToString(y);

            }
            else if (e.KeyCode == Keys.Right)
            {
                var v = textBox21.Location;
                int h = v.Y;
                int j = v.X;
                j = j + 70;
                textBox21.Location = new Point(j, h);
                int y = Convert.ToInt32(label1.Text);
                y--;
                label1.Text = Convert.ToString(y);

            }
            else if (e.KeyCode == Keys.Down)
            {
                var v = textBox21.Location;
                int j = v.X;
                textBox21.Location = new Point(j, 410);
            }
        }

        private void ovor_hangai_Load(object sender, EventArgs e)
        {
            this.Focus();
            this.Enabled = true;
            this.KeyPreview = true;
            Random ranD = new Random();
            List<string> ch = new List<string> { " Thanks", "Father", "Mother ", "Hugger", "Helper", "Laughs", "Smiles" };
            int ine = ranD.Next(ch.Count);
            string p = ch[ine];
            textBox19.Text = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
