using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu TextBox1 không rỗng và chứa một số nguyên dương hợp lệ
            if (!string.IsNullOrEmpty(textBox1.Text) && int.TryParse(textBox1.Text, out int n) && n > 0)
            {
                // Xóa nội dung cũ trong TextBox2
                textBox2.Clear();

                // Tìm các số nguyên tố từ 1 đến N và in kết quả vào TextBox2
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        textBox2.AppendText(i.ToString() + " ");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức kiểm tra số nguyên tố
        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
    }


        
    

