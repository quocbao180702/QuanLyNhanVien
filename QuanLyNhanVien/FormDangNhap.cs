using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frmDangNhap : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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
                    string id = txtUsername.Text;
                    int quyen = int.Parse(dr.GetValue(2).ToString());
                    dr.Close();
                    this.Hide();
                    FormThongTinTaiKhoan fquanly = new FormThongTinTaiKhoan(id, quyen);
                    fquanly.ShowDialog();
                    this.Close();
 
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
            FormQuenMatKhau frmQMK = new FormQuenMatKhau();
            frmQMK.ShowDialog();
            this.Close();
        }

        // thoat
        private void lblThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Duy chuyển form 
        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelBar_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }
    }
}
