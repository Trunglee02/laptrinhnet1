using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox1.Text);

                int S = 0;
                string calculation = "";
                for (int i = 1; i <= N; i++)
                {
                    S += i;
                    calculation += i.ToString();
                    if (i < N)
                    {
                        calculation += " + ";
                    }
                }

                textBox2.Text = calculation;
                textBox3.Text = S.ToString();



            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào một số nguyên hợp lệ.");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
