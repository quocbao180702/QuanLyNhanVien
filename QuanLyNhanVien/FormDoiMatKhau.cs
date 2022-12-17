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
        SqlConnection conn;
        SqlCommand cmd;

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select n.*, d.* from NhanVien n, dangnhap d where n.manv = d.username and d.username ='" + txtTenDangNhap.Text + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string email = dr.GetValue(6).ToString();
                if (txtEmail.Text != email || txtMatKhau.Text != dr.GetValue(12).ToString())
                {
                    MessageBox.Show("Email hoặc mật khẩu không đúng");
                    MessageBox.Show(dr.GetValue(12).ToString());
                }
                if(txtEmail.Text == email && txtMatKhau.Text == dr.GetValue(12).ToString())
                {
                    conn.Close();
                    if (txtMatKhauMoi.Text == txtNhapLai.Text) {
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

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMatKhau fquen = new FormQuenMatKhau();
            fquen.ShowDialog();
        }
    }
}
