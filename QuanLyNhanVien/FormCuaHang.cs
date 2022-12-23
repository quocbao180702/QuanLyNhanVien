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
       // SqlConnection conn;
        SqlCommand cmd;
        SqlConnection conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
        DataSet ds = new DataSet("dsQLNV");


        public string them()
        {
            return txtTenCuaHang.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            string truyvan = @"Insert Into cuahang (mach, tench, diachi) VALUES  (N'" + txtMaCuaHang.Text + @"',N'" + txtTenCuaHang.Text + @"',N'" + txtDCCuaHang.Text + @"')";
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Add Cửa Hàng Thành Công !!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
        }

        private void FormCuaHang_Load(object sender, EventArgs e)
        {
 
        }
    }
}
