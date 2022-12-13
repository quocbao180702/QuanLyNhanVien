namespace QuanLyNhanVien
{
    partial class FormBaoCao
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
            this.dgBaoCao = new System.Windows.Forms.DataGridView();
            this.txtBaoCao = new System.Windows.Forms.TextBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên:";
            // 
            // dgBaoCao
            // 
            this.dgBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBaoCao.Location = new System.Drawing.Point(-2, 62);
            this.dgBaoCao.Name = "dgBaoCao";
            this.dgBaoCao.Size = new System.Drawing.Size(803, 387);
            this.dgBaoCao.TabIndex = 1;
            // 
            // txtBaoCao
            // 
            this.txtBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoCao.Location = new System.Drawing.Point(256, 15);
            this.txtBaoCao.Name = "txtBaoCao";
            this.txtBaoCao.Size = new System.Drawing.Size(255, 26);
            this.txtBaoCao.TabIndex = 2;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(537, 6);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(163, 43);
            this.btnBaoCao.TabIndex = 3;
            this.btnBaoCao.Text = "Xem Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.txtBaoCao);
            this.Controls.Add(this.dgBaoCao);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCao";
            this.Text = "BaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.dgBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBaoCao;
        private System.Windows.Forms.TextBox txtBaoCao;
        private System.Windows.Forms.Button btnBaoCao;
    }
}