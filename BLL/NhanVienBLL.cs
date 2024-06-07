using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBLL
    {
        NhanVien_DAL nv_dal = new NhanVien_DAL();
        public DataTable getNhanVien()
        {
            return nv_dal.getNhanVien();
        }
        public bool insertNhanVien(NhanVien_DTO nv)
        {
            return nv_dal.insertNhanVien(nv);
        }
        public bool updateNhanVien(NhanVien_DTO nv)
        {
            return nv_dal.updateNhanVien(nv);
        }
        public bool deleteNhanVien(int maNV)
        {
            return nv_dal.deleteNhanVien(maNV);
        }
        public DataTable search(string search)
        {
            return nv_dal.search(search);
        }
        public int countNhanVien()
        {
            return nv_dal.countNhanVien();
        }
    }
}
