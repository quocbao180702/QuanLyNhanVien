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
    public partial class FormQuanLy : Form
    {
        public FormQuanLy()
        {
            InitializeComponent();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(radQuanLyBanaHang.Checked == true)
            {
                this.Hide();
                FormQuanLyNhanVienBanHang fquanlybh = new FormQuanLyNhanVienBanHang();
                fquanlybh.ShowDialog();
            }
            else
            {
                this.Hide();
                FormQuanLyNhanVienKho fquanlykho = new FormQuanLyNhanVienKho();
                fquanlykho.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan();
            fthongtin.ShowDialog();
        }
    }
}
