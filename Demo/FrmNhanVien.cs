using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        private void EditRow(int rowIndex)
        {
            // Hiển thị thông báo "Xin chào"
            MessageBox.Show("Xin chào!");

            // Thực hiện các logic khác liên quan đến việc chỉnh sửa dòng
            // Ví dụ: Hiển thị một form để người dùng chỉnh sửa dữ liệu
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem cột "editColumn" có tồn tại trong DataGridView hay không
            if (this.dataGridView1.Columns["editColumn"] != null)
            {
                if (e.ColumnIndex == this.dataGridView1.Columns["editColumn"].Index)
                {
                    // Xử lý sự kiện "Sửa"
                    EditRow(e.RowIndex);
                }
            }
            else if (e.ColumnIndex == this.dataGridView1.Columns["deleteColumn"].Index)
            {
                // Xử lý sự kiện "Xóa"
                //DeleteRow(e.RowIndex);
            }
        }
    }
}
