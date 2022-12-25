using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        public FormThongKe(string id, int quyen)
        {
            InitializeComponent();
            this.ma = id;
            this.quyen = quyen;
        }
        string ma = "";
        int quyen = 0;

        SqlConnection conn = new SqlConnection(@"Data Source=BAODANG;Initial Catalog=QLNV;Integrated Security=True");
        void Fillchart()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT\r\n\t\tcuahang.tench,\r\n      sum(lamviec.socanghi) as socanghi\r\nFROM lamviec\r\nINNER JOIN cuahang ON lamviec.mach = cuahang.mach\r\nGROUP BY\r\n\t\t cuahang.tench", conn);
            da.Fill(dt);
            chart1.DataSource = dt;
            conn.Close();

            chart1.Series["socanghi"].XValueMember = "tench";
            chart1.Series["socanghi"].YValueMembers = "socanghi";
            chart1.Titles.Add("Thống kê Số Ca Nghĩ của Nhân Viên Từng Của Hàng");
        }

        void Fillchart1()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT\r\n\t\tcuahang.tench,\r\n      sum(lamviec.luong) as luong\r\nFROM lamviec\r\nINNER JOIN cuahang ON lamviec.mach = cuahang.mach\r\nGROUP BY\r\n\t\t cuahang.tench", conn);
            da.Fill(dt);
            chart2.DataSource = dt;
            conn.Close();

            chart2.Series["luong"].XValueMember = "tench";
            chart2.Series["luong"].YValueMembers = "luong";
            chart2.Titles.Add("Thống kê Tổng Lương Của Nhân Viên Từng Của Hàng");
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            Fillchart();
            Fillchart1();
        }

        private void MenuItemQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongTinTaiKhoan fthongtin = new FormThongTinTaiKhoan(ma, quyen);
            fthongtin.ShowDialog();
            this.Close();
        }

        private void MenuItemThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
