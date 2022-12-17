namespace QuanLyNhanVien
{
    partial class FormChucVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenChucVu = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblHsPhuCap = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.txtHeSoPhuCap = new System.Windows.Forms.TextBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Chức Vụ";
            // 
            // lblTenChucVu
            // 
            this.lblTenChucVu.AutoSize = true;
            this.lblTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChucVu.Location = new System.Drawing.Point(54, 139);
            this.lblTenChucVu.Name = "lblTenChucVu";
            this.lblTenChucVu.Size = new System.Drawing.Size(114, 22);
            this.lblTenChucVu.TabIndex = 1;
            this.lblTenChucVu.Text = "Tên Chức Vụ";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(54, 80);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(110, 22);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Chức Vụ";
            // 
            // lblHsPhuCap
            // 
            this.lblHsPhuCap.AutoSize = true;
            this.lblHsPhuCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHsPhuCap.Location = new System.Drawing.Point(54, 198);
            this.lblHsPhuCap.Name = "lblHsPhuCap";
            this.lblHsPhuCap.Size = new System.Drawing.Size(122, 22);
            this.lblHsPhuCap.TabIndex = 1;
            this.lblHsPhuCap.Text = "Hệ số phụ cấp";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(293, 256);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(148, 43);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Location = new System.Drawing.Point(221, 136);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(350, 30);
            this.txtTenChucVu.TabIndex = 3;
            // 
            // txtHeSoPhuCap
            // 
            this.txtHeSoPhuCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeSoPhuCap.Location = new System.Drawing.Point(221, 199);
            this.txtHeSoPhuCap.Name = "txtHeSoPhuCap";
            this.txtHeSoPhuCap.Size = new System.Drawing.Size(350, 30);
            this.txtHeSoPhuCap.TabIndex = 3;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChucVu.Location = new System.Drawing.Point(221, 77);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(350, 30);
            this.txtMaChucVu.TabIndex = 3;
            // 
            // FormChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 331);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.txtHeSoPhuCap);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblHsPhuCap);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTenChucVu);
            this.Controls.Add(this.label1);
            this.Name = "FormChucVu";
            this.Text = "FormChucVu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenChucVu;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblHsPhuCap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.TextBox txtHeSoPhuCap;
        private System.Windows.Forms.TextBox txtMaChucVu;
    }
}