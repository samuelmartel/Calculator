using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exe_Click(object sender, EventArgs e)
        {
            int lhs = 0;
            int rhs = 0;
            int ans = 0;
            String add = "+";
            String sub = "-";
            String mult = "*";
            String div = "/";

            String slhs = txtbx_1.Text;
            String srhs = txtbx_2.Text;
            String Operator = txtbx_Op.Text;

            lhs = Convert.ToInt32(slhs);
            rhs = Convert.ToInt32(srhs);

            switch (Operator)
            {
                case "+":
                    ans = (lhs + rhs);
                    break;

                case "-":
                    ans = (lhs - rhs);
                    break;

                case "*":
                    ans = (lhs * rhs);
                    break;

                case "/":
                    ans = (lhs / rhs);
                    break;

            }



            String sans = ans.ToString();

            txtbx_ans.Text = sans;
            txtbx_Op.Clear();
            txtbx_1.Clear();
            txtbx_2.Clear();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            String sub = "-";
            txtbx_Op.Text = sub;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String add = "+";
            txtbx_Op.Text = add;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            String mult = "*";
            txtbx_Op.Text = mult;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            String div = "/";
            txtbx_Op.Text = div;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if(!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("1");
            }

            else
            {
                txtbx_1.AppendText("1");
            }

            if(txtbx_1.Focused)
            {
                txtbx_1.AppendText("1");
            }

            else if(txtbx_2.Focused)
            {
                txtbx_2.AppendText("1");
            }

            else { }
        }

        private void txtbx_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("2");
            }

            else
            {
                txtbx_1.AppendText("2");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("2");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("2");
            }

            else { }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("3");
            }

            else
            {
                txtbx_1.AppendText("3");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("3");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("3");
            }

            else { }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("4");
            }

            else
            {
                txtbx_1.AppendText("4");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("4");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("4");
            }

            else { }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("5");
            }

            else
            {
                txtbx_1.AppendText("5");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("5");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("5");
            }

            else { }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("6");
            }

            else
            {
                txtbx_1.AppendText("6");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("6");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("6");
            }

            else { }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("7");
            }

            else
            {
                txtbx_1.AppendText("7");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("7");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("7");
            }

            else { }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("8");
            }

            else
            {
                txtbx_1.AppendText("8");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("8");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("8");
            }

            else { }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("9");
            }

            else
            {
                txtbx_1.AppendText("9");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("9");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("9");
            }

            else { }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (!(txtbx_Op.Text.Length == 0))
            {
                txtbx_2.AppendText("0");
            }

            else
            {
                txtbx_1.AppendText("0");
            }

            if (txtbx_1.Focused)
            {
                txtbx_1.AppendText("0");
            }

            else if (txtbx_2.Focused)
            {
                txtbx_2.AppendText("0");
            }

            else { }
        }

        private void btn_Clr_Click(object sender, EventArgs e)
        {
            txtbx_Op.Clear();
            txtbx_1.Clear();
            txtbx_2.Clear();
        }
    }
}

  