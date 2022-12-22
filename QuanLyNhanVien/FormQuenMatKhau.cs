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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhanVien
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet("dsQLNV");

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap fdangnhap = new frmDangNhap();
            fdangnhap.ShowDialog();
        }

        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select n.*, d.* from nhanvien n, dangnhap d where n.manv = '" + txtTenDangNhap.Text + "'" , conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string email = dr.GetValue(6).ToString();
                if (txtEmail.Text !=  email)
                {
                    MessageBox.Show(dr.GetValue(6).ToString());
                    conn.Close();
                }
                conn.Close();
                if(txtEmail.Text == email)
                {
                    conn.Open();
                    SqlCommand cmd2 = new SqlCommand("UPDATE dangnhap SET pass  = '0000' WHERE username = '" + txtTenDangNhap.Text + "'", conn);
                    cmd2.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Cập Nhập Thành Công Mật Khẩu Mới Là: 0000");
                }
            }


        }
    }
}
