using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Backup_Restore_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();
        public bool BackupDatabase(string defaultFolderPath)
        {
            // Kiểm tra xem thư mục mặc định có tồn tại không
            if (Directory.Exists(defaultFolderPath))
            {
                // Tạo tên tệp tin backup với định dạng "QL_KhamBenh - yyyy-MM-dd--HH-mm-ss.bak"
                string backupFileName = $"QL_KhamBenh - {DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss")}.bak";
                string backupFilePath = Path.Combine(defaultFolderPath, backupFileName);

                // Tạo câu lệnh SQL để thực hiện backup
                string sql = $"BACKUP DATABASE [QL_KhamBenh] TO DISK = '{backupFilePath}'";

                // Thực hiện kết nối và chạy câu lệnh SQL
                try
                {
                    conn.OpenConnect();
                    SqlCommand cmd = new SqlCommand(sql, Connect);
                    cmd.ExecuteNonQuery();
                    conn.CloseConnect();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool RestoreDatabase(string backupPath, string database)
        {
            if (string.IsNullOrEmpty(backupPath))
            {
                return false;
            }
            try
            {
                conn.OpenConnect();

                // Đặt cơ sở dữ liệu ở chế độ SINGLE_USER để phục hồi
                string sql1 = $"ALTER DATABASE [{database}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                SqlCommand cmd1 = new SqlCommand(sql1, conn.Connect);
                cmd1.ExecuteNonQuery();

                // Thực hiện lệnh phục hồi cơ sở dữ liệu từ file backup
                string sql2 = $"USE MASTER RESTORE DATABASE [{database}] FROM DISK= '{backupPath}' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(sql2, conn.Connect);
                cmd2.ExecuteNonQuery();

                // Đặt cơ sở dữ liệu ở chế độ MULTI_USER sau khi phục hồi
                string sql3 = $"ALTER DATABASE [{database}] SET MULTI_USER";
                SqlCommand cmd3 = new SqlCommand(sql3, conn.Connect);
                cmd3.ExecuteNonQuery();

                // Đóng kết nối tới SQL Server
                conn.CloseConnect();
                return true;
            }
            catch (Exception)
            {
                try
                {
                    // Nếu có lỗi, đặt cơ sở dữ liệu trở lại chế độ MULTI_USER
                    string sql3 = $"ALTER DATABASE [{database}] SET MULTI_USER";
                    SqlCommand cmd3 = new SqlCommand(sql3, conn.Connect);
                    cmd3.ExecuteNonQuery();
                }
                catch
                {
                    // Nếu đặt lại chế độ MULTI_USER cũng thất bại, ghi log hoặc xử lý lỗi phù hợp
                }

                conn.CloseConnect();
                return false;
            }
        }


    }
}
