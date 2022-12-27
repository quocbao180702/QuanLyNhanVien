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
        SqlConnection conn = new SqlConnection(@"Data Source=GeeKay;Initial Catalog=QLNV;Integrated Security=True");
        DataSet ds = new DataSet("dsQLNV");


        public string them()
        {
            return txtTenCuaHang.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
            conn.Open();    
            SqlCommand cmd1 = new SqlCommand("select * from cuahang where mach =  '" +txtMaCuaHang.Text+ "'",conn);
            SqlDataReader dr =  cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Mã đã tồn  tại ");
                conn.Close();
            }
            else 
            {
                conn.Close();
                conn.Open();
                string truyvan = @"Insert Into cuahang (mach, tench, diachi) VALUES  (N'" + txtMaCuaHang.Text + @"',N'" + txtTenCuaHang.Text + @"',N'" + txtDCCuaHang.Text + @"')";
                cmd = new SqlCommand(truyvan, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Add Cửa Hàng Thành Công !!!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void FormCuaHang_Load(object sender, EventArgs e)
        {
 
        }


        private void txtDCCuaHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem_Click(sender, e);
            }
        }
    }
}
