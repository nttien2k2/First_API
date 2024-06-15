using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;
using MaterialSkin;
using DAL;
using GUI;

namespace Demo
{
    public partial class FrmMain : Form
    {
        //string connectstring = @"Data Source=LAPTOP-FRMKN0GD\TIEN;Initial Catalog=First_API;Integrated Security=True";
        //SqlConnection conn;
        //SqlCommand cmd;
        //SqlDataAdapter adt;
        //DataTable dt = new DataTable();
        bool sidebarExpand;
        bool SubMeNuDanhMuc;

        DbContext conn = new DbContext();
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void DataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            //if (dataGridView1.SelectedCells.Count > 0)
            //{
            //    int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            //    DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            //    // Lấy giá trị của cột đầu tiên (index 0)
            //    string columnValue = selectedRow.Cells[0].Value.ToString();

            //    // Gán giá trị vào TextBox
            //    txtUserName.Text = columnValue;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.OpenConnect();
            CheckDangNhap();

        }

        public bool daDangNhap { get; set; } = false;
        public void CheckDangNhap()
        {
            //đăngNhậpToolStripMenuItem.Enabled = !daDangNhap;
            //đăngXuấtToolStripMenuItem.Enabled = daDangNhap;

        }
        public void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saoLưuPhụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaoLuuPhucHoi f = new FrmSaoLuuPhucHoi();
            f.MdiParent = this;
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmNhanVien f = new FrmNhanVien();
            //f.MdiParent = this;
            //f.Show();
        }

        private void sildebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmLogin f = new FrmLogin();
            f.MdiParent = this;
            f.Show();
        }
        private void saoLưuPhụcHồiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmSaoLuuPhucHoi f = new FrmSaoLuuPhucHoi();
            f.MdiParent = this;
            f.Show();
        }

        private void btn_DanhMuc_Timer_Tick(object sender, EventArgs e)
        {
            if (SubMeNuDanhMuc)
            {
                pn_DanhMuc.Height += 10;
                if (pn_DanhMuc.Height == pn_DanhMuc.MaximumSize.Height)
                {
                    SubMeNuDanhMuc = false;
                    btn_DanhMuc_Timer.Stop();
                }
            }
            else
            {
                pn_DanhMuc.Height -= 10;
                if (pn_DanhMuc.Height == pn_DanhMuc.MinimumSize.Height)
                {
                    SubMeNuDanhMuc = true;
                    btn_DanhMuc_Timer.Stop();
                }
            }
        }

        private void btn_DanhMuc_Click_1(object sender, EventArgs e)
        {
            btn_DanhMuc_Timer.Start();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btn_Menu_NhanVien_Click_1(object sender, EventArgs e)
        {
            Form_load(new FrmNhanVien());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maxsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.Width = 1200;
                this.Height = 900;
                this.WindowState = FormWindowState.Normal;
                //this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                //this.StartPosition = FormStartPosition.CenterScreen;
                this.WindowState = FormWindowState.Maximized;

            }
        }

        private void btn_PhongBan_Click(object sender, EventArgs e)
        {
            Form_load(new FrmPhongBan());
        }

        private void Form_load(object form)
        {
            if (this.pn_Main.Controls.Count > 0)
                this.pn_Main.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pn_Main.Controls.Add(f);
            this.pn_Main.Tag = f;
            f.Show();
        }

        private void btn_ChuyenKhoa_Click(object sender, EventArgs e)
        {
            Form_load(new FrmChuyenKhoa());
        }

        private void btn_CaiDat_Click(object sender, EventArgs e)
        {

        }

        private void btn_BenhAn_Click(object sender, EventArgs e)
        {
            Form_load(new FrmBenhAn());

        }
    }
}