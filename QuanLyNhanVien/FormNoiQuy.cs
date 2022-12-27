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
    public partial class FormNoiQuy : Form
    {
        public FormNoiQuy()
        {
            InitializeComponent();
        }
        public FormNoiQuy(string id, int quyen)
        {
            InitializeComponent();
            this.ma = id;
            this.quyen = quyen;
        }
        string ma = "";
        int quyen = 0;



        private void ckbDaHieu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuayLai_Click(sender, e);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if(ckbDaHieu.Checked == true)
            {
                this.Hide();
                FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma, quyen);
                fthongtin.ShowDialog();
                fthongtin.Close();
            }
            else
            {
                MessageBox.Show("Bạn hãy đọc và check đã hiểu", "Thông Báo");
            }
        }
    }
}
