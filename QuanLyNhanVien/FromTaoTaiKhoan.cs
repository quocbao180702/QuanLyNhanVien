using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }
        public FormTaoTaiKhoan(string id, int quyen)
        {
            InitializeComponent();
            this.id = id;
            this.quyen = quyen;
        }
        string id = "";
        int quyen = 0;

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        private void FromTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True");
            conn.Open();
        }
        public void TaoTaiKhoan()
        {
            if (txtMaNV.Text != string.Empty || txtMatKhau.Text != string.Empty || txtNhapLaiMatKhau.Text != string.Empty ||cboQuyen.Text!= string.Empty)
            {
                if (txtMatKhau.Text ==txtNhapLaiMatKhau.Text)
                {
                    cmd = new SqlCommand("select * from dangnhap where username='" + txtMaNV.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into dangnhap values(@username, @pass, @quyen)", conn);
                        cmd.Parameters.AddWithValue("username", txtMaNV.Text);
                        cmd.Parameters.AddWithValue("pass", txtMatKhau.Text);
                        cmd.Parameters.AddWithValue("quyen", cboQuyen.SelectedItem.ToString());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            TaoTaiKhoan();
            conn.Close();
        }

        private void MenuItemQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(id, quyen);
            fthongtin.ShowDialog();
            fthongtin.Close();
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboQuyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTaoTK_Click(sender, e);
            }
        }
    }
}
