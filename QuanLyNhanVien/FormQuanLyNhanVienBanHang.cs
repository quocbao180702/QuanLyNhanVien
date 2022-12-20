using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhanVien
{
    public partial class FormQuanLyNhanVienBanHang : Form
    {
        public FormQuanLyNhanVienBanHang()
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
            dgQLNhanVien.Columns["tench"].HeaderText = "Cửa Hàng";
            dgQLNhanVien.Columns["tench"].Width = 80;
            dgQLNhanVien.Columns["mach"].Visible = false;
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
            dr.Cells["mach"].Value = cboCuaHang.SelectedValue;
            dr.Cells["tench"].Value = cboCuaHang.Text;
        }
        //them
        public void Them()
        {
            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @SDT, @Email, @LuongCB, @Tinh, @DiaChi, @MaCV,@MaCH)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.Char, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "gioitinh");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
            cmThemNV.Parameters.Add("@SDT", SqlDbType.NVarChar, 10, "sdt");
            cmThemNV.Parameters.Add("@Email", SqlDbType.VarChar, 30, "email");
            cmThemNV.Parameters.Add("@LuongCB", SqlDbType.Float, 6, "luongcb");
            cmThemNV.Parameters.Add("@Tinh", SqlDbType.NVarChar, 15, "tinh");
            cmThemNV.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50, "diachi");

            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            cmThemNV.Parameters.Add("@MaCH", SqlDbType.NVarChar, 6, "mach");
            daNhanVien.InsertCommand = cmThemNV;
        }

        private void btnThem_Click(object sender, EventArgs e)
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
            row["tinh"] = cboTinh.SelectedValue;
            row["diachi"] = txtDiaChi.Text;
            row["macv"] = cmbChucVu.SelectedValue;
            row["mach"] = cboCuaHang.SelectedValue;
            ds.Tables["tblDSNhanVien"].Rows.Add(row);
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

        private void cboTimCuaHang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "Select * from NhanVien where mach = '" + cboCuaHang.SelectedValue + "'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            dgQLNhanVien.DataSource = dt;
            conn.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dgQLNhanVien.Rows.Count; i++)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into information(manv,holot,tennv,gioitinh,ngaysinh,luongcb,diachi,tinh,macv,mach)  values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @SDT, @Email, @LuongCB, @Tinh, @DiaChi, @MaCV,@MaCH)", conn);
                cmd.Parameters.AddWithValue("@MaNV", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@HoLot", dgQLNhanVien.Rows[i].Cells[1].Value);
                cmd.Parameters.AddWithValue("@TenNV", dgQLNhanVien.Rows[i].Cells[2].Value);
                cmd.Parameters.AddWithValue("@Phai", dgQLNhanVien.Rows[i].Cells[3].Value);
                cmd.Parameters.AddWithValue("@NgaySinh", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@SDT", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@Email", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@LuongCB", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@Tinh", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@DiaChi", dgQLNhanVien.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@MaCV", dgQLNhanVien.Rows[i].Cells[0].Value);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show("Successfully Added", "VINSMOKE MJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThemCuaHang_Click(object sender, EventArgs e)
        {
            FormCuaHang fcuahang = new FormCuaHang();
            fcuahang.ShowDialog();
            cboTimCuaHang.Items.Add(fcuahang.them());
            cboCuaHang.Items.Add(fcuahang.them());

        }

        private void btnXoaCuaHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            string xoa = cboTimCuaHang.SelectedValue.ToString();
            string query = "DELETE FROM cuahang WHERE tench = '" + xoa + "'";
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
            cboTimCuaHang.Items.Remove(xoa);
            cboCuaHang.Items.Remove(xoa);
        }
    }
}
