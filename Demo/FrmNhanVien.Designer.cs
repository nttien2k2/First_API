namespace Demo
{
    partial class FrmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhanVien));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripbtn_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtn_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtn_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.txt_SoLuongNV = new Demo.Controls.TextBox_NTT();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new Demo.Controls.TextBox_NTT();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_AnhDaiDien = new System.Windows.Forms.Button();
            this.cbb_NhomQuyen = new System.Windows.Forms.ComboBox();
            this.txt_HocVan = new Demo.Controls.TextBox_NTT();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new Demo.Controls.TextBox_NTT();
            this.txt_Email = new Demo.Controls.TextBox_NTT();
            this.txt_Tuoi = new Demo.Controls.TextBox_NTT();
            this.txt_SDT = new Demo.Controls.TextBox_NTT();
            this.txt_HoTen = new Demo.Controls.TextBox_NTT();
            this.txt_CCCD = new Demo.Controls.TextBox_NTT();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaNV = new Demo.Controls.TextBox_NTT();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripBtn_PrintNV = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.pn_Container.SuspendLayout();
            this.pn_Main.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripbtn_Them,
            this.toolStripbtn_Luu,
            this.toolStripbtn_Xoa,
            this.toolStripbtn_Refresh,
            this.toolStripBtn_PrintNV,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(950, 50);
            this.toolStrip1.TabIndex = 1;
            // 
            // toolStripbtn_Them
            // 
            this.toolStripbtn_Them.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripbtn_Them.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_Them.Image")));
            this.toolStripbtn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_Them.Name = "toolStripbtn_Them";
            this.toolStripbtn_Them.Size = new System.Drawing.Size(111, 47);
            this.toolStripbtn_Them.Text = "Thêm mới";
            this.toolStripbtn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // toolStripbtn_Luu
            // 
            this.toolStripbtn_Luu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripbtn_Luu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripbtn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_Luu.Image")));
            this.toolStripbtn_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_Luu.Name = "toolStripbtn_Luu";
            this.toolStripbtn_Luu.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripbtn_Luu.Size = new System.Drawing.Size(82, 47);
            this.toolStripbtn_Luu.Text = "Lưu";
            this.toolStripbtn_Luu.Click += new System.EventHandler(this.toolStripbtn_Luu_Click);
            // 
            // toolStripbtn_Xoa
            // 
            this.toolStripbtn_Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripbtn_Xoa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripbtn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_Xoa.Image")));
            this.toolStripbtn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_Xoa.Name = "toolStripbtn_Xoa";
            this.toolStripbtn_Xoa.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripbtn_Xoa.Size = new System.Drawing.Size(83, 47);
            this.toolStripbtn_Xoa.Text = "Xóa";
            this.toolStripbtn_Xoa.Click += new System.EventHandler(this.toolStripbtn_Xoa_Click);
            // 
            // toolStripbtn_Refresh
            // 
            this.toolStripbtn_Refresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripbtn_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripbtn_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbtn_Refresh.Image")));
            this.toolStripbtn_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbtn_Refresh.Name = "toolStripbtn_Refresh";
            this.toolStripbtn_Refresh.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripbtn_Refresh.Size = new System.Drawing.Size(110, 47);
            this.toolStripbtn_Refresh.Text = "Refresh";
            this.toolStripbtn_Refresh.Click += new System.EventHandler(this.toolStripbtn_Refresh_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton4.Size = new System.Drawing.Size(98, 47);
            this.toolStripButton4.Text = "Thoát";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // pn_Container
            // 
            this.pn_Container.BackColor = System.Drawing.SystemColors.Control;
            this.pn_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pn_Container.Controls.Add(this.pn_Main);
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 50);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(950, 810);
            this.pn_Container.TabIndex = 3;
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.Color.White;
            this.pn_Main.Controls.Add(this.txt_SoLuongNV);
            this.pn_Main.Controls.Add(this.btn_Search);
            this.pn_Main.Controls.Add(this.txt_Search);
            this.pn_Main.Controls.Add(this.label2);
            this.pn_Main.Controls.Add(this.panel5);
            this.pn_Main.Controls.Add(this.cbb_NhomQuyen);
            this.pn_Main.Controls.Add(this.txt_HocVan);
            this.pn_Main.Controls.Add(this.label1);
            this.pn_Main.Controls.Add(this.txt_DiaChi);
            this.pn_Main.Controls.Add(this.txt_Email);
            this.pn_Main.Controls.Add(this.txt_Tuoi);
            this.pn_Main.Controls.Add(this.txt_SDT);
            this.pn_Main.Controls.Add(this.txt_HoTen);
            this.pn_Main.Controls.Add(this.txt_CCCD);
            this.pn_Main.Controls.Add(this.panel4);
            this.pn_Main.Controls.Add(this.label6);
            this.pn_Main.Controls.Add(this.label7);
            this.pn_Main.Controls.Add(this.label10);
            this.pn_Main.Controls.Add(this.label8);
            this.pn_Main.Controls.Add(this.label9);
            this.pn_Main.Controls.Add(this.label5);
            this.pn_Main.Controls.Add(this.txt_MaNV);
            this.pn_Main.Controls.Add(this.label4);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(0, 0);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(950, 810);
            this.pn_Main.TabIndex = 0;
            // 
            // txt_SoLuongNV
            // 
            this.txt_SoLuongNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_SoLuongNV.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_SoLuongNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SoLuongNV.BorderRadius = 5;
            this.txt_SoLuongNV.BorderSize = 1;
            this.txt_SoLuongNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoLuongNV.Location = new System.Drawing.Point(4, 597);
            this.txt_SoLuongNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuongNV.Multiline = false;
            this.txt_SoLuongNV.Name = "txt_SoLuongNV";
            this.txt_SoLuongNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SoLuongNV.PasswordChar = false;
            this.txt_SoLuongNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SoLuongNV.PlaceholderText = "";
            this.txt_SoLuongNV.Size = new System.Drawing.Size(48, 38);
            this.txt_SoLuongNV.TabIndex = 92;
            this.txt_SoLuongNV.UnderlinedStyle = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(296, 361);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(94, 35);
            this.btn_Search.TabIndex = 91;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Search.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 5;
            this.txt_Search.BorderSize = 1;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(98, 360);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "";
            this.txt_Search.Size = new System.Drawing.Size(190, 38);
            this.txt_Search.TabIndex = 90;
            this.txt_Search.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(329, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 89;
            this.label2.Text = "Chức vụ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.btn_AnhDaiDien);
            this.panel5.Location = new System.Drawing.Point(662, 206);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(219, 56);
            this.panel5.TabIndex = 70;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(116, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 48);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_AnhDaiDien
            // 
            this.btn_AnhDaiDien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_AnhDaiDien.Image = ((System.Drawing.Image)(resources.GetObject("btn_AnhDaiDien.Image")));
            this.btn_AnhDaiDien.Location = new System.Drawing.Point(41, 3);
            this.btn_AnhDaiDien.Name = "btn_AnhDaiDien";
            this.btn_AnhDaiDien.Padding = new System.Windows.Forms.Padding(5);
            this.btn_AnhDaiDien.Size = new System.Drawing.Size(55, 48);
            this.btn_AnhDaiDien.TabIndex = 0;
            this.btn_AnhDaiDien.UseVisualStyleBackColor = false;
            this.btn_AnhDaiDien.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_NhomQuyen
            // 
            this.cbb_NhomQuyen.FormattingEnabled = true;
            this.cbb_NhomQuyen.Location = new System.Drawing.Point(419, 234);
            this.cbb_NhomQuyen.Name = "cbb_NhomQuyen";
            this.cbb_NhomQuyen.Size = new System.Drawing.Size(190, 28);
            this.cbb_NhomQuyen.TabIndex = 88;
            // 
            // txt_HocVan
            // 
            this.txt_HocVan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_HocVan.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_HocVan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_HocVan.BorderRadius = 5;
            this.txt_HocVan.BorderSize = 1;
            this.txt_HocVan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_HocVan.ForeColor = System.Drawing.Color.Black;
            this.txt_HocVan.Location = new System.Drawing.Point(98, 227);
            this.txt_HocVan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HocVan.Multiline = false;
            this.txt_HocVan.Name = "txt_HocVan";
            this.txt_HocVan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_HocVan.PasswordChar = false;
            this.txt_HocVan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_HocVan.PlaceholderText = "";
            this.txt_HocVan.Size = new System.Drawing.Size(190, 38);
            this.txt_HocVan.TabIndex = 87;
            this.txt_HocVan.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Học vấn";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_DiaChi.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_DiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DiaChi.BorderRadius = 5;
            this.txt_DiaChi.BorderSize = 1;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Location = new System.Drawing.Point(98, 299);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = false;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DiaChi.PasswordChar = false;
            this.txt_DiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(510, 38);
            this.txt_DiaChi.TabIndex = 85;
            this.txt_DiaChi.UnderlinedStyle = false;
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Email.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Email.BorderRadius = 5;
            this.txt_Email.BorderSize = 1;
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(419, 87);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Multiline = false;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Email.PasswordChar = false;
            this.txt_Email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.Size = new System.Drawing.Size(190, 38);
            this.txt_Email.TabIndex = 84;
            this.txt_Email.UnderlinedStyle = false;
            // 
            // txt_Tuoi
            // 
            this.txt_Tuoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Tuoi.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Tuoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Tuoi.BorderRadius = 5;
            this.txt_Tuoi.BorderSize = 1;
            this.txt_Tuoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Tuoi.ForeColor = System.Drawing.Color.Black;
            this.txt_Tuoi.Location = new System.Drawing.Point(419, 159);
            this.txt_Tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tuoi.Multiline = false;
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Tuoi.PasswordChar = false;
            this.txt_Tuoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Tuoi.PlaceholderText = "";
            this.txt_Tuoi.Size = new System.Drawing.Size(190, 38);
            this.txt_Tuoi.TabIndex = 83;
            this.txt_Tuoi.UnderlinedStyle = false;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_SDT.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_SDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_SDT.BorderRadius = 5;
            this.txt_SDT.BorderSize = 1;
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(419, 20);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Multiline = false;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SDT.PasswordChar = false;
            this.txt_SDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.Size = new System.Drawing.Size(190, 38);
            this.txt_SDT.TabIndex = 82;
            this.txt_SDT.UnderlinedStyle = false;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_HoTen.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_HoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_HoTen.BorderRadius = 5;
            this.txt_HoTen.BorderSize = 1;
            this.txt_HoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_HoTen.ForeColor = System.Drawing.Color.Black;
            this.txt_HoTen.Location = new System.Drawing.Point(98, 87);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = false;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_HoTen.PasswordChar = false;
            this.txt_HoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(190, 38);
            this.txt_HoTen.TabIndex = 81;
            this.txt_HoTen.UnderlinedStyle = false;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_CCCD.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_CCCD.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_CCCD.BorderRadius = 5;
            this.txt_CCCD.BorderSize = 1;
            this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CCCD.ForeColor = System.Drawing.Color.Black;
            this.txt_CCCD.Location = new System.Drawing.Point(98, 159);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Multiline = false;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_CCCD.PasswordChar = false;
            this.txt_CCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_CCCD.PlaceholderText = "";
            this.txt_CCCD.Size = new System.Drawing.Size(190, 38);
            this.txt_CCCD.TabIndex = 80;
            this.txt_CCCD.UnderlinedStyle = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(662, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 242);
            this.panel4.TabIndex = 79;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::GUI.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(17, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(329, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 78;
            this.label6.Text = "Tuổi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(329, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(329, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Di động";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 75;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(19, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 74;
            this.label9.Text = "CCCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(19, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "Họ Tên";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_MaNV.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_MaNV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaNV.BorderRadius = 5;
            this.txt_MaNV.BorderSize = 1;
            this.txt_MaNV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaNV.ForeColor = System.Drawing.Color.Black;
            this.txt_MaNV.Location = new System.Drawing.Point(98, 20);
            this.txt_MaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNV.Multiline = false;
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaNV.PasswordChar = false;
            this.txt_MaNV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaNV.PlaceholderText = "";
            this.txt_MaNV.Size = new System.Drawing.Size(190, 38);
            this.txt_MaNV.TabIndex = 72;
            this.txt_MaNV.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "Mã NV";
            // 
            // dtgv_NhanVien
            // 
            this.dtgv_NhanVien.ColumnHeadersHeight = 29;
            this.dtgv_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.SDT,
            this.DiaChi,
            this.Email,
            this.Tuoi,
            this.ChucVu});
            this.dtgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgv_NhanVien.Location = new System.Drawing.Point(0, 692);
            this.dtgv_NhanVien.Name = "dtgv_NhanVien";
            this.dtgv_NhanVien.RowHeadersWidth = 51;
            this.dtgv_NhanVien.RowTemplate.Height = 29;
            this.dtgv_NhanVien.Size = new System.Drawing.Size(950, 168);
            this.dtgv_NhanVien.TabIndex = 64;
            this.dtgv_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_NhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.FillWeight = 160.4278F;
            this.MaNV.HeaderText = "Mã";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 50;
            // 
            // HoTen
            // 
            this.HoTen.FillWeight = 87.91444F;
            this.HoTen.HeaderText = "Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // SDT
            // 
            this.SDT.FillWeight = 87.91444F;
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.FillWeight = 87.91444F;
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // Email
            // 
            this.Email.FillWeight = 87.91444F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 120;
            // 
            // Tuoi
            // 
            this.Tuoi.FillWeight = 87.91444F;
            this.Tuoi.HeaderText = "Tuổi";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Width = 50;
            // 
            // ChucVu
            // 
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // toolStripBtn_PrintNV
            // 
            this.toolStripBtn_PrintNV.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_PrintNV.Image")));
            this.toolStripBtn_PrintNV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_PrintNV.Name = "toolStripBtn_PrintNV";
            this.toolStripBtn_PrintNV.Size = new System.Drawing.Size(67, 47);
            this.toolStripBtn_PrintNV.Text = " Print";
            this.toolStripBtn_PrintNV.Click += new System.EventHandler(this.toolStripBtn_PrintNV_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 860);
            this.Controls.Add(this.dtgv_NhanVien);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pn_Container.ResumeLayout(false);
            this.pn_Main.ResumeLayout(false);
            this.pn_Main.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripbtn_Luu;
        private ToolStripButton toolStripbtn_Xoa;
        private ToolStripButton toolStripbtn_Refresh;
        private ToolStripButton toolStripButton4;
        private Panel pn_Container;
        private DataGridView dtgv_NhanVien;
        private ToolStripButton toolStripbtn_Them;
        private Panel pn_Main;
        private Button btn_Search;
        private Controls.TextBox_NTT txt_Search;
        private Label label2;
        private Panel panel5;
        private Button button2;
        private Button btn_AnhDaiDien;
        private ComboBox cbb_NhomQuyen;
        private Controls.TextBox_NTT txt_HocVan;
        private Label label1;
        private Controls.TextBox_NTT txt_DiaChi;
        private Controls.TextBox_NTT txt_Email;
        private Controls.TextBox_NTT txt_Tuoi;
        private Controls.TextBox_NTT txt_SDT;
        private Controls.TextBox_NTT txt_HoTen;
        private Controls.TextBox_NTT txt_CCCD;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label5;
        private Controls.TextBox_NTT txt_MaNV;
        private Label label4;
        private Controls.TextBox_NTT txt_SoLuongNV;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn ChucVu;
        private ToolStripButton toolStripBtn_PrintNV;
    }
}