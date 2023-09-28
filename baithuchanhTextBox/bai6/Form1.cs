using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBox1.Text);

                string binary = ConvertToBinary(N);

                // Hiển thị kết quả trong TextBox
                textBox2.Text = binary;

            }
            catch
            {
                MessageBox.Show("Nhập lại số hợp lệ!!");

                textBox1.Text = "";
                textBox1.Focus();
            }
        }
        private string ConvertToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn chắc muốn thoát chứ", "Cảnh báo!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Close();
            }
        }
    }
    }

