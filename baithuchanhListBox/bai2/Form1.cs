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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách món ăn
            List<string> danhSachMonAn = new List<string>()
            {
                "Mì xào",
                "Cơm rang",
                "Phở bò",
                "Bún chả",
                "Gà nướng",
                "Bánh mỳ",
                "Bún riêu"
            };

            // Hiển thị danh sách món ăn trong ListBox1
            foreach (string monAn in danhSachMonAn)
            {
                listBox1.Items.Add(monAn);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // In danh sách món ăn
            string menu = "Danh sách thực đơn ngày:\n";
            foreach (var monAn in listBox2.Items)
            {
                menu += "- " + monAn.ToString() + "\n";
            }
            MessageBox.Show(menu, "Thực đơn");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các món trong ListBox2
            foreach (var monAn in listBox2.Items.OfType<string>().ToList())
            {
                listBox1.Items.Add(monAn);
            }
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Chuyển tất cả các món từ ListBox1 sang ListBox2
            foreach (var monAn in listBox1.Items.OfType<string>().ToList())
            {
                listBox2.Items.Add(monAn);
            }
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa một món được chọn trong ListBox2
            if (listBox2.SelectedItem != null)
            {
                string selectedMonAn = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(selectedMonAn);
                listBox2.Items.Remove(selectedMonAn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Chuyển một món được chọn từ ListBox1 sang ListBox2
            if (listBox1.SelectedItem != null)
            {
                string selectedMonAn = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selectedMonAn);
                listBox1.Items.Remove(selectedMonAn);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
