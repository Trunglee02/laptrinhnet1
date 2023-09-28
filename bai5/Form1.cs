using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            int x = a * d - b * c;
            int y = b * d;

            int gcd = Findgcd(x, y);

            int j = x / gcd;
            int k = y / gcd;


            textBox5.Text = j.ToString();
            textBox6.Text = k.ToString();



        }

        private int Findgcd(int x, int y)
        {
            if (y > x)
            {
                int temp = y;
                y = x;
                x = temp;
            }

            int i = y;
            while (i >= 1)
            {
                if (x % i == 0 && y % i == 0)
                    break;
                i--;
            }
            return i;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            int x = a * d;
            int y = b * c;

            int gcd = Findg(x, y);

            int j = x / gcd;
            int k = y / gcd;


            textBox5.Text = j.ToString();
            textBox6.Text = k.ToString();



        }

        private int Findg(int x, int y)
        {
            if (y > x)
            {
                int temp = y;
                y = x;
                x = temp;
            }

            int i = y;
            while (i >= 1)
            {
                if (x % i == 0 && y % i == 0)
                    break;
                i--;
            }
            return i;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            int x = a * c;
            int y = b * d;

            int gcd = Findgc(x, y);

            int j = x / gcd;
            int k = y / gcd;


            textBox5.Text = j.ToString();
            textBox6.Text = k.ToString();



        }

        private int Findgc(int x, int y)
        {
            if (y > x)
            {
                int temp = y;
                y = x;
                x = temp;
            }

            int i = y;
            while (i >= 1)
            {
                if (x % i == 0 && y % i == 0)
                    break;
                i--;
            }
            return i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            int x = a * d + b * c;
            int y = b * d;

            int gcd = FindGCD(x, y);

            int j = x / gcd;
            int k = y / gcd;


            textBox5.Text = j.ToString();
            textBox6.Text = k.ToString();



        }

        private int FindGCD(int x, int y)
        {
            if (y > x)
            {
                int temp = y;
                y = x;
                x = temp;
            }

            int i = y;
            while (i >= 1)
            {
                if (x % i == 0 && y % i == 0)
                    break;
                i--;
            }
            return i;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn Chắc Muốn Thoát Chứ?", "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);



            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
