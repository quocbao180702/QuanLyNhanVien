using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyNhanVien
{
    public partial class FormQuanLyNhanVienBanHang : Form
    {
        public FormQuanLyNhanVienBanHang()
        {
            InitializeComponent();
        }
        public FormQuanLyNhanVienBanHang(string id, int quyen)
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
        SqlDataAdapter daCuaHang;

        private void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True";
            string sQueryNhanVien = @"select n.*, c.tencv, h.tench from nhanvien n, chucvu c, cuahang h where n.macv=c.macv and h.mach = n.mach";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgQLNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

            dgQLNhanVien.Columns["manv"].HeaderText = "Mã Nhân Viên";
            dgQLNhanVien.Columns["manv"].Width = 80;
            //dgQLNhanVien.Columns["manv"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["holot"].HeaderText = "Họ Lót";
            //dgQLNhanVien.Columns["holot"].Width = 100;
            dgQLNhanVien.Columns["holot"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["tennv"].HeaderText = "Tên";
            // dgQLNhanVien.Columns["tennv"].Width = 50;
            dgQLNhanVien.Columns["tennv"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["gioitinh"].HeaderText = "Giới Tính";
            dgQLNhanVien.Columns["gioitinh"].Width = 40;
           // dgQLNhanVien.Columns["giotinh"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["ngaysinh"].HeaderText = "Ngày Sinh";
            //dgQLNhanVien.Columns["ngaysinh"].Width = 80;
            dgQLNhanVien.Columns["ngaysinh"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["sdt"].HeaderText = "Số Điện Thoại";
            //dgQLNhanVien.Columns["sdt"].Width = 90;
            dgQLNhanVien.Columns["sdt"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["email"].HeaderText = "Email";
            //dgQLNhanVien.Columns["email"].Width = 140;
            dgQLNhanVien.Columns["email"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["luongcb"].HeaderText = "Lương Cơ Bản";
            //dgQLNhanVien.Columns["luongcb"].Width = 100;
            dgQLNhanVien.Columns["luongcb"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["diachi"].HeaderText = "Địa Chỉ";
            //dgQLNhanVien.Columns["diachi"].Width = 150;
            dgQLNhanVien.Columns["diachi"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["tinh"].HeaderText = "Tỉnh";
            //dgQLNhanVien.Columns["tinh"].Width = 90;
            dgQLNhanVien.Columns["tinh"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["tencv"].HeaderText = "Chức Vụ";
            //dgQLNhanVien.Columns["tencv"].Width = 80;
            dgQLNhanVien.Columns["tencv"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;

            dgQLNhanVien.Columns["macv"].Visible = false;
            dgQLNhanVien.Columns["tench"].HeaderText = "Cửa Hàng";
            //dgQLNhanVien.Columns["tench"].Width = 80;
            dgQLNhanVien.Columns["tench"].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dgQLNhanVien.Columns["mach"].Visible = false;

            dgQLNhanVien.RowsDefaultCellStyle.BackColor = Color.Pink;
            dgQLNhanVien.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

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
            cboCuaHang.DataSource = dt;
            cboCuaHang.DisplayMember = "tench";
            cboCuaHang.ValueMember = "mach";
            cboTimCuaHang.DataSource = dt;
            cboTimCuaHang.DisplayMember = "tench";
            cboTimCuaHang.ValueMember = "mach";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan frmquanly = new FormThongTinTaiKhoan();
            frmquanly.ShowDialog();
        }

        private void FormQuanLyNhanVienBanHang_Load(object sender, EventArgs e)
        {
            loadcombox_chucvu();
            loadcombox_cuahang();
            LoadDataGridView();
           
        }

        private void dgQLNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgQLNhanVien.SelectedRows[0];
            txtMa.Text = dr.Cells["manv"].Value.ToString();
            txtHo.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["gioitinh"].Value.ToString() == "Nam")
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
            cboCuaHang.Text = dr.Cells["tench"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloixoa;
            traloixoa = MessageBox.Show("Bạn có muốn xóa nhân viên không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloixoa == DialogResult.OK)
            {
                DataGridViewRow dr = dgQLNhanVien.SelectedRows[0];
                SqlCommand cmXoaNV = new SqlCommand("delete from dangnhap\r\nwhere username = @MaNV;\r\ndelete from lamviec\r\nwhere manv = @MaNV;\r\ndelete from NhanVien\r\nwhere manv = @MaNV;", conn);
                conn.Open();
                cmXoaNV.Parameters.AddWithValue("@MaNV", dr.Cells["manv"].Value);
                cmXoaNV.Parameters.AddWithValue("@HoLot", dr.Cells["holot"].Value);
                cmXoaNV.Parameters.AddWithValue("@TenNV", dr.Cells["tennv"].Value);
                cmXoaNV.Parameters.AddWithValue("@GioiTinh", dr.Cells["gioitinh"].Value);
                cmXoaNV.Parameters.AddWithValue("@NgaySinh", dr.Cells["ngaysinh"].Value);
                cmXoaNV.Parameters.AddWithValue("@SDT", dr.Cells["sdt"].Value);
                cmXoaNV.Parameters.AddWithValue("@Email", dr.Cells["email"].Value);
                cmXoaNV.Parameters.AddWithValue("@LuongCB", dr.Cells["luongcb"].Value);
                cmXoaNV.Parameters.AddWithValue("@Tinh", dr.Cells["tinh"].Value);
                cmXoaNV.Parameters.AddWithValue("@DiaChi", dr.Cells["diachi"].Value);
                cmXoaNV.Parameters.AddWithValue("@MaCV", dr.Cells["macv"].Value);
                cmXoaNV.Parameters.AddWithValue("@MaCH", dr.Cells["mach"].Value);
                cmXoaNV.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");
                foreach (DataGridViewRow item in this.dgQLNhanVien.SelectedRows)
                {
                    dgQLNhanVien.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn sửa nhân viên không không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select * from nhanvien where manv =  '" + txtMa.Text + "'", conn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    MessageBox.Show("Mã đã tồn  tại ");
                    conn.Close();
                }
                else
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
                    dr.Cells["macv"].Value = cmbChucVu.SelectedValue;
                    dr.Cells["tencv"].Value = cmbChucVu.Text;
                    dr.Cells["mach"].Value = cboCuaHang.SelectedValue;
                    dr.Cells["tench"].Value = cboCuaHang.Text;
                    conn.Open();
                    string sThemNV = @"update nhanvien set manv = @MaNV, holot = @HoLot, tennv = @TenNV, gioitinh = @GioiTinh, ngaysinh = @NgaySinh,sdt =  @SDT, email =  @Email, luongcb = @LuongCB, tinh = @Tinh, diachi = @DiaChi, macv =  @MaCV, mach = @MaCH  where manv = @MaNV";
                    SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                    cmThemNV.Parameters.AddWithValue("@MaNV", dr.Cells["manv"].Value);
                    cmThemNV.Parameters.AddWithValue("@HoLot", dr.Cells["holot"].Value);
                    cmThemNV.Parameters.AddWithValue("@TenNV", dr.Cells["tennv"].Value);
                    cmThemNV.Parameters.AddWithValue("@GioiTinh", dr.Cells["gioitinh"].Value);
                    cmThemNV.Parameters.AddWithValue("@NgaySinh", dr.Cells["ngaysinh"].Value);
                    cmThemNV.Parameters.AddWithValue("@SDT", dr.Cells["sdt"].Value);
                    cmThemNV.Parameters.AddWithValue("@Email", dr.Cells["email"].Value);
                    cmThemNV.Parameters.AddWithValue("@LuongCB", dr.Cells["luongcb"].Value);
                    cmThemNV.Parameters.AddWithValue("@Tinh", dr.Cells["tinh"].Value);
                    cmThemNV.Parameters.AddWithValue("@DiaChi", dr.Cells["diachi"].Value);
                    cmThemNV.Parameters.AddWithValue("@MaCV", dr.Cells["macv"].Value);
                    cmThemNV.Parameters.AddWithValue("@MaCH", dr.Cells["mach"].Value);
                    cmThemNV.ExecuteReader();
                    conn.Close();
                }
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("select * from nhanvien where manv =  '" + txtMa.Text + "'", conn);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã đã tồn  tại ");
                conn.Close();
            }
            else
            {
                DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
                row["manv"] = txtMa.Text;
                row["holot"] = txtHo.Text;
                row["tennv"] = txtTen.Text;
                if (radNu.Checked == true)
                {
                    row["gioitinh"] = "Nữ";

                }
                else
                {
                    row["gioitinh"] = "Nam";

                }
                row["ngaysinh"] = dtpNgaySinh.Text;
                row["sdt"] = txtSDT.Text;
                row["email"] = txtEmail.Text;
                row["luongcb"] = txtLuongCoBan.Text;
                row["diachi"] = txtDiaChi.Text;
                row["tinh"] = cboTinh.Text;
                row["macv"] = cmbChucVu.SelectedValue;
                row["tencv"] = cmbChucVu.Text;
                row["mach"] = cboCuaHang.SelectedValue;
                row["tench"] = cboCuaHang.Text;
                ds.Tables["tblDSNhanVien"].Rows.Add(row);
                conn.Close();
                conn.Open();
                string truyvan = @"Insert Into NhanVien VALUES  (N'" + row["manv"].ToString() + @"',N'" + row["holot"].ToString() + "',N'" + row["tennv"].ToString() + "',N'" + row["gioitinh"].ToString() + "',N'" + row["ngaysinh"].ToString() + "',N'" + row["sdt"].ToString() + "',N'" + row["email"].ToString() + "',N'" + row["luongcb"].ToString() + "',N'" + row["diachi"].ToString() + "',N'" + row["tinh"].ToString() + "',N'" + row["macv"].ToString() + "',N'" + row["mach"].ToString() + "')";
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                string truyvan2 = @"Insert into lamviec values('" + row["manv"].ToString() + "'," + 30+ "," + 0 + "," + row["luongcb"].ToString() + ",N'" + row["mach"].ToString() + "')";
                SqlCommand cmd2 = new SqlCommand(truyvan2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
        
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectquery = "select * from nhanvien where manv = '" + txtTim.Text + "'";
            SqlCommand cmd = new SqlCommand(selectquery, conn);
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
                txtLuongCoBan.Text = dr.GetValue(7).ToString();
                cboTinh.Text = dr.GetValue(8).ToString();
                txtDiaChi.Text = dr.GetValue(9).ToString();
                cmbChucVu.Text = dr.GetValue(10).ToString();
                cboCuaHang.Text = dr.GetValue(11).ToString();
            }
            else
            {
                MessageBox.Show("NO DATA FOUND");
            }
            conn.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn reset không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
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
                this.cboCuaHang.ResetText();
            }
        }


        private void btnThemCuaHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCuaHang fcuahang = new FormCuaHang(ma,quyen);
            fcuahang.ShowDialog();
            this.Close();

        }

        private void btnXoaCuaHang_Click(object sender, EventArgs e)
        {
            DialogResult traloixoach;
            traloixoach = MessageBox.Show("Bạn có muốn xóa cửa hàng không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloixoach == DialogResult.OK)
            {
                conn.Open();
                string xoa = cboTimCuaHang.SelectedValue.ToString();
                string query = "DELETE FROM cuahang WHERE mach = '" + xoa + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED SUCCESSFULLY");
                }
                else
                {
                    MessageBox.Show("DATA NOT UPDATED SUCCESSFULLY");
                }
                conn.Close();
                loadcombox_cuahang();
            }
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan frmquanly = new FormThongTinTaiKhoan(ma,quyen);
            frmquanly.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "select n.*, c.tencv, h.tench from nhanvien n, chucvu c, cuahang h where n.macv = c.macv and h.mach = n.mach and h.mach= '" + cboTimCuaHang.SelectedValue + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgQLNhanVien.DataSource = dt;
            conn.Close();
        }

        private void nộiQuyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNoiQuy fnoiquy = new FormNoiQuy(ma, quyen);
            fnoiquy.ShowDialog();
            this.Close();
        }

        private void bảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBangLuong fbangluong = new FormBangLuong(ma, quyen);
            fbangluong.ShowDialog();
            this.Close();
        }
    }
}
