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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2nd_Click(object sender, EventArgs e)
        {

        }

        private void btnln_Click(object sender, EventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
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
            lblOP.Text = "";
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtbxDisplay.Text);
            result = result * -1;
            txtbxDisplay.Text = result.ToString();
        }

        private void btnXr2_Click(object sender, EventArgs e)
        {
            result = Double.Parse(txtbxDisplay.Text);
            result = Math.Pow(result, 2);
            txtbxDisplay.Text = result.ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            result = Math.PI;
            txtbxDisplay.Text = result.ToString();
        }

        private void ArithOP_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtbxDisplay.Text);
            txtbxDisplay.Text = "";
            lblOP.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void btnNumOP_Click(object sender, EventArgs e)
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

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtbxDisplay.Text = (result + Double.Parse(txtbxDisplay.Text)).ToString();
                    break;

                case "-":
                    txtbxDisplay.Text = (result - Double.Parse(txtbxDisplay.Text)).ToString();
                    break;

                case "*":
                    txtbxDisplay.Text = (result * Double.Parse(txtbxDisplay.Text)).ToString();
                    break;

                case "/":
                    txtbxDisplay.Text = (result / Double.Parse(txtbxDisplay.Text)).ToString();
                    break;

            }
        }
    }
}
