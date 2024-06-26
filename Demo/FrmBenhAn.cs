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
using GUI;

namespace Demo
{
    public partial class FrmBenhAn : Form
    {
        BenhNhan_BLL bn_bll = new BenhNhan_BLL();
        HoSoBenhAn_BLL hsba_bll = new HoSoBenhAn_BLL();  
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
            
            if(hsba_bll.getHoSoBenhAn(int.Parse(txt_MaBN.Text)).Rows.Count == 0)
            {
                MessageBox.Show("Bệnh nhân "+ txt_HoTen + " chưa có hồ sơ bệnh án." ,"Thông báo");
            }
            else
            {
                load_HoSoBenhAn();
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SDT của bệnh nhân muốn tìm kiếm!!!", "Thông báo");
            }
            else
            {
                string search = txt_Search.Text;
                var benhNhanList = bn_bll.search(search);
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
        public void load_HoSoBenhAn()
        {
            int MaBn = int.Parse(txt_MaBN.Text);
            var hoSoBenhAnList = hsba_bll.getHoSoBenhAn(MaBn);
            dtgv_HoSoBenhAn.Rows.Clear();
            for (int i = 0; i < hoSoBenhAnList.Rows.Count; i++)
            {
                DataRow row = hoSoBenhAnList.Rows[i];
                DateTime ngayKham = Convert.ToDateTime(row["NgayKham"]);
                string formattedNgayKham = ngayKham.ToString("dd/MM/yyyy");
                dtgv_HoSoBenhAn.Rows.Add(
                    row["LyDoKham"],
                    formattedNgayKham,
                    row["ChanDoanBanDau"],
                    row["DieuTri"], 
                    row["GhiChu"],
                    row["KetQuaKham"]
                );
            }
        }
        private void FrmBenhAn_Load(object sender, EventArgs e)
        {
            txt_NgayKham.Enabled = false;
            txt_LyDoKham.Enabled = false;
            txt_KetQuaKham.Enabled = false;
            txt_ChanDoan.Enabled = false;
            txt_DieuTri.Enabled = false;
            txt_GhiChu.Enabled = false;
        }
        private void dtgv_HoSoBenhAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgv_HoSoBenhAn.Rows.Count)
            {
                DataGridViewRow row = dtgv_HoSoBenhAn.Rows[e.RowIndex];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Kiểm tra xem cột có dữ liệu hay không
                    if (cell.Value != null)
                    {
                        txt_NgayKham.Text = row.Cells["NgayKham"].Value.ToString();
                        txt_ChanDoan.Text = row.Cells["ChanDoan"].Value.ToString();
                        txt_DieuTri.Text = row.Cells["DieuTri"].Value.ToString();
                        txt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
                        txt_LyDoKham.Text = row.Cells["LyDoKham"].Value.ToString();
                        txt_KetQuaKham.Text = row.Cells["KetQuaKham"].Value.ToString();
                    }
                }
            }
        }

        private void toolStripBtn_Luu_Click(object sender, EventArgs e)
        {

        }
        private void btn_ThemMoiHSBA_Click(object sender, EventArgs e)
        {
            FrmThemHSBA fHSBA = new FrmThemHSBA();
            fHSBA.Show();
            this.Hide();
        }
    }
}
