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
using DAL;


namespace Demo
{
    public partial class FrmSaoLuuPhucHoi : Form
    {
        public FrmSaoLuuPhucHoi()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        DbContext conn = new DbContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.MyComputer;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = dlg.SelectedPath.ToString();
                btnBackupF.Enabled = true;
                btnBackUpDiff.Enabled = true;
                btnBackUpLog.Enabled = true;
            }
        }

        private void btnBackupF_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDuongDan.Text))
            {
                MessageBox.Show("Vui lòng chọn đường dẫn lưu file backup", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                string sql = "backup database [QL_KhamBenh] to disk= '" + txtDuongDan.Text + "\\ QL_KhamBenh - " + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";
                //conn.OpenConnect();
                SqlCommand cmd = new SqlCommand(sql, conn.Connect);
                cmd.ExecuteNonQuery();
                conn.CloseConnect();
                MessageBox.Show("Backup dứ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtPhucHoi.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn file backup để phục hồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    string backupPath = txtPhucHoi.Text;
            //    string database = conn.dataBase.ToString();
            //    conn.OpenConnect();
            //    try
            //    {
            //        string sql1 = "Alter database  [First_API] SET SINGLE_USER WITH ROLLBACK IMMEDIATE ";
            //        SqlCommand cmd1 = new SqlCommand(sql1, conn.Connect);
            //        cmd1.ExecuteNonQuery();

            //        string sql2 = "USE MASTER RESTORE DATABASE [First_API] FROM DISK= '" + backupPath + "'WITH REPLACE";
            //        SqlCommand cmd2 = new SqlCommand(sql2, conn.Connect);
            //        cmd2.ExecuteNonQuery();

            //        string sql3 = "ALTER DATABASE [First_API] SET MULTI_USER";
            //        SqlCommand cmd3 = new SqlCommand(sql3, conn.Connect);
            //        cmd3.ExecuteNonQuery();
            //        conn.CloseConnect();
            //        MessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Khôi phục dữ liệu không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "Backup file (.bak)|*.bak| All files (.trn)|*.trn";
            //openFile.Title = "Phục hồi dữ liệu";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //txtPhucHoi.Text = openFile.FileName;
            }
        }

        private void FrmSaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            //this.SizeChanged += ChildForm_SizeChanged;

            // Định nghĩa đường dẫn mặc định để lấy file thư mục
            string defaultFolderPath = @"C:\KiKS";

            if (Directory.Exists(defaultFolderPath))
            {
                //DataGridViewColumn columnName = dataGridView1.Columns[0];
                string[] files = Directory.GetFiles(defaultFolderPath, "*.bak");
                foreach (string file in files)
                {
                    dataGridView1.Rows.Add(Path.GetFileName(file));
                }

            }
            else
            {
                MessageBox.Show("The default folder does not exist. Please choose a folder manually.");

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "Select the folder containing the .bak files";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    DataTable dataTable = new DataTable();

                    // Khởi tạo cột "File Name" từ DataGridView đã tạo trong giao diện
                    DataColumn fileNameColumn = new DataColumn("File Name");
                    dataTable.Columns.Add(fileNameColumn);

                    string[] files = Directory.GetFiles(selectedFolder, "*.bak");
                    foreach (string file in files)
                    {
                        dataTable.Rows.Add(Path.GetFileName(file));
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void ChildForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.MdiParent != null)
            {
                this.MdiParent.Width = this.Width;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripBtn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
