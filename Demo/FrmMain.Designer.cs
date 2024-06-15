namespace Demo
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_DanhMuc_Timer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_Menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pn_Dashboard = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.pn_DanhMuc = new System.Windows.Forms.Panel();
            this.btn_DichVu = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.btn_BenhAn = new System.Windows.Forms.Button();
            this.btn_TBYT = new System.Windows.Forms.Button();
            this.btn_Thuoc = new System.Windows.Forms.Button();
            this.pn_Lich = new System.Windows.Forms.Panel();
            this.btn_Lich = new System.Windows.Forms.Button();
            this.pn_NhanVien = new System.Windows.Forms.Panel();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.pn_PhongBan = new System.Windows.Forms.Panel();
            this.btn_PhongBan = new System.Windows.Forms.Button();
            this.pn_ChuyenKhoa = new System.Windows.Forms.Panel();
            this.btn_ChuyenKhoa = new System.Windows.Forms.Button();
            this.pn_CaiDat = new System.Windows.Forms.Panel();
            this.btn_CaiDat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pn_Footer = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_Header = new System.Windows.Forms.Panel();
            this.pn_Control = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Maxsize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pn_Dashboard.SuspendLayout();
            this.pn_DanhMuc.SuspendLayout();
            this.pn_Lich.SuspendLayout();
            this.pn_NhanVien.SuspendLayout();
            this.pn_PhongBan.SuspendLayout();
            this.pn_ChuyenKhoa.SuspendLayout();
            this.pn_CaiDat.SuspendLayout();
            this.pn_Footer.SuspendLayout();
            this.pn_Header.SuspendLayout();
            this.pn_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sildebarTimer_Tick);
            // 
            // btn_DanhMuc_Timer
            // 
            this.btn_DanhMuc_Timer.Interval = 10;
            this.btn_DanhMuc_Timer.Tick += new System.EventHandler(this.btn_DanhMuc_Timer_Tick);
            // 
            // sidebar
            // 
            this.sidebar.AutoSize = true;
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.pn_Menu);
            this.sidebar.Controls.Add(this.pn_Dashboard);
            this.sidebar.Controls.Add(this.pn_DanhMuc);
            this.sidebar.Controls.Add(this.pn_Lich);
            this.sidebar.Controls.Add(this.pn_NhanVien);
            this.sidebar.Controls.Add(this.pn_PhongBan);
            this.sidebar.Controls.Add(this.pn_ChuyenKhoa);
            this.sidebar.Controls.Add(this.pn_CaiDat);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 40);
            this.sidebar.MaximumSize = new System.Drawing.Size(250, 1170);
            this.sidebar.MinimumSize = new System.Drawing.Size(85, 870);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(250, 870);
            this.sidebar.TabIndex = 10;
            // 
            // pn_Menu
            // 
            this.pn_Menu.Controls.Add(this.label2);
            this.pn_Menu.Controls.Add(this.pictureBox2);
            this.pn_Menu.Location = new System.Drawing.Point(3, 3);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(250, 70);
            this.pn_Menu.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(84, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pn_Dashboard
            // 
            this.pn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_Dashboard.Controls.Add(this.btn_Dashboard);
            this.pn_Dashboard.Location = new System.Drawing.Point(3, 79);
            this.pn_Dashboard.Name = "pn_Dashboard";
            this.pn_Dashboard.Size = new System.Drawing.Size(250, 60);
            this.pn_Dashboard.TabIndex = 7;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("btn_Dashboard.Image")));
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Dashboard.Size = new System.Drawing.Size(250, 60);
            this.btn_Dashboard.TabIndex = 11;
            this.btn_Dashboard.Text = "            Dashboard";
            this.btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            // 
            // pn_DanhMuc
            // 
            this.pn_DanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_DanhMuc.Controls.Add(this.btn_DichVu);
            this.pn_DanhMuc.Controls.Add(this.btn_DanhMuc);
            this.pn_DanhMuc.Controls.Add(this.btn_BenhAn);
            this.pn_DanhMuc.Controls.Add(this.btn_TBYT);
            this.pn_DanhMuc.Controls.Add(this.btn_Thuoc);
            this.pn_DanhMuc.Location = new System.Drawing.Point(3, 145);
            this.pn_DanhMuc.MaximumSize = new System.Drawing.Size(250, 220);
            this.pn_DanhMuc.MinimumSize = new System.Drawing.Size(250, 60);
            this.pn_DanhMuc.Name = "pn_DanhMuc";
            this.pn_DanhMuc.Size = new System.Drawing.Size(250, 60);
            this.pn_DanhMuc.TabIndex = 11;
            // 
            // btn_DichVu
            // 
            this.btn_DichVu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_DichVu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_DichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DichVu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DichVu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DichVu.Image = ((System.Drawing.Image)(resources.GetObject("btn_DichVu.Image")));
            this.btn_DichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DichVu.Location = new System.Drawing.Point(0, 180);
            this.btn_DichVu.Name = "btn_DichVu";
            this.btn_DichVu.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_DichVu.Size = new System.Drawing.Size(250, 40);
            this.btn_DichVu.TabIndex = 15;
            this.btn_DichVu.Text = "            Dịch vụ";
            this.btn_DichVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DichVu.UseVisualStyleBackColor = false;
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_DanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DanhMuc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DanhMuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_DanhMuc.Image")));
            this.btn_DanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DanhMuc.Location = new System.Drawing.Point(0, 0);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_DanhMuc.Size = new System.Drawing.Size(250, 60);
            this.btn_DanhMuc.TabIndex = 14;
            this.btn_DanhMuc.Text = "            Danh mục";
            this.btn_DanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DanhMuc.UseVisualStyleBackColor = false;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click_1);
            // 
            // btn_BenhAn
            // 
            this.btn_BenhAn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_BenhAn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_BenhAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BenhAn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BenhAn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_BenhAn.Image = ((System.Drawing.Image)(resources.GetObject("btn_BenhAn.Image")));
            this.btn_BenhAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BenhAn.Location = new System.Drawing.Point(0, 140);
            this.btn_BenhAn.Name = "btn_BenhAn";
            this.btn_BenhAn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_BenhAn.Size = new System.Drawing.Size(250, 40);
            this.btn_BenhAn.TabIndex = 13;
            this.btn_BenhAn.Text = "            Bệnh án";
            this.btn_BenhAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BenhAn.UseVisualStyleBackColor = false;
            this.btn_BenhAn.Click += new System.EventHandler(this.btn_BenhAn_Click);
            // 
            // btn_TBYT
            // 
            this.btn_TBYT.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_TBYT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_TBYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TBYT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TBYT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TBYT.Image = ((System.Drawing.Image)(resources.GetObject("btn_TBYT.Image")));
            this.btn_TBYT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TBYT.Location = new System.Drawing.Point(0, 100);
            this.btn_TBYT.Name = "btn_TBYT";
            this.btn_TBYT.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_TBYT.Size = new System.Drawing.Size(250, 40);
            this.btn_TBYT.TabIndex = 12;
            this.btn_TBYT.Text = "            TBYT";
            this.btn_TBYT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TBYT.UseVisualStyleBackColor = false;
            // 
            // btn_Thuoc
            // 
            this.btn_Thuoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Thuoc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_Thuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thuoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Thuoc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thuoc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thuoc.Image")));
            this.btn_Thuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thuoc.Location = new System.Drawing.Point(0, 60);
            this.btn_Thuoc.Name = "btn_Thuoc";
            this.btn_Thuoc.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Thuoc.Size = new System.Drawing.Size(250, 40);
            this.btn_Thuoc.TabIndex = 11;
            this.btn_Thuoc.Text = "            Thuốc";
            this.btn_Thuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thuoc.UseVisualStyleBackColor = false;
            // 
            // pn_Lich
            // 
            this.pn_Lich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_Lich.Controls.Add(this.btn_Lich);
            this.pn_Lich.Location = new System.Drawing.Point(3, 211);
            this.pn_Lich.Name = "pn_Lich";
            this.pn_Lich.Size = new System.Drawing.Size(250, 60);
            this.pn_Lich.TabIndex = 12;
            // 
            // btn_Lich
            // 
            this.btn_Lich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_Lich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Lich.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_Lich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lich.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Lich.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Lich.Image = ((System.Drawing.Image)(resources.GetObject("btn_Lich.Image")));
            this.btn_Lich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lich.Location = new System.Drawing.Point(0, 0);
            this.btn_Lich.Name = "btn_Lich";
            this.btn_Lich.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_Lich.Size = new System.Drawing.Size(250, 60);
            this.btn_Lich.TabIndex = 11;
            this.btn_Lich.Text = "            Lịch";
            this.btn_Lich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Lich.UseVisualStyleBackColor = false;
            // 
            // pn_NhanVien
            // 
            this.pn_NhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_NhanVien.Controls.Add(this.btn_NhanVien);
            this.pn_NhanVien.Location = new System.Drawing.Point(3, 277);
            this.pn_NhanVien.Name = "pn_NhanVien";
            this.pn_NhanVien.Size = new System.Drawing.Size(250, 60);
            this.pn_NhanVien.TabIndex = 12;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NhanVien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_NhanVien.Size = new System.Drawing.Size(250, 60);
            this.btn_NhanVien.TabIndex = 11;
            this.btn_NhanVien.Text = "            Nhân viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_Menu_NhanVien_Click_1);
            // 
            // pn_PhongBan
            // 
            this.pn_PhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_PhongBan.Controls.Add(this.btn_PhongBan);
            this.pn_PhongBan.Location = new System.Drawing.Point(3, 343);
            this.pn_PhongBan.Name = "pn_PhongBan";
            this.pn_PhongBan.Size = new System.Drawing.Size(250, 60);
            this.pn_PhongBan.TabIndex = 14;
            // 
            // btn_PhongBan
            // 
            this.btn_PhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PhongBan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_PhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhongBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PhongBan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btn_PhongBan.Image")));
            this.btn_PhongBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhongBan.Location = new System.Drawing.Point(0, 0);
            this.btn_PhongBan.Name = "btn_PhongBan";
            this.btn_PhongBan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_PhongBan.Size = new System.Drawing.Size(250, 60);
            this.btn_PhongBan.TabIndex = 11;
            this.btn_PhongBan.Text = "            Phòng ban";
            this.btn_PhongBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhongBan.UseVisualStyleBackColor = true;
            this.btn_PhongBan.Click += new System.EventHandler(this.btn_PhongBan_Click);
            // 
            // pn_ChuyenKhoa
            // 
            this.pn_ChuyenKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_ChuyenKhoa.Controls.Add(this.btn_ChuyenKhoa);
            this.pn_ChuyenKhoa.Location = new System.Drawing.Point(3, 409);
            this.pn_ChuyenKhoa.Name = "pn_ChuyenKhoa";
            this.pn_ChuyenKhoa.Size = new System.Drawing.Size(250, 60);
            this.pn_ChuyenKhoa.TabIndex = 13;
            // 
            // btn_ChuyenKhoa
            // 
            this.btn_ChuyenKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_ChuyenKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChuyenKhoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_ChuyenKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChuyenKhoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ChuyenKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChuyenKhoa.Image")));
            this.btn_ChuyenKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChuyenKhoa.Location = new System.Drawing.Point(0, 0);
            this.btn_ChuyenKhoa.Name = "btn_ChuyenKhoa";
            this.btn_ChuyenKhoa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_ChuyenKhoa.Size = new System.Drawing.Size(250, 60);
            this.btn_ChuyenKhoa.TabIndex = 11;
            this.btn_ChuyenKhoa.Text = "            Chuyên khoa";
            this.btn_ChuyenKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChuyenKhoa.UseVisualStyleBackColor = false;
            this.btn_ChuyenKhoa.Click += new System.EventHandler(this.btn_ChuyenKhoa_Click);
            // 
            // pn_CaiDat
            // 
            this.pn_CaiDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_CaiDat.Controls.Add(this.btn_CaiDat);
            this.pn_CaiDat.Location = new System.Drawing.Point(3, 475);
            this.pn_CaiDat.Name = "pn_CaiDat";
            this.pn_CaiDat.Size = new System.Drawing.Size(250, 60);
            this.pn_CaiDat.TabIndex = 15;
            // 
            // btn_CaiDat
            // 
            this.btn_CaiDat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_CaiDat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.btn_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CaiDat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CaiDat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_CaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btn_CaiDat.Image")));
            this.btn_CaiDat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CaiDat.Location = new System.Drawing.Point(0, 0);
            this.btn_CaiDat.Name = "btn_CaiDat";
            this.btn_CaiDat.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_CaiDat.Size = new System.Drawing.Size(250, 60);
            this.btn_CaiDat.TabIndex = 11;
            this.btn_CaiDat.Text = "            Cài đặt";
            this.btn_CaiDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CaiDat.UseVisualStyleBackColor = true;
            this.btn_CaiDat.Click += new System.EventHandler(this.btn_CaiDat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Version:";
            // 
            // pn_Footer
            // 
            this.pn_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(117)))), ((int)(((byte)(220)))));
            this.pn_Footer.Controls.Add(this.label4);
            this.pn_Footer.Controls.Add(this.label3);
            this.pn_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_Footer.Location = new System.Drawing.Point(0, 823);
            this.pn_Footer.Name = "pn_Footer";
            this.pn_Footer.Size = new System.Drawing.Size(948, 35);
            this.pn_Footer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(402, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cập nhật ngày:";
            // 
            // pn_Header
            // 
            this.pn_Header.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_Header.Controls.Add(this.pn_Control);
            this.pn_Header.Controls.Add(this.label1);
            this.pn_Header.Controls.Add(this.pictureBox1);
            this.pn_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pn_Header.Location = new System.Drawing.Point(0, 0);
            this.pn_Header.Name = "pn_Header";
            this.pn_Header.Size = new System.Drawing.Size(1200, 40);
            this.pn_Header.TabIndex = 12;
            // 
            // pn_Control
            // 
            this.pn_Control.Controls.Add(this.button1);
            this.pn_Control.Controls.Add(this.btn_Maxsize);
            this.pn_Control.Controls.Add(this.btn_Close);
            this.pn_Control.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_Control.Location = new System.Drawing.Point(1080, 0);
            this.pn_Control.Name = "pn_Control";
            this.pn_Control.Size = new System.Drawing.Size(120, 40);
            this.pn_Control.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Maxsize
            // 
            this.btn_Maxsize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Maxsize.FlatAppearance.BorderSize = 0;
            this.btn_Maxsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maxsize.Image = ((System.Drawing.Image)(resources.GetObject("btn_Maxsize.Image")));
            this.btn_Maxsize.Location = new System.Drawing.Point(40, 0);
            this.btn_Maxsize.Name = "btn_Maxsize";
            this.btn_Maxsize.Size = new System.Drawing.Size(40, 40);
            this.btn_Maxsize.TabIndex = 15;
            this.btn_Maxsize.UseVisualStyleBackColor = true;
            this.btn_Maxsize.Click += new System.EventHandler(this.btn_Maxsize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(80, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(558, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEDICINEPRO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(500, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.Color.White;
            this.pn_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Main.Controls.Add(this.pn_Footer);
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(250, 40);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(950, 860);
            this.pn_Main.TabIndex = 13;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pn_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1900, 1100);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalPro";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebar.ResumeLayout(false);
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pn_Dashboard.ResumeLayout(false);
            this.pn_DanhMuc.ResumeLayout(false);
            this.pn_Lich.ResumeLayout(false);
            this.pn_NhanVien.ResumeLayout(false);
            this.pn_PhongBan.ResumeLayout(false);
            this.pn_ChuyenKhoa.ResumeLayout(false);
            this.pn_CaiDat.ResumeLayout(false);
            this.pn_Footer.ResumeLayout(false);
            this.pn_Footer.PerformLayout();
            this.pn_Header.ResumeLayout(false);
            this.pn_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_Main.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer btn_DanhMuc_Timer;
        private FlowLayoutPanel sidebar;
        private Panel pn_Menu;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel pn_Dashboard;
        private Button btn_Dashboard;
        private Panel pn_CaiDat;
        private Button btn_CaiDat;
        private Panel pn_Lich;
        private Button btn_Lich;
        private Panel pn_DanhMuc;
        private Button btn_DanhMuc;
        private Button btn_BenhAn;
        private Button btn_TBYT;
        private Button btn_Thuoc;
        private Panel pn_NhanVien;
        private Button btn_NhanVien;
        private Button btn_DichVu;
        private Panel pn_PhongBan;
        private Button btn_PhongBan;
        private Panel pn_ChuyenKhoa;
        private Button btn_ChuyenKhoa;
        private Panel pn_Header;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pn_Control;
        private Button button1;
        private Button btn_Maxsize;
        private Button btn_Close;
        private Panel pn_Main;
        private Panel pn_Footer;
        private Label label3;
        private Label label4;
    }
}