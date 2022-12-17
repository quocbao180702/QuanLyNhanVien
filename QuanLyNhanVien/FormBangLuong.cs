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
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True");
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
            dgvLuong.DataSource = ds.Tables["tblDSNhanVien"];

            dgvLuong.Columns["manv"].HeaderText = "Mã Nhân Viên";
            dgvLuong.Columns["manv"].Width = 80;
            dgvLuong.Columns["holot"].HeaderText = "Họ Lót";
            dgvLuong.Columns["holot"].Width = 100;
            dgvLuong.Columns["tennv"].HeaderText = "Tên";
            dgvLuong.Columns["tennv"].Width = 50;
            dgvLuong.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvLuong.Columns["gioitinh"].Width = 40;
            dgvLuong.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvLuong.Columns["ngaysinh"].Width = 80;
            dgvLuong.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvLuong.Columns["sdt"].Width = 90;
            dgvLuong.Columns["email"].HeaderText = "Email";
            dgvLuong.Columns["email"].Width = 140;
            dgvLuong.Columns["luongcb"].HeaderText = "Lương Cơ Bản";
            dgvLuong.Columns["luongcb"].Width = 100;
            dgvLuong.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvLuong.Columns["diachi"].Width = 150;
            dgvLuong.Columns["tinh"].HeaderText = "Tỉnh";
            dgvLuong.Columns["tinh"].Width = 90;
            dgvLuong.Columns["tencv"].HeaderText = "Chức Vụ";
            dgvLuong.Columns["tencv"].Width = 80;
            dgvLuong.Columns["macv"].Visible = false;
        }

        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvLuong.SelectedRows[0];
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

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            int thanhtien = int.Parse(txtSoNgayLam.Text) * int.Parse(txtLuongCoBan.Text);
            txtLuong.Text = thanhtien.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.txtMa.ResetText();
            this.txtHo.ResetText();
            this.txtTen.ResetText();
            this.radNam.Checked = false;
            this.radNu.Checked = false;
            this.dtpNgaySinh.ResetText();
            this.txtSDT.ResetText();
            this.txtEmail.ResetText();
            this.txtLuongCoBan.ResetText();
            this.txtDiaChi.ResetText();
            this.cboTinh.ResetText();
            this.cmbChucVu.ResetText();
            this.txtLuong.ResetText();
            this.txtSoNgayLam.ResetText();
            txtSoNgayNghi.ResetText();
        }
    }
}
