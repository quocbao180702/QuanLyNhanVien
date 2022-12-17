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
    public partial class FormDangKyCa : Form
    {
        public FormDangKyCa()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan();
            fthongtin.ShowDialog();
            this.Close();
        }

        private void btnBoChon_Click(object sender, EventArgs e)
        {
            radA.Checked = false;
            radB.Checked = false;
            radC.Checked = false;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(radA.Checked)
            {
                MessageBox.Show("Số Ca bằng 1, Mỗi tháng bạn phải làm 30 ca \n Hãy làm siêng năng nhé");
            }
            else if(radB.Checked)
            {
                MessageBox.Show("Số Ca bằng 1,  Mỗi tháng bạn phải làm 30 ca \n Hãy làm siêng năng nhé");
            }
            else
            {
                MessageBox.Show("Số Ca bằng 2,  Mỗi tháng bạn phải làm 60 ca \n Hãy làm siêng năng nhé");
            }
        }
    }
}
