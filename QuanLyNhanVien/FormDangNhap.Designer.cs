namespace QuanLyNhanVien
{
    partial class frmDangNhap
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
            this.ckbShow = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.lblQuen = new System.Windows.Forms.Label();
            this.panelBar = new System.Windows.Forms.Panel();
            this.lblThoat = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbShow
            // 
            this.ckbShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbShow.AutoSize = true;
            this.ckbShow.BackColor = System.Drawing.Color.White;
            this.ckbShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbShow.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbShow.Location = new System.Drawing.Point(336, 373);
            this.ckbShow.Name = "ckbShow";
            this.ckbShow.Size = new System.Drawing.Size(91, 33);
            this.ckbShow.TabIndex = 19;
            this.ckbShow.Text = "Show";
            this.ckbShow.UseVisualStyleBackColor = false;
            this.ckbShow.CheckedChanged += new System.EventHandler(this.ckbShow_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(176, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(176, 229);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(255, 30);
            this.txtUsername.TabIndex = 18;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuenMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.ForeColor = System.Drawing.Color.Blue;
            this.btnQuenMK.Location = new System.Drawing.Point(293, 549);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(157, 38);
            this.btnQuenMK.TabIndex = 16;
            this.btnQuenMK.Text = "quên mật khẩu";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            this.btnQuenMK.Click += new System.EventHandler(this.btnQuenMK_Click);
            // 
            // lblQuen
            // 
            this.lblQuen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuen.AutoSize = true;
            this.lblQuen.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuen.Location = new System.Drawing.Point(41, 553);
            this.lblQuen.Name = "lblQuen";
            this.lblQuen.Size = new System.Drawing.Size(232, 26);
            this.lblQuen.TabIndex = 15;
            this.lblQuen.Text = "Bạn đã quên mật khẩu";
            // 
            // panelBar
            // 
            this.panelBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBar.Controls.Add(this.lblThoat);
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(462, 40);
            this.panelBar.TabIndex = 14;
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseMove);
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.BackColor = System.Drawing.Color.Red;
            this.lblThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoat.Location = new System.Drawing.Point(435, 9);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(24, 22);
            this.lblThoat.TabIndex = 0;
            this.lblThoat.Text = "X";
            this.lblThoat.Click += new System.EventHandler(this.lblThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(104, 435);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(259, 56);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblPass
            // 
            this.lblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(28, 305);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(120, 40);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(28, 224);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(131, 40);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(94, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 56);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Đăng Nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::QuanLyNhanVien.Properties.Resources._240_F_417777825_v7o8RvkQhxpZkE0ZBD4xwzri5hGFHkO3;
            this.ClientSize = new System.Drawing.Size(462, 623);
            this.Controls.Add(this.ckbShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.lblQuen);
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbShow;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnQuenMK;
        private System.Windows.Forms.Label lblQuen;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Label lblThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
    }
}

