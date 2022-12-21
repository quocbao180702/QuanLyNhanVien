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
    public partial class FormCuaHang : Form
    {
        public FormCuaHang()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;


        public string them()
        {
            return txtTenCuaHang.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True";
            conn.Open();
            cmd = new SqlCommand("insert into cuahang values(@mach, @tench, @diachi)", conn);
            cmd.Parameters.AddWithValue("mach", txtMaCuaHang.Text);
            cmd.Parameters.AddWithValue("tench", txtTenCuaHang.Text);
            cmd.Parameters.AddWithValue("diachi", txtDCCuaHang.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Cửa Hàng Thành Công !!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void FormCuaHang_Load(object sender, EventArgs e)
        {
 
        }
    }
}
