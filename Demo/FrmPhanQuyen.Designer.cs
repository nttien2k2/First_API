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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_XoaTaiKhoan = new System.Windows.Forms.Button();
            this.btn_XoaQuyen = new System.Windows.Forms.Button();
            this.btn_CapQuyenUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TaiKhoan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_Bang = new System.Windows.Forms.ComboBox();
            this.cbb_NhanVien = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_NhomQuyen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_Quyen = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_ntt1 = new Demo.Controls.TextBox_NTT();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbb_TaiKhoan);
            this.panel4.Location = new System.Drawing.Point(472, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 167);
            this.panel4.TabIndex = 0;
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
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài khoản";
            // 
            // cbb_TaiKhoan
            // 
            this.cbb_TaiKhoan.FormattingEnabled = true;
            this.cbb_TaiKhoan.Location = new System.Drawing.Point(128, 41);
            this.cbb_TaiKhoan.Name = "cbb_TaiKhoan";
            this.cbb_TaiKhoan.Size = new System.Drawing.Size(151, 28);
            this.cbb_TaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bảng ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhân Viên";
            // 
            // cbb_Bang
            // 
            this.cbb_Bang.FormattingEnabled = true;
            this.cbb_Bang.Location = new System.Drawing.Point(182, 57);
            this.cbb_Bang.Name = "cbb_Bang";
            this.cbb_Bang.Size = new System.Drawing.Size(151, 28);
            this.cbb_Bang.TabIndex = 2;
            // 
            // cbb_NhanVien
            // 
            this.cbb_NhanVien.FormattingEnabled = true;
            this.cbb_NhanVien.Location = new System.Drawing.Point(182, 12);
            this.cbb_NhanVien.Name = "cbb_NhanVien";
            this.cbb_NhanVien.Size = new System.Drawing.Size(151, 28);
            this.cbb_NhanVien.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbb_NhomQuyen);
            this.panel1.Location = new System.Drawing.Point(472, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 168);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 57);
            this.panel2.TabIndex = 23;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(232, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 48);
            this.button7.TabIndex = 25;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(160, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 48);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(88, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 48);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(13, 3);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(5);
            this.button6.Size = new System.Drawing.Size(59, 48);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhóm quyền";
            // 
            // cbb_NhomQuyen
            // 
            this.cbb_NhomQuyen.FormattingEnabled = true;
            this.cbb_NhomQuyen.Location = new System.Drawing.Point(129, 38);
            this.cbb_NhomQuyen.Name = "cbb_NhomQuyen";
            this.cbb_NhomQuyen.Size = new System.Drawing.Size(151, 28);
            this.cbb_NhomQuyen.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quyền";
            // 
            // cbb_Quyen
            // 
            this.cbb_Quyen.FormattingEnabled = true;
            this.cbb_Quyen.Location = new System.Drawing.Point(182, 103);
            this.cbb_Quyen.Name = "cbb_Quyen";
            this.cbb_Quyen.Size = new System.Drawing.Size(151, 28);
            this.cbb_Quyen.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tên nhóm quyền";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.button10);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(366, 57);
            this.panel6.TabIndex = 23;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(156, 3);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 48);
            this.button10.TabIndex = 23;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(81, 3);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5);
            this.button11.Size = new System.Drawing.Size(59, 48);
            this.button11.TabIndex = 0;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_ntt1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(71, 217);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 167);
            this.panel3.TabIndex = 25;
            // 
            // textBox_ntt1
            // 
            this.textBox_ntt1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ntt1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox_ntt1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_ntt1.BorderRadius = 8;
            this.textBox_ntt1.BorderSize = 1;
            this.textBox_ntt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_ntt1.Location = new System.Drawing.Point(148, 38);
            this.textBox_ntt1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ntt1.Multiline = true;
            this.textBox_ntt1.Name = "textBox_ntt1";
            this.textBox_ntt1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_ntt1.PasswordChar = false;
            this.textBox_ntt1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_ntt1.PlaceholderText = "";
            this.textBox_ntt1.Size = new System.Drawing.Size(150, 40);
            this.textBox_ntt1.TabIndex = 24;
            this.textBox_ntt1.Texts = "";
            this.textBox_ntt1.UnderlinedStyle = false;
            // 
            // FrmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 396);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cbb_NhanVien);
            this.Controls.Add(this.cbb_Quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_Bang);
            this.Name = "FrmPhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_Bang;
        private ComboBox cbb_TaiKhoan;
        private ComboBox cbb_NhanVien;
        private Panel panel5;
        private Button btn_XoaTaiKhoan;
        private Button btn_XoaQuyen;
        private Button btn_CapQuyenUser;
        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label5;
        private Label label7;
        private ComboBox cbb_Quyen;
        private ComboBox cbb_NhomQuyen;
        private Label label11;
        private Panel panel6;
        private Button button10;
        private Button button11;
        private Panel panel3;
        private Controls.TextBox_NTT textBox_ntt1;
    }
}