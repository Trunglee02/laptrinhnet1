using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.KeyDown += TextBox1_KeyDown;
            textBox2.KeyDown += TextBox2_KeyDown; // Gắn kết sự kiện KeyDown cho textBox2

        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh "beep" khi nhấn Enter
                textBox2.Focus(); // Di chuyển trỏ đến textBox2
            }
        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox3.Focus(); // Di chuyển trỏ đến textBox3
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            if (int.TryParse(textBox1.Text, out a) &&
                int.TryParse(textBox2.Text, out b) &&
                int.TryParse(textBox3.Text, out c))
            {
                int min = Math.Min(Math.Min(a, b), c);
                int max = Math.Max(Math.Max(a, b), c);
                textBox5.Text = min.ToString();
                textBox4.Text = max.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ vào các ô văn bản a, b, c.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
