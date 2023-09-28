using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float data1, data2;
        string pheptinh;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text =  "-" + textBox2.Text ;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            pheptinh = "cong";
            textBox1.Text = data1.ToString() + "+";
            data1 = float.Parse(textBox2.Text);
            textBox2.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (pheptinh == "cong")
            {
                data2 = data1 + float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "+" + float.Parse(textBox2.Text) + "=";
                textBox2.Clear();
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "tru")
            {
                data2 = data1 - float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "-" + float.Parse(textBox2.Text) + "=";
                textBox2.Clear();
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "nhan")
            {
                data2 = data1 * float.Parse(textBox2.Text);
                textBox1.Text = data1.ToString() + "*" + float.Parse(textBox2.Text) + "=";
                textBox2.Clear();
                textBox2.Text = data2.ToString();
            }
            if (pheptinh == "chia")
            {
                if(float.Parse(textBox2.Text) == 0)
                {
                    textBox1.Text = data1.ToString() + "/";
                    textBox2.Text = "Không chia được";
                }
                else
                {
                    data2 = data1 / float.Parse(textBox2.Text);
                    textBox1.Text = data1.ToString() + "/" + float.Parse(textBox2.Text) + "=";
                    textBox2.Clear();
                    textBox2.Text = data2.ToString();
                }
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pheptinh = "tru";
            textBox1.Text = data1.ToString() + "-";
            data1 = float.Parse(textBox2.Text);
            textBox2.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pheptinh = "nhan";
            textBox1.Text = data1.ToString() + "*";
            data1 = float.Parse(textBox2.Text);
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pheptinh = "chia";
            textBox1.Text = data1.ToString() + "/";
            data1 = float.Parse(textBox2.Text);
            textBox2.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
