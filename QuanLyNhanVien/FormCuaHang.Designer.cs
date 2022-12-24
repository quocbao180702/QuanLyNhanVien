namespace QuanLyNhanVien
{
    partial class FormCuaHang
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
            this.txtMaCuaHang = new System.Windows.Forms.TextBox();
            this.txtDCCuaHang = new System.Windows.Forms.TextBox();
            this.txtTenCuaHang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblHsPhuCap = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTenChucVu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaCuaHang
            // 
            this.txtMaCuaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuaHang.Location = new System.Drawing.Point(223, 86);
            this.txtMaCuaHang.Name = "txtMaCuaHang";
            this.txtMaCuaHang.Size = new System.Drawing.Size(165, 30);
            this.txtMaCuaHang.TabIndex = 9;
            // 
            // txtDCCuaHang
            // 
            this.txtDCCuaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDCCuaHang.Location = new System.Drawing.Point(223, 208);
            this.txtDCCuaHang.Name = "txtDCCuaHang";
            this.txtDCCuaHang.Size = new System.Drawing.Size(350, 30);
            this.txtDCCuaHang.TabIndex = 10;
            this.txtDCCuaHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDCCuaHang_KeyDown);
            // 
            // txtTenCuaHang
            // 
            this.txtTenCuaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCuaHang.Location = new System.Drawing.Point(223, 145);
            this.txtTenCuaHang.Name = "txtTenCuaHang";
            this.txtTenCuaHang.Size = new System.Drawing.Size(350, 30);
            this.txtTenCuaHang.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(295, 265);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 43);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblHsPhuCap
            // 
            this.lblHsPhuCap.AutoSize = true;
            this.lblHsPhuCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsPhuCap.Location = new System.Drawing.Point(56, 208);
            this.lblHsPhuCap.Name = "lblHsPhuCap";
            this.lblHsPhuCap.Size = new System.Drawing.Size(156, 22);
            this.lblHsPhuCap.TabIndex = 5;
            this.lblHsPhuCap.Text = "Địa Chỉ Cửa Hàng";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(56, 89);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(120, 22);
            this.lblMa.TabIndex = 6;
            this.lblMa.Text = "Mã Cửa Hàng";
            // 
            // lblTenChucVu
            // 
            this.lblTenChucVu.AutoSize = true;
            this.lblTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChucVu.Location = new System.Drawing.Point(56, 148);
            this.lblTenChucVu.Name = "lblTenChucVu";
            this.lblTenChucVu.Size = new System.Drawing.Size(124, 22);
            this.lblTenChucVu.TabIndex = 7;
            this.lblTenChucVu.Text = "Tên Cửa Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(237, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thêm Cửa Hàng";
            // 
            // FormCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 336);
            this.Controls.Add(this.txtMaCuaHang);
            this.Controls.Add(this.txtDCCuaHang);
            this.Controls.Add(this.txtTenCuaHang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblHsPhuCap);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTenChucVu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCuaHang";
            this.Text = "FormCuaHang";
            this.Load += new System.EventHandler(this.FormCuaHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaCuaHang;
        private System.Windows.Forms.TextBox txtDCCuaHang;
        private System.Windows.Forms.TextBox txtTenCuaHang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblHsPhuCap;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTenChucVu;
        private System.Windows.Forms.Label label1;
    }
}