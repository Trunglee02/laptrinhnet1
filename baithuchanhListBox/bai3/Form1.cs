using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập Enter key sẽ kích hoạt sự kiện click cho nút cập nhật
            this.AcceptButton = button1_Click;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string input = textBox1.Text;

            // Kiểm tra xem TextBox có rỗng hay không
            if (!string.IsNullOrEmpty(input))
            {
                // Thêm giá trị vào ListBox
                listBox1.Items.Add(input);

                // Xóa nội dung trong TextBox
                textBox1.Clear();

                // Chuyển focus vào TextBox
                textBox1.Focus();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tính tổng các số trong ListBox
            int sum = 0;
            foreach (var item in listBox1.Items)
            {
                sum += int.Parse(item.ToString());
            }

            // Hiển thị kết quả
            MessageBox.Show("Tổng của danh sách số là: " + sum.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                // Kiểm tra xem người dùng đã chọn "Xóa phần tử đầu tiên" hay "Xóa phần tử cuối cùng"
                if (sender == buttonRemoveFirst)
                {
                    listBox1.Items.RemoveAt(0); // Xóa phần tử đầu tiên
                }
                else if (sender == buttonRemoveLast)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.Count - 1); // Xóa phần tử cuối cùng
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
