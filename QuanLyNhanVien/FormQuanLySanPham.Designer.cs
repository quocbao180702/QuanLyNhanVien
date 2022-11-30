namespace QuanLyNhanVien
{
    partial class FormQuanLySanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuanLySanPham = new System.Windows.Forms.Label();
            this.datSp = new System.Windows.Forms.DataGridView();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.lblTenSp = new System.Windows.Forms.Label();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.LblSoLuong = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimSp = new System.Windows.Forms.TextBox();
            this.lblTimSp = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.datSp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLySanPham
            // 
            this.lblQuanLySanPham.AutoSize = true;
            this.lblQuanLySanPham.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLySanPham.ForeColor = System.Drawing.Color.Blue;
            this.lblQuanLySanPham.Location = new System.Drawing.Point(383, 9);
            this.lblQuanLySanPham.Name = "lblQuanLySanPham";
            this.lblQuanLySanPham.Size = new System.Drawing.Size(272, 37);
            this.lblQuanLySanPham.TabIndex = 0;
            this.lblQuanLySanPham.Text = "Quản Lý Sản Phẩm";
            // 
            // datSp
            // 
            this.datSp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datSp.Location = new System.Drawing.Point(12, 286);
            this.datSp.Name = "datSp";
            this.datSp.RowHeadersWidth = 51;
            this.datSp.RowTemplate.Height = 24;
            this.datSp.Size = new System.Drawing.Size(1076, 300);
            this.datSp.TabIndex = 1;
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(41, 66);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(118, 22);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã Sản Phẩm";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(177, 63);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(272, 30);
            this.txtMaSp.TabIndex = 3;
            // 
            // lblTenSp
            // 
            this.lblTenSp.AutoSize = true;
            this.lblTenSp.Location = new System.Drawing.Point(41, 124);
            this.lblTenSp.Name = "lblTenSp";
            this.lblTenSp.Size = new System.Drawing.Size(122, 22);
            this.lblTenSp.TabIndex = 2;
            this.lblTenSp.Text = "Tên Sản Phẩm";
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(177, 121);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(272, 30);
            this.txtTenSp.TabIndex = 3;
            // 
            // LblSoLuong
            // 
            this.LblSoLuong.AutoSize = true;
            this.LblSoLuong.Location = new System.Drawing.Point(41, 232);
            this.LblSoLuong.Name = "LblSoLuong";
            this.LblSoLuong.Size = new System.Drawing.Size(87, 22);
            this.LblSoLuong.TabIndex = 2;
            this.LblSoLuong.Text = "Số Lượng";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Location = new System.Drawing.Point(41, 179);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(79, 22);
            this.lblGiaTien.TabIndex = 2;
            this.lblGiaTien.Text = "Giá Tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(177, 176);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(272, 30);
            this.txtGiaTien.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(513, 86);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 38);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(513, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(130, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(513, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 38);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(824, 145);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(130, 38);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimSp
            // 
            this.txtTimSp.Location = new System.Drawing.Point(732, 94);
            this.txtTimSp.Name = "txtTimSp";
            this.txtTimSp.Size = new System.Drawing.Size(272, 30);
            this.txtTimSp.TabIndex = 3;
            // 
            // lblTimSp
            // 
            this.lblTimSp.AutoSize = true;
            this.lblTimSp.Location = new System.Drawing.Point(769, 66);
            this.lblTimSp.Name = "lblTimSp";
            this.lblTimSp.Size = new System.Drawing.Size(207, 22);
            this.lblTimSp.TabIndex = 2;
            this.lblTimSp.Text = "Nhập Sản Phẩm Cần Tìm";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(958, 232);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(177, 230);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(272, 30);
            this.numSoLuong.TabIndex = 6;
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 602);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.LblSoLuong);
            this.Controls.Add(this.lblTenSp);
            this.Controls.Add(this.txtTimSp);
            this.Controls.Add(this.txtMaSp);
            this.Controls.Add(this.lblTimSp);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.datSp);
            this.Controls.Add(this.lblQuanLySanPham);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLySanPham";
            this.Text = "Quản Lý Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.datSp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLySanPham;
        private System.Windows.Forms.DataGridView datSp;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label lblTenSp;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Label LblSoLuong;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimSp;
        private System.Windows.Forms.Label lblTimSp;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}