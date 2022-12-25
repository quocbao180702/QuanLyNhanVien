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


        private void button1_Click(object sender, EventArgs e)
        {
            if(ckbDaHieu.Checked == true)
            {
                this.Hide();
                FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma,quyen);
                fthongtin.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng đọc rõ nội quy và check và đã hiểu");
            }
        }
    }
}
