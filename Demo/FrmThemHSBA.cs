using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmThemHSBA : Form
    {
        HoSoBenhAn_BLL hsba_bll = new HoSoBenhAn_BLL();
        public FrmThemHSBA()
        {
            InitializeComponent();
        }

        private void btn_ThemPB_Click(object sender, EventArgs e)
        {
            if (cbb_SDTBenhNhan.Text == "" || cbb_NhanVien.Text == "" || txt_ChanDoanBanDau.Text == "" || txt_LyDoKham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin hồ sơ bệnh án!");
                return;
            }
            DateTime ngaykham = dtPicker_NgayKham.Value;
            HoSoBenhAn_DTO hoSoBenhAn = new HoSoBenhAn_DTO();
            hoSoBenhAn.MaBN = int.Parse(cbb_SDTBenhNhan.Text);
            hoSoBenhAn.MaNV = int.Parse(cbb_NhanVien.Text);
            hoSoBenhAn.NgayKham = ngaykham;
            hoSoBenhAn.ChanDoanBanDau = txt_ChanDoanBanDau.Text;
            hoSoBenhAn.DieuTri = txt_DieuTri.Text;
            hoSoBenhAn.GhiChu = txt_GhiChu.Text;
            hoSoBenhAn.LyDoKham = txt_LyDoKham.Text;
            hoSoBenhAn.KetQuaKham = txt_KetQuaKham.Text;

            if (hsba_bll.insertHpSoBenhAn(hoSoBenhAn))
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thành công");
                //RefreshHoSoBenhAn();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thêm hồ sơ bệnh án thất bại");
            }
        }
    }
}
