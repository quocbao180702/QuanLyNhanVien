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
    public partial class FormThongTinTaiKhoan : Form
    {
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if(radQuanLyKho.Checked==true)
            {
                this.Hide();
                FormQuanLyNhanVienKho frmKho = new FormQuanLyNhanVienKho();
                frmKho.ShowDialog();
            }
            else
            {
                this.Hide();
                FormQuanLyNhanVienBanHang frmbanhang = new FormQuanLyNhanVienBanHang();
                frmbanhang.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap frmDN = new frmDangNhap();
            frmDN.ShowDialog();
        }
    }
}
