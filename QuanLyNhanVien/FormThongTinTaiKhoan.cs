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
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();

            cmd = new SqlCommand("select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv and manv = '" + id + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMa.Text = dr.GetValue(0).ToString(); ;
                txtHo.Text = dr.GetValue(1).ToString();
                txtTen.Text = dr.GetValue(2).ToString();
                if (dr.GetValue(3).ToString() == "nam")
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
                cmbTinh.Text = dr.GetValue(8).ToString();
                txtDiaChi.Text = dr.GetValue(9).ToString();
                cmbChucVu.Text = dr.GetValue(11).ToString();
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
            if(quyen==1)
            {
                this.Close();
                FormQuanLy fquanly = new FormQuanLy();
                fquanly.ShowDialog();
            }
            else if(quyen == 2)
            {
                this.Hide();
                FormQuanLyNhanVienBanHang fquanlybh = new FormQuanLyNhanVienBanHang();
                fquanlybh.ShowDialog();
            }
        }

        private void MenuItemQuanLy_Click(object sender, EventArgs e)
        {
            this.Close();
            FormQuanLy fquanly = new FormQuanLy();
            fquanly.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }
    }
}
