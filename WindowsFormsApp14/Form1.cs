using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        string sign ="";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button3.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtDisplay.Text);
            }
           
            

            sign = button13.Text;
            txtDisplay.Text ="";
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double result = 0;
            num2 = double.Parse(txtDisplay.Text);
            if (sign == "+")
            {
                result = num1 + num2;
            }
            else if (sign == "-") {
                result = num1 - num2;
            }
            else if (sign == "x")
            {
                result = num1 * num2;
            }
            else if (sign == "/")
            {
                result = num1 / num2;
            }
            else { }


            txtDisplay.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button6.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button10.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += button16.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtDisplay.Text);
            }
            sign = button9.Text;
            txtDisplay.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtDisplay.Text);
            }
            sign = button5.Text;
            txtDisplay.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = double.Parse(txtDisplay.Text);
            }
            sign = button4.Text;
            txtDisplay.Text = "";
        }
    }
}
















//var btn = (Button)sender;
//switch (btn.Name)
//{
//    case "button1":
//        MessageBox.Show("Button 1 clicked" + $"{btn.Text}");
//        break;
//    case "button2":
//        MessageBox.Show("Button 2 clicked");
//        break;
//    case "button3":
//        MessageBox.Show("Button 3 clicked");
//        break;
//    default:
//        MessageBox.Show("Unknown button clicked");
//        break;
//}



