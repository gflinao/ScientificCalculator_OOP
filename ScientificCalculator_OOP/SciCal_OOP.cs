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

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "4";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "8";        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "9";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "6";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnDOT_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "5";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbxDisplay.Text == "0")
            {
                txtbxDisplay.Text = "";
            }

            txtbxDisplay.Text = txtbxDisplay.Text + "0";
        }
    }
}
