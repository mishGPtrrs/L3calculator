using System;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void Button1_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c; //This variable describes the output of calculations
            if (radioButton1.Checked)
            {
                c = a + b; //Adds the first and second inputs together
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b; //Subtracts the second number input from the first input
                label4.Text = "Different: " + c.ToString(); 
            }
            if (radioButton3.Checked)
            {
                c = a * b; //Multiplies the first number input by the second number input
                label4.Text = "Multiply: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                if (b != 0) //Checks for division by zero
                {
                    c = a / b; //Divides the first number input by the second number input
                    label4.Text = "Divide: " + c.ToString();
                }
                else
                {
                    label4.Text = "DIVISION ERROR"; //Notifies the user of an invalid response
                }
            if (radioButton5.Checked)
                {
                    if (b != 0) //Checks for division by zero
                    {
                        c = a % b; //Mods first input and second input
                        label4.Text = "Mod: " + c.ToString();
                    }
                    else
                    {
                        label4.Text = "MODULO BY ZERO ERROR"; //Notifies the user of an invalid response
                    }
                }
            else
                {
                    label4.Text = "Please select a valid operation."; //Notifies the user of an invalid input
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            //Clears all user input and output
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c; //This variable describes the output of calculations
            if (radioButton1.Checked)
            {
                c = a + b; //Adds the first and second inputs together
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b; //Subtracts the second number input from the first input
                label4.Text = "Different: " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b; //Multiplies the first number input by the second number input
                label4.Text = "Multiply: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                if (b != 0) //Checks for division by zero
                {
                    c = a / b; //Divides the first number input by the second number input
                    label4.Text = "Divide: " + c.ToString();
                }
                else
                {
                    label4.Text = "DIVISION ERROR"; //Notifies the user of an invalid response
                }
                if (radioButton5.Checked)
                {
                    if (b != 0) //Checks for division by zero
                    {
                        c = a % b; //Mods first input and second input
                        label4.Text = "Mod: " + c.ToString();
                    }
                    else
                    {
                        label4.Text = "MODULO BY ZERO ERROR"; //Notifies the user of an invalid response
                    }
                }
                else
                {
                    label4.Text = "Please select a valid operation."; //Notifies the user of an invalid input
                }
            }
        }

    }

}