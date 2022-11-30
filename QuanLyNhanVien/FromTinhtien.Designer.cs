namespace QuanLyNhanVien
{
    partial class FromTinhtien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbHangHoa = new System.Windows.Forms.ComboBox();
            this.cbHienHH = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.nmDemHH = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDemHH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lsvBill);
            this.panel1.Location = new System.Drawing.Point(319, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 375);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmDemHH);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbHienHH);
            this.panel2.Controls.Add(this.cbHangHoa);
            this.panel2.Location = new System.Drawing.Point(319, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 56);
            this.panel2.TabIndex = 1;
            // 
            // cbHangHoa
            // 
            this.cbHangHoa.FormattingEnabled = true;
            this.cbHangHoa.Location = new System.Drawing.Point(3, 0);
            this.cbHangHoa.Name = "cbHangHoa";
            this.cbHangHoa.Size = new System.Drawing.Size(291, 21);
            this.cbHangHoa.TabIndex = 0;
            this.cbHangHoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbHienHH
            // 
            this.cbHienHH.FormattingEnabled = true;
            this.cbHienHH.Location = new System.Drawing.Point(3, 27);
            this.cbHienHH.Name = "cbHienHH";
            this.cbHienHH.Size = new System.Drawing.Size(291, 21);
            this.cbHienHH.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(300, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 43);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lsvBill
            // 
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(477, 374);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // nmDemHH
            // 
            this.nmDemHH.Location = new System.Drawing.Point(410, 18);
            this.nmDemHH.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDemHH.Name = "nmDemHH";
            this.nmDemHH.Size = new System.Drawing.Size(47, 20);
            this.nmDemHH.TabIndex = 3;
            this.nmDemHH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FromTinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FromTinhtien";
            this.Text = "FromTinhtien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDemHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbHienHH;
        private System.Windows.Forms.ComboBox cbHangHoa;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmDemHH;
    }
}