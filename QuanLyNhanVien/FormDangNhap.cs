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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string ten = txtTaiKhoan.Text.Substring(0, 2);
            if(ten=="NQ"&& txtTaiKhoan.Text == "NQ001")
            {
                this.Hide();
                FormQuanLyNhanVien frmQLNV = new FormQuanLyNhanVien();
                frmQLNV.ShowDialog();
            }
            else if(ten=="NK" && txtTaiKhoan.Text == "NK001")
            {
                
            }
            else if(ten=="NB" && txtTaiKhoan.Text == "NB001")
            {

            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc Mặt Khẩu Không Đúng");
                btnHuy_Click(sender, e);
            }
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromQuenMatKhau frmQuenMK = new FromQuenMatKhau();
            frmQuenMK.ShowDialog();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
