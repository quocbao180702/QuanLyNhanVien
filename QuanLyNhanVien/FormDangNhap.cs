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

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShow.Checked==true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="NQ001" && txtPassword.Text=="123")
            {
                this.Hide();
                FormQuanLyNhanVien frmnv = new FormQuanLyNhanVien();
                frmnv.ShowDialog();
            }
            else if(txtUsername.Text == "NK001" && txtPassword.Text=="123")
            {
                this.Hide();
                FormQuanLyNhanVien frmnv = new FormQuanLyNhanVien();
                frmnv.ShowDialog();
            }
            else
            {
                MessageBox.Show("đăng nhập thất bại");
            }
        }

        private void btnQuenMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromQuenMatKhau frmQMK = new FromQuenMatKhau();
            frmQMK.ShowDialog();
        }
    }
}
