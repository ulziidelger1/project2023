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
    public partial class zavhan : Form
    {
        int x = 0, o = 0;
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }
        void Score()
        {

            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic4.Text == "X" && btnTic7.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic1.Text == "X" && btnTic5.Text == "X" && btnTic9.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic2.Text == "X" && btnTic5.Text == "X" && btnTic8.Text == "X")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic6.Text == "X" && btnTic9.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic3.Text == "X" && btnTic5.Text == "X" && btnTic7.Text == "X")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);



                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic4.Text == "X" && btnTic5.Text == "X" && btnTic6.Text == "X")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic7.Text == "X" && btnTic8.Text == "X" && btnTic9.Text == "X")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч Х яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                x++;
                plusone = x;
                labelPlayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }

            //=================================================================================

            if (btnTic1.Text == "O" && btnTic2.Text == "O" && btnTic3.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic4.Text == "O" && btnTic7.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic4.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic1.Text == "O" && btnTic5.Text == "O" && btnTic9.Text == "O")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic2.Text == "O" && btnTic5.Text == "O" && btnTic8.Text == "O")
            {
                btnTic2.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic6.Text == "O" && btnTic9.Text == "O")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic3.Text == "O" && btnTic5.Text == "O" && btnTic7.Text == "O")
            {
                btnTic3.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic7.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic4.Text == "O" && btnTic5.Text == "O" && btnTic6.Text == "O")
            {
                btnTic4.BackColor = Color.PowderBlue;
                btnTic5.BackColor = Color.PowderBlue;
                btnTic6.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }

            if (btnTic7.Text == "O" && btnTic8.Text == "O" && btnTic9.Text == "O")
            {
                btnTic7.BackColor = Color.PowderBlue;
                btnTic8.BackColor = Color.PowderBlue;
                btnTic9.BackColor = Color.PowderBlue;

                MessageBox.Show("Тоглогч O яллаа", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);

                o++;
                plusone = o;
                labelPlayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
        }
        public zavhan()
        {
            InitializeComponent();
        }

        private void btnTic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic1.Text = "X";
                checker = true;
            }
            else
            {
                btnTic1.Text = "O";
                checker = false;
            }
            Score();
            btnTic1.Enabled = false;
        }

        private void btnTic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic2.Text = "X";
                checker = true;
            }
            else
            {
                btnTic2.Text = "O";
                checker = false;
            }
            Score();
            btnTic2.Enabled = false;
        }

        private void btnTic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic3.Text = "X";
                checker = true;
            }
            else
            {
                btnTic3.Text = "O";
                checker = false;
            }
            Score();
            btnTic3.Enabled = false;
        }

        private void btnTic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic4.Text = "X";
                checker = true;
            }
            else
            {
                btnTic4.Text = "O";
                checker = false;
            }
            Score();
            btnTic4.Enabled = false;
        }

        private void btnTic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic5.Text = "X";
                checker = true;
            }
            else
            {
                btnTic5.Text = "O";
                checker = false;
            }
            Score();
            btnTic5.Enabled = false;
        }

        private void btnTic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic6.Text = "X";
                checker = true;
            }
            else
            {
                btnTic6.Text = "O";
                checker = false;
            }
            Score();
            btnTic6.Enabled = false;
        }

        private void btnTic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic7.Text = "X";
                checker = true;
            }
            else
            {
                btnTic7.Text = "O";
                checker = false;
            }
            Score();
            btnTic7.Enabled = false;
        }

        private void btnTic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic8.Text = "X";
                checker = true;
            }
            else
            {
                btnTic8.Text = "O";
                checker = false;
            }
            Score();
            btnTic8.Enabled = false;
        }

        private void btnTic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnTic9.Text = "X";
                checker = true;
            }
            else
            {
                btnTic9.Text = "O";
                checker = false;
            }
            Score();
            btnTic9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checker = false;
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;

            labelPlayerO.Text = "0";
            labelPlayerX.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checker = false;
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
            btnTic1.BackColor = Color.White;
            btnTic2.BackColor = Color.White;
            btnTic3.BackColor = Color.White;
            btnTic4.BackColor = Color.White;
            btnTic5.BackColor = Color.White;
            btnTic6.BackColor = Color.White;
            btnTic7.BackColor = Color.White;
            btnTic8.BackColor = Color.White;
            btnTic9.BackColor = Color.White;
        }

        private void btnTic5_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            this.Close();
        }
    }
}
