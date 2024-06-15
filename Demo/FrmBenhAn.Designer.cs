namespace Demo
{
    partial class FrmBenhAn
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
            this.pn_Left = new System.Windows.Forms.Panel();
            this.dtgv_BenhNhan = new System.Windows.Forms.DataGridView();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND_CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new Demo.Controls.TextBox_NTT();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DanToc = new Demo.Controls.TextBox_NTT();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GioiTinh = new Demo.Controls.TextBox_NTT();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new Demo.Controls.TextBox_NTT();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Tuoi = new Demo.Controls.TextBox_NTT();
            this.txt_SDT = new Demo.Controls.TextBox_NTT();
            this.txt_HoTen = new Demo.Controls.TextBox_NTT();
            this.txt_CCCD = new Demo.Controls.TextBox_NTT();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaBN = new Demo.Controls.TextBox_NTT();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pn_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BenhNhan)).BeginInit();
            this.pn_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Left.Controls.Add(this.dataGridView1);
            this.pn_Left.Controls.Add(this.dtgv_BenhNhan);
            this.pn_Left.Controls.Add(this.btn_Search);
            this.pn_Left.Controls.Add(this.txt_Search);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(335, 820);
            this.pn_Left.TabIndex = 0;
            this.pn_Left.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Left_Paint);
            // 
            // dtgv_BenhNhan
            // 
            this.dtgv_BenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_BenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SDT,
            this.HoTenBN,
            this.MaBN,
            this.Tuoi,
            this.GioiTinh,
            this.DanToc,
            this.DiaChi,
            this.CMND_CCCD});
            this.dtgv_BenhNhan.Location = new System.Drawing.Point(4, 102);
            this.dtgv_BenhNhan.Name = "dtgv_BenhNhan";
            this.dtgv_BenhNhan.RowHeadersWidth = 51;
            this.dtgv_BenhNhan.RowTemplate.Height = 29;
            this.dtgv_BenhNhan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgv_BenhNhan.Size = new System.Drawing.Size(326, 60);
            this.dtgv_BenhNhan.TabIndex = 2;
            this.dtgv_BenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BenhNhan_CellClick);
            this.dtgv_BenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_BenhNhan_CellContentClick);
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // HoTenBN
            // 
            this.HoTenBN.HeaderText = "Tên";
            this.HoTenBN.MinimumWidth = 6;
            this.HoTenBN.Name = "HoTenBN";
            this.HoTenBN.Width = 150;
            // 
            // MaBN
            // 
            this.MaBN.HeaderText = "Column1";
            this.MaBN.MinimumWidth = 6;
            this.MaBN.Name = "MaBN";
            this.MaBN.Width = 125;
            // 
            // Tuoi
            // 
            this.Tuoi.HeaderText = "Column2";
            this.Tuoi.MinimumWidth = 6;
            this.Tuoi.Name = "Tuoi";
            this.Tuoi.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Column3";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // DanToc
            // 
            this.DanToc.HeaderText = "Column4";
            this.DanToc.MinimumWidth = 6;
            this.DanToc.Name = "DanToc";
            this.DanToc.Width = 125;
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Column5";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // CMND_CCCD
            // 
            this.CMND_CCCD.HeaderText = "Column6";
            this.CMND_CCCD.MinimumWidth = 6;
            this.CMND_CCCD.Name = "CMND_CCCD";
            this.CMND_CCCD.Width = 125;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(168, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 35);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Search.BorderRadius = 5;
            this.txt_Search.BorderSize = 1;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(4, 50);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "SDT bệnh nhân";
            this.txt_Search.Size = new System.Drawing.Size(157, 35);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.UnderlinedStyle = false;
            this.txt_Search.Load += new System.EventHandler(this.txt_Search_Load);
            // 
            // pn_Right
            // 
            this.pn_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Right.Controls.Add(this.label11);
            this.pn_Right.Controls.Add(this.label2);
            this.pn_Right.Controls.Add(this.label1);
            this.pn_Right.Controls.Add(this.txt_DanToc);
            this.pn_Right.Controls.Add(this.label7);
            this.pn_Right.Controls.Add(this.txt_GioiTinh);
            this.pn_Right.Controls.Add(this.label3);
            this.pn_Right.Controls.Add(this.txt_DiaChi);
            this.pn_Right.Controls.Add(this.label8);
            this.pn_Right.Controls.Add(this.txt_Tuoi);
            this.pn_Right.Controls.Add(this.txt_SDT);
            this.pn_Right.Controls.Add(this.txt_HoTen);
            this.pn_Right.Controls.Add(this.txt_CCCD);
            this.pn_Right.Controls.Add(this.label6);
            this.pn_Right.Controls.Add(this.label10);
            this.pn_Right.Controls.Add(this.label9);
            this.pn_Right.Controls.Add(this.label5);
            this.pn_Right.Controls.Add(this.txt_MaBN);
            this.pn_Right.Controls.Add(this.label4);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Right.Location = new System.Drawing.Point(335, 0);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(628, 820);
            this.pn_Right.TabIndex = 1;
            this.pn_Right.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Right_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(619, 23);
            this.label11.TabIndex = 114;
            this.label11.Text = "_________________Thông tin cá nhân_______________________________________________" +
    "___";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 23);
            this.label2.TabIndex = 113;
            this.label2.Text = "__________________Bệnh án________________________________________________________" +
    "____";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 112;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_DanToc
            // 
            this.txt_DanToc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_DanToc.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_DanToc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_DanToc.BorderRadius = 5;
            this.txt_DanToc.BorderSize = 1;
            this.txt_DanToc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DanToc.ForeColor = System.Drawing.Color.Black;
            this.txt_DanToc.Location = new System.Drawing.Point(537, 78);
            this.txt_DanToc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DanToc.Multiline = false;
            this.txt_DanToc.Name = "txt_DanToc";
            this.txt_DanToc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DanToc.PasswordChar = false;
            this.txt_DanToc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DanToc.PlaceholderText = "";
            this.txt_DanToc.Size = new System.Drawing.Size(75, 38);
            this.txt_DanToc.TabIndex = 111;
            this.txt_DanToc.UnderlinedStyle = false;
            this.txt_DanToc.Load += new System.EventHandler(this.txt_DanToc_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(455, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 110;
            this.label7.Text = "Dân tộc";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_GioiTinh.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_GioiTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_GioiTinh.BorderRadius = 5;
            this.txt_GioiTinh.BorderSize = 1;
            this.txt_GioiTinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_GioiTinh.ForeColor = System.Drawing.Color.Black;
            this.txt_GioiTinh.Location = new System.Drawing.Point(537, 32);
            this.txt_GioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GioiTinh.Multiline = false;
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_GioiTinh.PasswordChar = false;
            this.txt_GioiTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_GioiTinh.PlaceholderText = "";
            this.txt_GioiTinh.Size = new System.Drawing.Size(75, 38);
            this.txt_GioiTinh.TabIndex = 109;
            this.txt_GioiTinh.UnderlinedStyle = false;
            this.txt_GioiTinh.Load += new System.EventHandler(this.txt_GioiTinh_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(455, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 108;
            this.label3.Text = "Giới tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.txt_DiaChi.Location = new System.Drawing.Point(79, 124);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Multiline = false;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_DiaChi.PasswordChar = false;
            this.txt_DiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(533, 38);
            this.txt_DiaChi.TabIndex = 107;
            this.txt_DiaChi.UnderlinedStyle = false;
            this.txt_DiaChi.Load += new System.EventHandler(this.txt_DiaChi_Load);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 106;
            this.label8.Text = "Địa chỉ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.txt_Tuoi.Location = new System.Drawing.Point(404, 32);
            this.txt_Tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tuoi.Multiline = false;
            this.txt_Tuoi.Name = "txt_Tuoi";
            this.txt_Tuoi.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Tuoi.PasswordChar = false;
            this.txt_Tuoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Tuoi.PlaceholderText = "";
            this.txt_Tuoi.Size = new System.Drawing.Size(47, 38);
            this.txt_Tuoi.TabIndex = 100;
            this.txt_Tuoi.UnderlinedStyle = false;
            this.txt_Tuoi.Load += new System.EventHandler(this.txt_Tuoi_Load);
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
            this.txt_SDT.Location = new System.Drawing.Point(235, 32);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SDT.Multiline = false;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_SDT.PasswordChar = false;
            this.txt_SDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.Size = new System.Drawing.Size(115, 38);
            this.txt_SDT.TabIndex = 99;
            this.txt_SDT.UnderlinedStyle = false;
            this.txt_SDT.Load += new System.EventHandler(this.txt_SDT_Load);
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
            this.txt_HoTen.Location = new System.Drawing.Point(79, 76);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Multiline = false;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_HoTen.PasswordChar = false;
            this.txt_HoTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_HoTen.PlaceholderText = "";
            this.txt_HoTen.Size = new System.Drawing.Size(190, 38);
            this.txt_HoTen.TabIndex = 98;
            this.txt_HoTen.UnderlinedStyle = false;
            this.txt_HoTen.Load += new System.EventHandler(this.txt_HoTen_Load);
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
            this.txt_CCCD.Location = new System.Drawing.Point(336, 76);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CCCD.Multiline = false;
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_CCCD.PasswordChar = false;
            this.txt_CCCD.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_CCCD.PlaceholderText = "";
            this.txt_CCCD.Size = new System.Drawing.Size(115, 38);
            this.txt_CCCD.TabIndex = 97;
            this.txt_CCCD.UnderlinedStyle = false;
            this.txt_CCCD.Load += new System.EventHandler(this.txt_CCCD_Load);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(355, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 96;
            this.label6.Text = "Tuổi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(157, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 94;
            this.label10.Text = "Di động";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(274, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 23);
            this.label9.TabIndex = 93;
            this.label9.Text = "CCCD";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 92;
            this.label5.Text = "Họ Tên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_MaBN
            // 
            this.txt_MaBN.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_MaBN.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txt_MaBN.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_MaBN.BorderRadius = 5;
            this.txt_MaBN.BorderSize = 1;
            this.txt_MaBN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaBN.ForeColor = System.Drawing.Color.Black;
            this.txt_MaBN.Location = new System.Drawing.Point(79, 32);
            this.txt_MaBN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaBN.Multiline = false;
            this.txt_MaBN.Name = "txt_MaBN";
            this.txt_MaBN.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_MaBN.PasswordChar = false;
            this.txt_MaBN.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_MaBN.PlaceholderText = "";
            this.txt_MaBN.Size = new System.Drawing.Size(71, 38);
            this.txt_MaBN.TabIndex = 91;
            this.txt_MaBN.UnderlinedStyle = false;
            this.txt_MaBN.Load += new System.EventHandler(this.txt_MaBN_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 90;
            this.label4.Text = "Mã BN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(325, 134);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 820);
            this.Controls.Add(this.pn_Right);
            this.Controls.Add(this.pn_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBenhAn";
            this.Text = "FrmBenhAn";
            this.Load += new System.EventHandler(this.FrmBenhAn_Load);
            this.pn_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BenhNhan)).EndInit();
            this.pn_Right.ResumeLayout(false);
            this.pn_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_Left;
        private Panel pn_Right;
        private DataGridView dtgv_BenhNhan;
        private Button btn_Search;
        private Controls.TextBox_NTT txt_Search;
        private Controls.TextBox_NTT txt_Tuoi;
        private Controls.TextBox_NTT txt_SDT;
        private Controls.TextBox_NTT txt_HoTen;
        private Controls.TextBox_NTT txt_CCCD;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label5;
        private Controls.TextBox_NTT txt_MaBN;
        private Label label4;
        private Controls.TextBox_NTT txt_GioiTinh;
        private Label label3;
        private Controls.TextBox_NTT txt_DiaChi;
        private Label label8;
        private Controls.TextBox_NTT txt_DanToc;
        private Label label7;
        private Label label11;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn SDT;
        private DataGridViewTextBoxColumn HoTenBN;
        private DataGridViewTextBoxColumn MaBN;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DanToc;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn CMND_CCCD;
        private DataGridView dataGridView1;
    }
}