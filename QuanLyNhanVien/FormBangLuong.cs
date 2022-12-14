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
using System.Windows.Forms.VisualStyles;

namespace QuanLyNhanVien
{
    public partial class FormBangLuong : Form
    {
        public FormBangLuong()
        {
            InitializeComponent();
        }
        public FormBangLuong(string id, int quyen)
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
        string manv;
        float tongluong = 0;

        private void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True";
            string sQueryNhanVien = @"select  n.*, c.tencv, h.tench, l.soca, l.socanghi, l.luong from nhanvien n, chucvu c, cuahang h, lamviec l where n.macv=c.macv and n.mach = h.mach and l.manv = n.manv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgvLuong.DataSource = ds.Tables["tblDSNhanVien"];

            dgvLuong.Columns["manv"].HeaderText = "Mã Nhân Viên";
            dgvLuong.Columns["manv"].Width = 80;
            dgvLuong.Columns["holot"].HeaderText = "Họ Lót";
            dgvLuong.Columns["holot"].Width = 120;
            dgvLuong.Columns["tennv"].HeaderText = "Tên";
            dgvLuong.Columns["tennv"].Width = 70;
            dgvLuong.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgvLuong.Columns["gioitinh"].Width = 40;
            dgvLuong.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            dgvLuong.Columns["ngaysinh"].Width = 80;
            dgvLuong.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvLuong.Columns["sdt"].Width = 90;
            dgvLuong.Columns["email"].HeaderText = "Email";
            dgvLuong.Columns["email"].Width = 170;
            dgvLuong.Columns["luongcb"].HeaderText = "Lương Cơ Bản";
            dgvLuong.Columns["luongcb"].Width = 100;
            dgvLuong.Columns["diachi"].HeaderText = "Địa Chỉ";
            dgvLuong.Columns["diachi"].Width = 200;
            dgvLuong.Columns["tinh"].HeaderText = "Tỉnh";
            dgvLuong.Columns["tinh"].Width = 90;
            dgvLuong.Columns["tencv"].HeaderText = "Chức Vụ";
            dgvLuong.Columns["tencv"].Width = 80;
            dgvLuong.Columns["tench"].HeaderText = "Cửa Hàng";
            dgvLuong.Columns["tench"].Width = 250;
            dgvLuong.Columns["soca"].HeaderText = "Số Ca";
            dgvLuong.Columns["soca"].Width = 50;
            dgvLuong.Columns["socanghi"].HeaderText = "Số Ca Nghĩ";
            dgvLuong.Columns["socanghi"].Width = 50;
            dgvLuong.Columns["luong"].HeaderText = "Lương";
            dgvLuong.Columns["luong"].Width = 50;
            dgvLuong.Columns["mach"].Visible = false;
            dgvLuong.Columns["macv"].Visible = false;

            dgvLuong.RowsDefaultCellStyle.BackColor = Color.Pink;
            dgvLuong.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void FormBangLuong_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtSoCaLam.ReadOnly = true;
            txtLuong.ReadOnly = true;
            btnCapNhat.Enabled = false;
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvLuong.SelectedRows[0];
            lblInMa.Text = dr.Cells["manv"].Value.ToString();
            manv = dr.Cells["manv"].Value.ToString();
            lblInHovaTen.Text = dr.Cells["holot"].Value.ToString() + " " +dr.Cells["tennv"].Value.ToString();
            lblInPhai.Text = dr.Cells["gioitinh"].Value.ToString();
            lblInNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            lblInSDT.Text = dr.Cells["sdt"].Value.ToString();
            lblInEmail.Text = dr.Cells["email"].Value.ToString();
            lblInLuongCB.Text = dr.Cells["luongcb"].Value.ToString();
            lblInDiaChi.Text = dr.Cells["diachi"].Value.ToString();
            lblInTinh.Text = dr.Cells["tinh"].Value.ToString();
            lblInChucVu.Text = dr.Cells["tencv"].Value.ToString();
            lblInCuaHang.Text = dr.Cells["tench"].Value.ToString();
            txtSoCaLam.Text = dr.Cells["soca"].Value.ToString();
            txtSoCaNghi.Text = dr.Cells["socanghi"].Value.ToString();
            txtLuong.Text = dr.Cells["luong"].Value.ToString();
        }
        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            float calam = float.Parse(this.txtSoCaLam.Text);
            float canghi = float.Parse(this.txtSoCaNghi.Text);
            float l = float.Parse(lblInLuongCB.Text);
            if (canghi <= calam && canghi >= 0)
            {
                float sum = 0;
                sum = (l / 60) * (calam - canghi);
                tongluong = sum;
                this.txtLuong.Text = sum.ToString();
            }
            else
            {
                this.txtLuong.ResetText();
                MessageBox.Show("Nhập lại số ngày nghĩ bé hơn " + calam, "Thong Bao", MessageBoxButtons.OK);
            }
            btnCapNhat.Enabled = true;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.lblInMa.ResetText();
            this.lblInHovaTen.ResetText();
            this.lblInPhai.ResetText();
            this.lblInNgaySinh.ResetText();
            this.lblInSDT.ResetText();
            this.lblInEmail.ResetText();
            this.lblInLuongCB.ResetText();
            this.lblInDiaChi.ResetText();
            this.lblInTinh.ResetText();
            this.lblInChucVu.ResetText();
            this.lblInCuaHang.ResetText();
            this.txtLuong.ResetText();
            this.txtSoCaLam.ResetText();
            this.txtSoCaNghi.ResetText();
        }

        private void txtSoCaNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // có phải là kí tự điều khiển không? có phải là chữ không?
            {
                e.Handled = true; //bỏ qua những cú pháp không hợp lệ
                MessageBox.Show("Nhập lại số", "Thông Báo");
            }
        }

        private void tínhLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            btnTinhLuong_Click(sender, e);
        }

        private void làmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma,quyen);
            fthongtin.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                float luong = float.Parse(tongluong.ToString());
                conn.Open();
                string truyvan = @"update lamviec set socanghi = @SoCaNghi,  luong = @Luong where manv = @MaNV";
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                cmd.Parameters.AddWithValue("@MaNV", manv);
                cmd.Parameters.AddWithValue("@SoCaNghi", txtSoCaNghi.Text);
                cmd.Parameters.AddWithValue("Luong", luong.ToString());
                cmd.ExecuteReader();
                conn.Close();
                MessageBox.Show("Cập Nhật Thành Công");
            } catch { MessageBox.Show("Cập Nhật Không Thành Công"); }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma,quyen);
            fthongtin.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
