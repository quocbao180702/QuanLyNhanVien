using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        public FormDangKyCa(string ma)
        {
            InitializeComponent();
            this.id = ma;
        }
        string id;
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(id);
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

        private void FormDangKyCa_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select n.*, c.tencv, h.tench from NhanVien n, chucvu c, cuahang h where n.macv=c.macv and n.mach = h.mach and n.manv = '" + id + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMa.Text = dr.GetValue(0).ToString(); ;
                txtHo.Text = dr.GetValue(1).ToString();
                txtTen.Text = dr.GetValue(2).ToString();
                if (dr.GetValue(3).ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                txtChucVu.Text = dr.GetValue(12).ToString();
                txtCuaHang.Text = dr.GetValue(13).ToString();
            }
            conn.Close();
        }
    }
}
