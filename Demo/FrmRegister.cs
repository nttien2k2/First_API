using MaterialSkin;
using MaterialSkin.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class FrmRegister : MaterialForm
    {

        //string connectstring = @"Data Source=LAPTOP-FRMKN0GD\TIEN;Initial Catalog=First_API;Integrated Security=True";
        //SqlConnection conn;
        //SqlCommand cmd;
        //SqlDataAdapter adt;
        //DataTable dt = new DataTable();
        DbContext conn = new DbContext();
        public FrmRegister()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue300, Primary.LightBlue500, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.OpenConnect();

                // Lấy dữ liệu từ các control
                string sdt = materialMaskedTextBox1.Text;
                //string chucVu = textBox3.Text;
                string password = materialMaskedTextBox2.Text;

                // Tạo câu lệnh insert
                string insertQuery = "INSERT INTO NhanVien1 (SDT, Password) VALUES (@sdt, @password)";

                conn.UpdateToDatabase(insertQuery);
                // Tạo SqlCommand
                //SqlCommand cmd = new SqlCommand(insertQuery, conn);

                // Thêm tham số
                //cmd.Parameters.AddWithValue("@sdt", sdt);
                //cmd.Parameters.AddWithValue("@password", password);
                ////cmd.Parameters.AddWithValue("@chucVu", chucVu);

                //// Thực thi câu lệnh
                //cmd.ExecuteNonQuery();

                // Hiển thị thông báo thành công
                MessageBox.Show("Đăng ký thành công!", "Thông báo");
                //
                FrmLogin login = new FrmLogin();
                login.Show();
                //
                this.Hide();
                // Đóng kết nối
                conn.CloseConnect();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
