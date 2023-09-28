using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;

            bool isNumber1 = double.TryParse(x, out double number1);
            bool isNumber2 = double.TryParse(y, out double number2);

            if (isNumber1 && isNumber2)
            {


                double gcd = FindGCD(number1, number2);
                double lcm = (number1 * number2) / gcd;

                textBox3.Text = gcd.ToString();
                textBox4.Text = lcm.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập lại!");
                textBox1.Text = "";
                textBox2.Text = "";

                textBox1.Focus();
            }
        }

        private double FindGCD(double a, double b)
        {
            if (b > a)
            {
                double temp = b;
                b = a;
                a = temp;
            }

            double i = b;
            while (i >= 1)
            {
                if (a % i == 0 && b % i == 0)
                    break;
                i--;
            }
            return i;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Ê thoát thật à cu ?!!! ", "Warning!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Close();
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox1.Focus();
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Ê thoát thật à cu ?!!! ", "Warning!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}