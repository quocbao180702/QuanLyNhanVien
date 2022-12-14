using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace QuanLyNhanVien
{
    public partial class FormQuanLyNhanVienKho : Form
    {
        public FormQuanLyNhanVienKho()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter dachucvu;
        SqlDataAdapter daNhanVien;

        private void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True";
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgQLNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

            dgQLNhanVien.Columns["manv"].HeaderText = "Mã Nhân Viên";
            dgQLNhanVien.Columns["manv"].Width = 80;
            dgQLNhanVien.Columns["holot"].HeaderText = "Họ Lót";
            dgQLNhanVien.Columns["holot"].Width = 100;
            dgQLNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgQLNhanVien.Columns["tennv"].Width = 50;
            dgQLNhanVien.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgQLNhanVien.Columns["gioitinh"].Width = 40;
            dgQLNhanVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgQLNhanVien.Columns["ngaysinh"].Width = 80;
            dgQLNhanVien.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgQLNhanVien.Columns["sdt"].Width = 90;
            dgQLNhanVien.Columns["email"].HeaderText = "Email";
            dgQLNhanVien.Columns["email"].Width = 140;
            dgQLNhanVien.Columns["luongcb"].HeaderText = "Lương Cơ Bản";
            dgQLNhanVien.Columns["luongcb"].Width = 100;
            dgQLNhanVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgQLNhanVien.Columns["diachi"].Width = 150;
            dgQLNhanVien.Columns["tinh"].HeaderText = "Tỉnh";
            dgQLNhanVien.Columns["tinh"].Width = 90;
            dgQLNhanVien.Columns["tencv"].HeaderText = "Chức Vụ";
            dgQLNhanVien.Columns["tencv"].Width = 80;
            dgQLNhanVien.Columns["macv"].Visible = false;
        }

        private void FormQuanLyNhanVienKho_Load(object sender, EventArgs e)
        {
           // loadcomboTim();
            LoadDataGridView();
            Them();
        }
        private void loadcomboTim()
        {
           /* daNhanVien = new SqlDataAdapter("Select * from NhanVien", conn);
            DataTable dt = new DataTable();
            daNhanVien.Fill(dt);
            daNhanVien.Dispose();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = dt.Columns["manv"].ToString();
            comboBox1.ValueMember = dt.Columns["manv"].ToString();*/
        }
        private void dgQLNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgQLNhanVien.SelectedRows[0];
            txtMa.Text = dr.Cells["manv"].Value.ToString();
            txtHo.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["gioitinh"].Value.ToString() == "nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            txtSDT.Text = dr.Cells["sdt"].Value.ToString();
            txtEmail.Text = dr.Cells["email"].Value.ToString();
            txtLuongCoBan.Text = dr.Cells["luongcb"].Value.ToString();
            txtDiaChi.Text = dr.Cells["diachi"].Value.ToString();
            cboTinh.Text = dr.Cells["tinh"].Value.ToString();
            cmbChucVu.Text = dr.Cells["macv"].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* string sql = "select * from NhanVien," + comboBox1.Text;
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            comboBox1.DataSource = dt;
            LoadDataGridView();*/
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMa.Text;
            row["holot"] = txtHo.Text;
            row["tennv"] = txtTen.Text;
            if (radNu.Checked == true)
            {
                row["gioitinh"] = "nu";
            }
            else
            {
                row["gioitinh"] = "nam";
            }
            row["ngaysinh"] = dtpNgaySinh.Text;
            row["sdt"] = txtSDT.Text;
            row["email"] = txtEmail.Text;
            row["luongcb"] = txtLuongCoBan.Text;
            row["tinh"] = cboTinh.SelectedValue;
            row["diachi"] = txtDiaChi.Text;
            row["macv"] = cmbChucVu.SelectedValue;
            ds.Tables["tblDSNhanVien"].Rows.Add(row);
        }
        public void Them()
        {
            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @SDT, @Email, @LuongCB, @Tinh, @DiaChi, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.Char, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "gioitinh");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,"ngaysinh");
            cmThemNV.Parameters.Add("@SDT", SqlDbType.NVarChar,10 , "sdt");
            cmThemNV.Parameters.Add("@Email", SqlDbType.VarChar, 30, "email");
            cmThemNV.Parameters.Add("@LuongCB", SqlDbType.Float,6, "luongcb");
            cmThemNV.Parameters.Add("@Tinh", SqlDbType.NVarChar, 15, "tinh");
            cmThemNV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "diachi");

            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.InsertCommand = cmThemNV;
        }

    }
}

