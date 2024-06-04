using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Demo
{
    public partial class FrmLogin : MaterialForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue300, Primary.LightBlue500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        DbContext conn = new DbContext();

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            string tk = txt_TaiKhoan.Text;
            string mk = txt_MatKhau.Text;
            if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Tài khoản và mật khẩu không được rỗng");
                return;
            }
            if (conn.check_TaiKhoan(tk, mk) == false)
            {
                MessageBox.Show("Tài khoản chưa được đăng ký");
                return;
            }
            if(conn.check_Quyen(tk) == 1)
            {
                conn.StrUserName = "admin";
                conn.StrPassWord = "123";
            }else if(conn.check_Quyen(tk) == 2)
            {
                conn.StrUserName = "BacSi";
                conn.StrPassWord = "123";
            }
            else
            {
                conn.StrUserName = "Duoc";
                conn.StrPassWord = "123";
            }
            try
            {
                conn.OpenConnect();
                MessageBox.Show("Đăng nhập thành công");
                FrmMain fm = new FrmMain();
                fm.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                // Đóng kết nối
                conn.CloseConnect();
                // Hiển thị thông báo lỗi
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }
    }
}
