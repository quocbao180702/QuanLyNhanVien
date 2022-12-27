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
    public partial class FormXemDanhSach : Form
    {
        public FormXemDanhSach()
        {
            InitializeComponent();
        }
        public FormXemDanhSach(string id,int quyen)
        {
            InitializeComponent();
            this.ma = id;
            this.quyen = quyen;
        }
        string ma = "";
        int quyen = 0;


        SqlConnection conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter dachucvu;
        SqlDataAdapter daNhanVien;

        private void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True";
            string sQueryNhanVien = @"select n.*, c.tencv, h.tench from nhanvien n, chucvu c, cuahang h where n.macv=c.macv and n.mach = h.mach";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgvDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

            dgvDSNhanVien.Columns["manv"].HeaderText = "Mã Nhân Viên";
            dgvDSNhanVien.Columns["manv"].Width = 80;
            dgvDSNhanVien.Columns["holot"].HeaderText = "Họ Lót";
            dgvDSNhanVien.Columns["holot"].Width = 120;
            dgvDSNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgvDSNhanVien.Columns["tennv"].Width = 70;
            dgvDSNhanVien.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvDSNhanVien.Columns["gioitinh"].Width = 40;
            dgvDSNhanVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvDSNhanVien.Columns["ngaysinh"].Width = 80;
            dgvDSNhanVien.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDSNhanVien.Columns["sdt"].Width = 90;
            dgvDSNhanVien.Columns["email"].HeaderText = "Email";
            dgvDSNhanVien.Columns["email"].Width = 170;
            dgvDSNhanVien.Columns["luongcb"].HeaderText = "Lương Cơ Bản";
            dgvDSNhanVien.Columns["luongcb"].Width = 100;
            dgvDSNhanVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvDSNhanVien.Columns["diachi"].Width = 200;
            dgvDSNhanVien.Columns["tinh"].HeaderText = "Tỉnh";
            dgvDSNhanVien.Columns["tinh"].Width = 90;
            dgvDSNhanVien.Columns["tencv"].HeaderText = "Chức Vụ";
            dgvDSNhanVien.Columns["tencv"].Width = 80;
            dgvDSNhanVien.Columns["tench"].HeaderText = "Cửa Hàng";
            dgvDSNhanVien.Columns["tench"].Width = 250;
            dgvDSNhanVien.Columns["mach"].Visible = false;
            dgvDSNhanVien.Columns["macv"].Visible = false;
            dgvDSNhanVien.RowsDefaultCellStyle.BackColor = Color.Pink;
            dgvDSNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void FormXemDanhSach_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dgvDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvDSNhanVien.SelectedRows[0];
            lblInMa.Text = dr.Cells["manv"].Value.ToString();
            lblInHoLot.Text = dr.Cells["holot"].Value.ToString();
            lblInTen.Text = dr.Cells["tennv"].Value.ToString();
            lblInPhai.Text = dr.Cells["gioitinh"].Value.ToString();
            lblInNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            lblInSDT.Text = dr.Cells["sdt"].Value.ToString();
            lblInEmail.Text = dr.Cells["email"].Value.ToString();
            lblInLuongCB.Text = dr.Cells["luongcb"].Value.ToString();
            lblInDiaChi.Text = dr.Cells["diachi"].Value.ToString();
            lblInTinh.Text = dr.Cells["tinh"].Value.ToString();
            lblInChucVu.Text = dr.Cells["tencv"].Value.ToString();
            lblInCuaHang.Text = dr.Cells["tench"].Value.ToString();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma);
            fthongtin.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
