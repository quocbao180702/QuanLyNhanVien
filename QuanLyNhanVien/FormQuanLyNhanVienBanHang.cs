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
    public partial class FormQuanLyNhanVienBanHang : Form
    {
        public FormQuanLyNhanVienBanHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinNhanVien  frmquanly = new FormThongTinNhanVien();
            frmquanly.ShowDialog();
        }
    }
}
