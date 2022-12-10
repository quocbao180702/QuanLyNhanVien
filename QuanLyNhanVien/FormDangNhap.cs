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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("QLNV");

        SqlConnection conn;
        SqlCommand cmd;

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
        }

        private void ckbShow_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbShow.Checked==true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from dangnhap where username='" + txtUsername.Text + "' and pass='" + txtPassword.Text + "'", conn);
            SqlDataReader dr =  cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                this.Hide();
                FormQuanLyNhanVien fquanly = new FormQuanLyNhanVien();
                fquanly.ShowDialog();
            }
            else
            {
                dr.Close();
                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
            // load du lieu
            cmd = conn.CreateCommand();
            cmd.CommandText = ""; // cau truy vấn
            cmd.ExecuteNonQuery(); // thực thi câu truy vấn
            // hoac là adapter.SelectCommand = cmd;*/

        /*  if(txtUsername.Text=="NQ001" && txtPassword.Text=="123")
          {
              this.Hide();
              FormQuanLyNhanVien frmnv = new FormQuanLyNhanVien();
              frmnv.ShowDialog();
          }
          else if(txtUsername.Text == "NK001" && txtPassword.Text=="123")
          {
              this.Hide();
              FormQuanLyNhanVien frmnv = new FormQuanLyNhanVien();
              frmnv.ShowDialog();
          }
          else
          {
              MessageBox.Show("đăng nhập thất bại");
          }*/

    private void btnQuenMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FromQuenMatKhau frmQMK = new FromQuenMatKhau();
            frmQMK.ShowDialog();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
