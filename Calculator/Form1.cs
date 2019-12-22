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
    }
}
