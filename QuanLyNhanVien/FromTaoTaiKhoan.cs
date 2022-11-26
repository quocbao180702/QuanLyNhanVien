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
    public partial class FromTaoTaiKhoan : Form
    {
        public FromTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) && string.IsNullOrEmpty(txtTen.Text) && string.IsNullOrEmpty(txtHoLot.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo");
            }
            else
            {
                

                txtDiaChi.Clear();
                txtMaNV.Focus();
            }
        }
    }
}
