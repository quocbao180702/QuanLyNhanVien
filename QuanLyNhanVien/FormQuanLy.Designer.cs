namespace QuanLyNhanVien
{
    partial class FormQuanLy
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
            this.grbLuaChon = new System.Windows.Forms.GroupBox();
            this.radQuanLyBanaHang = new System.Windows.Forms.RadioButton();
            this.radQuanLyKho = new System.Windows.Forms.RadioButton();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grbLuaChon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLuaChon
            // 
            this.grbLuaChon.Controls.Add(this.radQuanLyBanaHang);
            this.grbLuaChon.Controls.Add(this.radioButton1);
            this.grbLuaChon.Controls.Add(this.radQuanLyKho);
            this.grbLuaChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLuaChon.Location = new System.Drawing.Point(86, 48);
            this.grbLuaChon.Name = "grbLuaChon";
            this.grbLuaChon.Size = new System.Drawing.Size(539, 238);
            this.grbLuaChon.TabIndex = 0;
            this.grbLuaChon.TabStop = false;
            this.grbLuaChon.Text = "Chọn";
            // 
            // radQuanLyBanaHang
            // 
            this.radQuanLyBanaHang.AutoSize = true;
            this.radQuanLyBanaHang.Location = new System.Drawing.Point(51, 165);
            this.radQuanLyBanaHang.Name = "radQuanLyBanaHang";
            this.radQuanLyBanaHang.Size = new System.Drawing.Size(251, 26);
            this.radQuanLyBanaHang.TabIndex = 0;
            this.radQuanLyBanaHang.Text = "Cửa Hàng Trà Sửa Cần Thơ";
            this.radQuanLyBanaHang.UseVisualStyleBackColor = true;
            // 
            // radQuanLyKho
            // 
            this.radQuanLyKho.AutoSize = true;
            this.radQuanLyKho.Checked = true;
            this.radQuanLyKho.Location = new System.Drawing.Point(51, 49);
            this.radQuanLyKho.Name = "radQuanLyKho";
            this.radQuanLyKho.Size = new System.Drawing.Size(277, 26);
            this.radQuanLyKho.TabIndex = 0;
            this.radQuanLyKho.Text = "Cửa Hàng Trà Sửa Long Xuyên";
            this.radQuanLyKho.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(380, 332);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(96, 64);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(512, 332);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(109, 64);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(82, 332);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 64);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(51, 106);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(261, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Cửa Hàng Trà Sửa Châu Đốc";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 432);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.grbLuaChon);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormQuanLy";
            this.Text = "FormQuanLy";
            this.grbLuaChon.ResumeLayout(false);
            this.grbLuaChon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLuaChon;
        private System.Windows.Forms.RadioButton radQuanLyBanaHang;
        private System.Windows.Forms.RadioButton radQuanLyKho;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}