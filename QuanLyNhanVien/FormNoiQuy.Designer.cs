namespace QuanLyNhanVien
{
    partial class FormNoiQuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoiQuy));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNq1 = new System.Windows.Forms.Label();
            this.lblNq2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ckbDaHieu = new System.Windows.Forms.CheckBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(455, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội Quy";
            // 
            // lblNq1
            // 
            this.lblNq1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNq1.Location = new System.Drawing.Point(42, 75);
            this.lblNq1.Name = "lblNq1";
            this.lblNq1.Size = new System.Drawing.Size(1056, 96);
            this.lblNq1.TabIndex = 1;
            this.lblNq1.Text = resources.GetString("lblNq1.Text");
            // 
            // lblNq2
            // 
            this.lblNq2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNq2.Location = new System.Drawing.Point(43, 180);
            this.lblNq2.Name = "lblNq2";
            this.lblNq2.Size = new System.Drawing.Size(1055, 159);
            this.lblNq2.TabIndex = 1;
            this.lblNq2.Text = resources.GetString("lblNq2.Text");
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1040, 124);
            this.label7.TabIndex = 1;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1051, 140);
            this.label9.TabIndex = 3;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 656);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1051, 99);
            this.label11.TabIndex = 3;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // ckbDaHieu
            // 
            this.ckbDaHieu.AutoSize = true;
            this.ckbDaHieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDaHieu.ForeColor = System.Drawing.Color.MediumBlue;
            this.ckbDaHieu.Location = new System.Drawing.Point(46, 758);
            this.ckbDaHieu.Name = "ckbDaHieu";
            this.ckbDaHieu.Size = new System.Drawing.Size(324, 26);
            this.ckbDaHieu.TabIndex = 4;
            this.ckbDaHieu.Text = "Đã hiểu rõ nội quy định của cửa hàng";
            this.ckbDaHieu.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnQuayLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(381, 806);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(311, 55);
            this.btnQuayLai.TabIndex = 5;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNoiQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1110, 873);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.ckbDaHieu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblNq2);
            this.Controls.Add(this.lblNq1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNoiQuy";
            this.Text = "FormNoiQuy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNq1;
        private System.Windows.Forms.Label lblNq2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckbDaHieu;
        private System.Windows.Forms.Button btnQuayLai;
    }
}