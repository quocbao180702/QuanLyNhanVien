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
        SqlDataAdapter dachucvu;
        SqlDataAdapter daCuaHang;


        public FormThongTinTaiKhoan(string id, int q)
        {
            InitializeComponent();
            this.id = id;
            this.quyen = q;
        }
        public FormThongTinTaiKhoan(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void loadcombox_chucvu()
        {
            string sQueryChucVu = @"select * from chucvu";
            DataTable dt = new DataTable();
            dachucvu = new SqlDataAdapter(sQueryChucVu, conn);
            dachucvu.Fill(dt);
            cmbChucVu.DataSource = dt;
            cmbChucVu.DisplayMember = "tencv";
            cmbChucVu.ValueMember = "macv";

        }
        public void loadcombox_cuahang()
        {
            string sQueryChucVu = @"select * from cuahang";
            DataTable dt = new DataTable();
            daCuaHang = new SqlDataAdapter(sQueryChucVu, conn);
            daCuaHang.Fill(dt);
            cmbCuaHang.DataSource = dt;
            cmbCuaHang.DisplayMember = "tench";
            cmbCuaHang.ValueMember = "mach";
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
            if(quyen == 1)
            {
                MenuItemQuanLy.Visible = true;
                MenuQuanLyLuong.Visible = true;
            }
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();

            loadcombox_chucvu();
            loadcombox_cuahang();
            cmd = new SqlCommand("select n.*, c.tencv, h.tench, l.* from NhanVien n, chucvu c, cuahang h, lamviec l where n.macv=c.macv and n.mach = h.mach and l.manv= n.manv and n.manv = '" + id + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMa.Text = dr.GetValue(0).ToString(); 
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
                txtCaNghi.Text = dr.GetValue(16).ToString();
                txtSoNgay.Text = dr.GetValue(15).ToString();
                txtLuong.Text =  dr.GetValue(17).ToString();
            }
            conn.Close();
        }

        private void MenuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fdangnhap = new frmDangNhap();
            fdangnhap.ShowDialog();
            this.Close();
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
            FormDangKyCa fdangkyca = new FormDangKyCa(id);
            fdangkyca.ShowDialog();
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh = "";
                if (radNam.Checked == true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "Nữ";
                }

                conn.Open();
                string sThemNV = @"update nhanvien set manv = @MaNV, holot = @HoLot, tennv = @TenNV, gioitinh = @GioiTinh, ngaysinh = @NgaySinh,sdt =  @SDT, email =  @Email, luongcb = @LuongCB, tinh = @Tinh, diachi = @DiaChi, macv =  @MaCV, mach = @MaCH  where manv = @MaNV";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.AddWithValue("@MaNV", txtMa.Text);
                cmThemNV.Parameters.AddWithValue("@HoLot", txtHo.Text);
                cmThemNV.Parameters.AddWithValue("@TenNV", txtTen.Text);
                cmThemNV.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmThemNV.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Text);
                cmThemNV.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmThemNV.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmThemNV.Parameters.AddWithValue("@LuongCB", txtLuongCB.Text);
                cmThemNV.Parameters.AddWithValue("@Tinh", cmbTinh.SelectedItem);
                cmThemNV.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmThemNV.Parameters.AddWithValue("@MaCV", cmbChucVu.SelectedValue);
                cmThemNV.Parameters.AddWithValue("@MaCH", cmbCuaHang.SelectedValue);
                cmThemNV.ExecuteReader();
                conn.Close();
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch { MessageBox.Show("Cập Nhật Không Thành Công"); }
            
        }

        private void nộiQuyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNoiQuy fnoiquy = new FormNoiQuy(id);
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
