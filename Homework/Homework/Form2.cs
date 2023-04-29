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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            zavhan f1 = new zavhan();
            f1.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DundGovi from1 = new DundGovi();
            from1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Khuvsgul f2 = new Khuvsgul();
            f2.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            UmnuGovi form1 = new UmnuGovi();
            form1.Show();
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ovor_hangai form1 = new ovor_hangai();
            form1.Show();
            this.Close();
        }
    }
}
