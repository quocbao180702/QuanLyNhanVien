using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FromQuenMatKhau : Form
    {
        public FromQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Ten Dang Nhap La";
            thongbao += this.txtTenDangNhap.Text;

            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Nhap Lai Mat Khau");
            }
            else
            {
                MessageBox.Show("dang ki thanh cong");
            }



        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
        }
    }
}
