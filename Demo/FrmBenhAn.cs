using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Demo
{
    public partial class FrmBenhAn : Form
    {
        BenhNhan_BLL bn_bll = new BenhNhan_BLL();
        public FrmBenhAn()
        {
            InitializeComponent();
        }

        private void dtgv_BenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_BenhNhan.Rows.Count)
            {
                DataGridViewRow row = dtgv_BenhNhan.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_MaBN.Text = row.Cells["MaBN"].Value.ToString();
                        txt_HoTen.Text = row.Cells["HoTenBN"].Value.ToString();
                        txt_SDT.Text = row.Cells["SDT"].Value.ToString();
                        txt_DiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                        txt_GioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                        txt_Tuoi.Text = row.Cells["Tuoi"].Value.ToString();
                        txt_CCCD.Text = row.Cells["CMND_CCCD"].Value.ToString();
                        txt_DanToc.Text = row.Cells["DanToc"].Value.ToString();

                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }
        public void load_BenhNhan()
        {
            var benhNhanList = bn_bll.getBenhNhan();
            dtgv_BenhNhan.Rows.Clear();
            for (int i = 0; i < benhNhanList.Rows.Count; i++)
            {
                DataRow row = benhNhanList.Rows[i];
                dtgv_BenhNhan.Rows.Add(
                    row["SDT"],
                    row["HoTenBN"],
                    row["MaBN"],
                    row["DiaChi"],
                    row["GioiTinh"],
                    row["Tuoi"],
                    row["CMND_CCCD"],
                    row["DanToc"]
                );
            }
        }

        private void FrmBenhAn_Load(object sender, EventArgs e)
        {
            load_BenhNhan();
        }

        private void txt_GioiTinh_Load(object sender, EventArgs e)
        {

        }

        private void dtgv_BenhNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Search_Load(object sender, EventArgs e)
        {

        }

        private void txt_DiaChi_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_DanToc_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pn_Right_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pn_Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_Tuoi_Load(object sender, EventArgs e)
        {

        }

        private void txt_SDT_Load(object sender, EventArgs e)
        {

        }

        private void txt_HoTen_Load(object sender, EventArgs e)
        {

        }

        private void txt_CCCD_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_MaBN_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
