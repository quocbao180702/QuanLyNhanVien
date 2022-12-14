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
    public partial class FormQuanLyNhanVienBanHang : Form
    {
        public FormQuanLyNhanVienBanHang()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=GEEKAY;Initial Catalog=QLNV;Integrated Security=True");
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter dachucvu;
        SqlDataAdapter daNhanVien;

        private void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True";
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan  frmquanly = new FormThongTinTaiKhoan();
            frmquanly.ShowDialog();
        }

        private void FormQuanLyNhanVienBanHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
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
            cmbChucVu.Text = dr.Cells["tencv"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgQLNhanVien.SelectedRows)
            {
                dgQLNhanVien.Rows.RemoveAt(item.Index);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgQLNhanVien.SelectedRows[0];
            dr.Cells["manv"].Value = txtMa.Text;
            dr.Cells["holot"].Value = txtHo.Text;
            dr.Cells["tennv"].Value = txtTen.Text;
            if (radNu.Checked == true)
            {
                dr.Cells["gioitinh"].Value = "Nữ";
            }
            else
            {
                dr.Cells["gioitinh"].Value = "Nam";
            }
            dr.Cells["ngaysinh"].Value = dtpNgaySinh.Text;
            dr.Cells["sdt"].Value = txtSDT.Text;
            dr.Cells["email"].Value = txtEmail.Text;
            dr.Cells["luongcb"].Value = txtLuongCoBan.Text;
            dr.Cells["diachi"].Value = txtDiaChi.Text;
            dr.Cells["tinh"].Value = cboTinh.Text;
            ds.Tables["tblDSNhanVien"].Rows.Add(dr);
            dr.Cells["macv"].Value = cmbChucVu.SelectedValue;
            dr.Cells["tencv"].Value = cmbChucVu.Text;
        }
    }
}
