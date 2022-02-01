using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator_OOP
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        Double result = 0;
        String operation = "";
        bool enter_value = false;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_NumOP(object sender, EventArgs e)
        {
            if ((txtbxDisplay.Text == "0") || (enter_value)) txtbxDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtbxDisplay.Text.Contains("."))
                    txtbxDisplay.Text = txtbxDisplay.Text + num.Text;
            }
            else
                txtbxDisplay.Text = txtbxDisplay.Text + num.Text;
        }

        private void btn_ArthOP(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtbxDisplay.Text);
            txtbxDisplay.Text = "";
            lblOPr.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            lblOPr.Text = "";
            switch (operation)
            {
                case "+":
                    txtbxDisplay.Text = (result + Double.Parse(txtbxDisplay.Text)).ToString();
                    break;
                case "-":
                    txtbxDisplay.Text = (result - Double.Parse(txtbxDisplay.Text)).ToString();
                    break;
                case "x":
                    txtbxDisplay.Text = (result * Double.Parse(txtbxDisplay.Text)).ToString();
                    break;
                case "/":
                    txtbxDisplay.Text = (result / Double.Parse(txtbxDisplay.Text)).ToString();
                    break;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = txtbxDisplay.Text.Length;
            index--;
            txtbxDisplay.Text = txtbxDisplay.Text.Remove(index);

            if (txtbxDisplay.Text == "")
            {
                txtbxDisplay.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtbxDisplay.Text = "0";
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = result * -1;
            txtbxDisplay.Text = result.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            txtbxDisplay.Text = result.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = (result % double.Parse(txtbxDisplay.Text));

            txtbxDisplay.Text = result.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Log(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Exp(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Pow(result, 2);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Pow(result, 3);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Cos(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Sin(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Tan(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Sqrt(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Cosh(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Sinh(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Tanh(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = Math.Log10(result);

            txtbxDisplay.Text = result.ToString();
        }

        private void btnPctg_Click(object sender, EventArgs e)
        {
            result = double.Parse(txtbxDisplay.Text);
            result = result / 100;
            txtbxDisplay.Text = result.ToString();
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
