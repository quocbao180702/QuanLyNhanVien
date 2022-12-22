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
    public partial class FormThongTinTaiKhoan : Form
    {
        public FormThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        int quyen = 0;
        string id = "";
        SqlConnection conn;
        SqlCommand cmd;

        public FormThongTinTaiKhoan(string id, int q)
        {
            InitializeComponent();
            this.id = id;
            this.quyen = q;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void FormThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            if (quyen == 2)
            {
                MenuItemQuanLy.Visible = false;
            }
            if (quyen == 3)
            {
                MenuItemQuanLy.Visible = false;
                MenuQuanLyLuong.Visible = false;
            }
            conn = new SqlConnection(@"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("select n.*, c.tencv, h.tench from NhanVien n, chucvu c, cuahang h where n.macv=c.macv and n.mach = h.mach and n.manv = '" + id + "'", conn);
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
                txtSDT.Text = dr.GetValue(5).ToString();
                dtpNgaySinh.Text = dr.GetValue(4).ToString();
                txtEmail.Text = dr.GetValue(6).ToString();
                txtLuongCB.Text = dr.GetValue(7).ToString();
                cmbTinh.Text = dr.GetValue(9).ToString();
                txtDiaChi.Text = dr.GetValue(8).ToString();
                cmbChucVu.Text = dr.GetValue(12).ToString();
                cmbCuaHang.Text = dr.GetValue(13).ToString();
            }
            conn.Close();
        }

        private void MenuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fdangnhap = new frmDangNhap();
            fdangnhap.ShowDialog();
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemXem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXemDanhSach fxem = new FormXemDanhSach();
            fxem.ShowDialog();
            this.Close();
        }

        private void MenuItemQuanLy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLyNhanVienBanHang fquanly = new FormQuanLyNhanVienBanHang();
            fquanly.ShowDialog();
            this.Close();
        }

        private void MenuItemDangKyCa_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKyCa fdangkyca = new FormDangKyCa();
            fdangkyca.ShowDialog();
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void nộiQuyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNoiQuy fnoiquy = new FormNoiQuy();
            fnoiquy.ShowDialog();
            this.Close();
        }

        private void quảnLyLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBangLuong fbangluong = new FormBangLuong();
            fbangluong.ShowDialog();
            this.Close();
        }
    }
}
