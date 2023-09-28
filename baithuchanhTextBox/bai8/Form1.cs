using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            // Set default values
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
          
            lblThanhTien.Text = "Thành Tiền";

            // Set focus and TabIndex
            txtTenHang.Focus();
            txtTenHang.TabIndex = 0;
            txtSoLuong.TabIndex = 1;
            txtDonGia.TabIndex = 2;

            // Set form position to CenterScreen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set AcceptButton and CancelButton
            this.AcceptButton = btnThanhToan;
            this.CancelButton = btnTiep;

            // Set right alignment for numeric TextBoxes
            txtSoLuong.TextAlign = HorizontalAlignment.Right;
            txtDonGia.TextAlign = HorizontalAlignment.Right;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                   int intSoLuong;
        decimal decDonGia, decThanhTien;

        if (txtSoLuong.Text == "")
        {
            MessageBox.Show("Chưa nhập số lượng hàng");
            txtSoLuong.Focus();
            return;
        }
        else if (txtDonGia.Text == "")
        {
            MessageBox.Show("Chưa nhập đơn giá hàng");
            txtDonGia.Focus();
            return;
        }

        intSoLuong = Convert.ToInt32(txtSoLuong.Text);
        decDonGia = Convert.ToDecimal(txtDonGia.Text);

        if (intSoLuong <= 0)
        {
            MessageBox.Show("Số lượng hàng phải lớn hơn 0");
            txtSoLuong.SelectAll();
            txtSoLuong.Focus();
            return;
        }
        else if (decDonGia <= 0)
        {
            MessageBox.Show("Đơn giá hàng phải lớn hơn 0");
            txtDonGia.SelectAll();
            txtDonGia.Focus();
            return;
        }

        decThanhTien = intSoLuong * decDonGia;
        txtThanhTien.Text = decThanhTien.ToString();
        txtThanhTien.SelectAll();
        txtThanhTien.Focus();

        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            // Clear the content of TextBoxes and Label
            txtTenHang.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            lblThanhTien.Text = "";

            // Set focus to the first TextBox
            txtTenHang.Focus();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Prompt a message box to confirm closing the form
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Close the form
                this.Close();
            }
        }
    }
}
