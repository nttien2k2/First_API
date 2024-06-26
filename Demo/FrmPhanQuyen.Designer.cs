namespace Demo
{
    partial class FrmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPhanQuyen));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_XoaTaiKhoan = new System.Windows.Forms.Button();
            this.btn_XoaQuyen = new System.Windows.Forms.Button();
            this.btn_CapQuyenUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.cbb_Quyen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_XoaNhomQuyen = new System.Windows.Forms.Button();
            this.btn_ThemNhomQuyen = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_NhomQuyen = new System.Windows.Forms.ComboBox();
            this.txt_NhomQuyen = new Demo.Controls.TextBox_NTT();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_Thoat = new System.Windows.Forms.ToolStripButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_NhanVien = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Bang = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbb_TaiKhoan);
            this.panel4.Controls.Add(this.cbb_Quyen);
            this.panel4.Location = new System.Drawing.Point(485, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 167);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quyền";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_XoaTaiKhoan);
            this.panel5.Controls.Add(this.btn_XoaQuyen);
            this.panel5.Controls.Add(this.btn_CapQuyenUser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 57);
            this.panel5.TabIndex = 23;
            // 
            // btn_XoaTaiKhoan
            // 
            this.btn_XoaTaiKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaTaiKhoan.Location = new System.Drawing.Point(245, 3);
            this.btn_XoaTaiKhoan.Name = "btn_XoaTaiKhoan";
            this.btn_XoaTaiKhoan.Size = new System.Drawing.Size(104, 47);
            this.btn_XoaTaiKhoan.TabIndex = 24;
            this.btn_XoaTaiKhoan.Text = "Xóa User";
            this.btn_XoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btn_XoaTaiKhoan.Click += new System.EventHandler(this.btn_XoaTaiKhoan_Click);
            // 
            // btn_XoaQuyen
            // 
            this.btn_XoaQuyen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaQuyen.Location = new System.Drawing.Point(130, 2);
            this.btn_XoaQuyen.Name = "btn_XoaQuyen";
            this.btn_XoaQuyen.Size = new System.Drawing.Size(100, 48);
            this.btn_XoaQuyen.TabIndex = 23;
            this.btn_XoaQuyen.Text = "Thu hồi";
            this.btn_XoaQuyen.UseVisualStyleBackColor = false;
            this.btn_XoaQuyen.Click += new System.EventHandler(this.btn_XoaQuyen_Click);
            // 
            // btn_CapQuyenUser
            // 
            this.btn_CapQuyenUser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_CapQuyenUser.Location = new System.Drawing.Point(16, 3);
            this.btn_CapQuyenUser.Name = "btn_CapQuyenUser";
            this.btn_CapQuyenUser.Padding = new System.Windows.Forms.Padding(5);
            this.btn_CapQuyenUser.Size = new System.Drawing.Size(100, 48);
            this.btn_CapQuyenUser.TabIndex = 0;
            this.btn_CapQuyenUser.Text = "Cấp quyền";
            this.btn_CapQuyenUser.UseVisualStyleBackColor = false;
            this.btn_CapQuyenUser.Click += new System.EventHandler(this.btn_CapQuyenUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // cbb_TaiKhoan
            // 
            this.cbb_TaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TaiKhoan.FormattingEnabled = true;
            this.cbb_TaiKhoan.Location = new System.Drawing.Point(122, 13);
            this.cbb_TaiKhoan.Name = "cbb_TaiKhoan";
            this.cbb_TaiKhoan.Size = new System.Drawing.Size(151, 28);
            this.cbb_TaiKhoan.TabIndex = 1;
            // 
            // cbb_Quyen
            // 
            this.cbb_Quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Quyen.FormattingEnabled = true;
            this.cbb_Quyen.Location = new System.Drawing.Point(122, 46);
            this.cbb_Quyen.Name = "cbb_Quyen";
            this.cbb_Quyen.Size = new System.Drawing.Size(151, 28);
            this.cbb_Quyen.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(220, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên nhóm quyền";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_XoaNhomQuyen);
            this.panel6.Controls.Add(this.btn_ThemNhomQuyen);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(798, 57);
            this.panel6.TabIndex = 23;
            // 
            // btn_XoaNhomQuyen
            // 
            this.btn_XoaNhomQuyen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_XoaNhomQuyen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_XoaNhomQuyen.FlatAppearance.BorderSize = 2;
            this.btn_XoaNhomQuyen.Location = new System.Drawing.Point(403, 5);
            this.btn_XoaNhomQuyen.Name = "btn_XoaNhomQuyen";
            this.btn_XoaNhomQuyen.Padding = new System.Windows.Forms.Padding(5);
            this.btn_XoaNhomQuyen.Size = new System.Drawing.Size(139, 48);
            this.btn_XoaNhomQuyen.TabIndex = 1;
            this.btn_XoaNhomQuyen.Text = "Xóa nhóm quyền";
            this.btn_XoaNhomQuyen.UseVisualStyleBackColor = false;
            this.btn_XoaNhomQuyen.Click += new System.EventHandler(this.btn_XoaNhomQuyen_Click);
            // 
            // btn_ThemNhomQuyen
            // 
            this.btn_ThemNhomQuyen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ThemNhomQuyen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ThemNhomQuyen.FlatAppearance.BorderSize = 2;
            this.btn_ThemNhomQuyen.Location = new System.Drawing.Point(258, 4);
            this.btn_ThemNhomQuyen.Name = "btn_ThemNhomQuyen";
            this.btn_ThemNhomQuyen.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ThemNhomQuyen.Size = new System.Drawing.Size(139, 48);
            this.btn_ThemNhomQuyen.TabIndex = 0;
            this.btn_ThemNhomQuyen.Text = "Thêm mới";
            this.btn_ThemNhomQuyen.UseVisualStyleBackColor = false;
            this.btn_ThemNhomQuyen.Click += new System.EventHandler(this.btn_ThemNhomQuyen_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cbb_NhomQuyen);
            this.panel3.Controls.Add(this.txt_NhomQuyen);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(51, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 167);
            this.panel3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nhóm quyền";
            // 
            // cbb_NhomQuyen
            // 
            this.cbb_NhomQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NhomQuyen.FormattingEnabled = true;
            this.cbb_NhomQuyen.Location = new System.Drawing.Point(345, 61);
            this.cbb_NhomQuyen.Name = "cbb_NhomQuyen";
            this.cbb_NhomQuyen.Size = new System.Drawing.Size(151, 28);
            this.cbb_NhomQuyen.TabIndex = 25;
            // 
            // txt_NhomQuyen
            // 
            this.txt_NhomQuyen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NhomQuyen.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_NhomQuyen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_NhomQuyen.BorderRadius = 5;
            this.txt_NhomQuyen.BorderSize = 1;
            this.txt_NhomQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NhomQuyen.Location = new System.Drawing.Point(345, 19);
            this.txt_NhomQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NhomQuyen.Multiline = true;
            this.txt_NhomQuyen.Name = "txt_NhomQuyen";
            this.txt_NhomQuyen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_NhomQuyen.PasswordChar = false;
            this.txt_NhomQuyen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_NhomQuyen.PlaceholderText = "";
            this.txt_NhomQuyen.Size = new System.Drawing.Size(150, 35);
            this.txt_NhomQuyen.TabIndex = 24;
            this.txt_NhomQuyen.UnderlinedStyle = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_Refresh,
            this.toolStripBtn_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(874, 50);
            this.toolStrip1.TabIndex = 26;
            // 
            // toolStripBtn_Refresh
            // 
            this.toolStripBtn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Refresh.Image")));
            this.toolStripBtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Refresh.Name = "toolStripBtn_Refresh";
            this.toolStripBtn_Refresh.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Refresh.Size = new System.Drawing.Size(115, 47);
            this.toolStripBtn_Refresh.Text = " Refresh";
            this.toolStripBtn_Refresh.Click += new System.EventHandler(this.toolStripBtn_Refresh_Click);
            // 
            // toolStripBtn_Thoat
            // 
            this.toolStripBtn_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.toolStripBtn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripBtn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripBtn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_Thoat.Image")));
            this.toolStripBtn_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_Thoat.Name = "toolStripBtn_Thoat";
            this.toolStripBtn_Thoat.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripBtn_Thoat.Size = new System.Drawing.Size(103, 47);
            this.toolStripBtn_Thoat.Text = " Thoát";
            this.toolStripBtn_Thoat.Click += new System.EventHandler(this.toolStripBtn_Thoat_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.cbb_NhanVien);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.cbb_Bang);
            this.panel7.Location = new System.Drawing.Point(51, 65);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(368, 167);
            this.panel7.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bảng ";
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(164, 24);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(151, 28);
            this.cbb_NhanVien.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhân Viên";
            // 
            // cbb_Bang
            // 
            this.cbb_Bang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Bang.FormattingEnabled = true;
            this.cbb_Bang.Location = new System.Drawing.Point(164, 69);
            this.cbb_Bang.Name = "cbb_Bang";
            this.cbb_Bang.Size = new System.Drawing.Size(151, 28);
            this.cbb_Bang.TabIndex = 9;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 461);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label label2;
        private ComboBox cbb_TaiKhoan;
        private Panel panel5;
        private Button btn_XoaTaiKhoan;
        private Button btn_XoaQuyen;
        private Button btn_CapQuyenUser;
        private Label label11;
        private Panel panel6;
        private Button btn_ThemNhomQuyen;
        private Panel panel3;
        private Controls.TextBox_NTT txt_NhomQuyen;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtn_Refresh;
        private ToolStripButton toolStripBtn_Thoat;
        private Panel panel7;
        private Label label5;
        private Label label3;
        private ComboBox cbb_NhanVien;
        private ComboBox cbb_Quyen;
        private Label label1;
        private ComboBox cbb_Bang;
        private Label label7;
        private ComboBox cbb_NhomQuyen;
        private Button btn_XoaNhomQuyen;
    }
}