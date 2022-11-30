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
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }
        DataSet sp = new DataSet("dsQLNV");

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = sp.Tables["tblDSSanPham"].NewRow();
            row["masp"] = txtMaSp.Text;
            row["tensp"] = txtTenSp.Text;
            row["giatien"] = txtGiaTien.Text;
            row["soluong"] = numSoLuong.Value;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }
    }
}
