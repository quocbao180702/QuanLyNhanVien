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
        public FormDangKyCa(string id, int quyen)
        {
            InitializeComponent();
            this.ma = id;
            this.quyen = quyen;
        }
        string ma = "";
        int quyen = 0;

        SqlConnection conn;
        private void FormDangKyCa_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select n.*, c.tencv, h.tench from NhanVien n, chucvu c, cuahang h where n.macv=c.macv and n.mach = h.mach and n.manv = '" + ma + "'", conn);
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
            txtChucVu.ReadOnly = true;
            txtCuaHang.ReadOnly = true;
            txtHo.ReadOnly =true;
            txtMa.ReadOnly = true;
            txtTen.ReadOnly = true;

        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma,quyen);
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
            int soca = 0;
           // conn.Open();
            if(radA.Checked)
            {
                try
                {
                    soca = 30;
                    conn.Open();
                    string sThemNV = @"update lamviec set soca = @SoCa where manv = @MaNV";
                    SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                    cmThemNV.Parameters.AddWithValue("@MaNV", txtMa.Text);
                    cmThemNV.Parameters.AddWithValue("@SoCa", soca.ToString());

                    cmThemNV.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Bạn Đã Chọn Ca Thành Công");
                }
                catch { MessageBox.Show("Không Đăng Ký Ca Thành Công"); }
            }
            else if(radB.Checked)
            {
                try { 
                soca = 30;
                conn.Open();
                string sThemNV = @"update lamviec set soca = @SoCa where manv = @MaNV";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.AddWithValue("@MaNV", txtMa.Text);
                cmThemNV.Parameters.AddWithValue("@SoCa", soca.ToString());

                cmThemNV.ExecuteReader();
                conn.Close();
                MessageBox.Show("Bạn Đã Chọn Ca Thành Công");
                }
                catch { MessageBox.Show("Không Đăng Ký Ca Thành Công"); }
            }
            else
            {
                try { 
                soca = 60;
                conn.Open();
                string sThemNV = @"update lamviec set soca = @SoCa where manv = @MaNV";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.AddWithValue("@MaNV", txtMa.Text);
                cmThemNV.Parameters.AddWithValue("@SoCa", soca.ToString());

                cmThemNV.ExecuteReader();
                conn.Close();
                MessageBox.Show("Bạn Đã Chọn Ca Thành Công");
                }
                catch { MessageBox.Show("Không Đăng Ký Ca Thành Công"); }
            }
        }

       
    }
}
