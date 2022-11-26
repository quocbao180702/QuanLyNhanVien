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
    public partial class FormTheThanhVien : Form
    {
        public FormTheThanhVien()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            string hoten = txtTenKH.Text;
            string sdt=txtSDT.Text;
            string ngay=datNgay.Value.ToString();
            MessageBox.Show("Đăng kí thành công");


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
