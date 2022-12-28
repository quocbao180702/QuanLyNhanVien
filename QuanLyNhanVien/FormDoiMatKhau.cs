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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        public FormDoiMatKhau(string id, int quyen)
        {
            InitializeComponent();
            this.id = id;
            this.quyen = quyen;
        }
        string id = "";
        int quyen = 0;

        SqlConnection conn;
        SqlCommand cmd;

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            DialogResult traloisua;
            traloisua = MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloisua == DialogResult.OK)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("select n.*, d.* from NhanVien n, dangnhap d where n.manv = d.username and d.username ='" + txtTenDangNhap.Text + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string email = dr.GetValue(6).ToString();
                    string matkhau = dr.GetValue(12).ToString();
                    conn.Close();
                    if (email != txtEmail.Text || matkhau != txtMatKhau.Text)
                    {
                        MessageBox.Show("Email hoặc mật khẩu không đúng");
                        MessageBox.Show(matkhau);
                        MessageBox.Show(email);
                    }
                    else
                    {
                        if (txtMatKhauMoi.Text == txtNhapLai.Text)
                        {
                            conn.Open();
                            SqlCommand cmd2 = new SqlCommand("UPDATE dangnhap SET pass  = '" + txtMatKhauMoi.Text + "' WHERE username = '" + txtTenDangNhap.Text + "'", conn);
                            cmd2.ExecuteReader();
                            conn.Close();
                            MessageBox.Show("Cập Nhập Thành Công Mật Khẩu Mới");
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại mật khẩu không đúng");
                        }
                    }
                }
            }
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMatKhau fquen = new FormQuenMatKhau();
            fquen.ShowDialog();
            this.Close();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(id, quyen);
            fthongtin.ShowDialog();
            fthongtin.Close();
        }
    }
}
