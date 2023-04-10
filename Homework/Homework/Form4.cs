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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if(panel2.Width >= 800)
            {
                timer1.Stop();
                Form3 frm = new Form3();
                frm.Show();
                this.Close();
            }
        }
    }
}
