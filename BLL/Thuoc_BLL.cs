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
    public class Thuoc_BLL
    {
        Thuoc_DAL t_dal = new Thuoc_DAL();
        public DataTable getThuoc()
        {
            return t_dal.getThuoc();
        }
        public bool insertThuoc(Thuoc_DTO t)
        {
            return t_dal.insertThuoc(t);
        }
        public bool updateThuoc(Thuoc_DTO t)
        {
            return t_dal.updateThuoc(t);
        }
        public bool deleteThuoc(int maThuoc)
        {
            return t_dal.deleteThuoc(maThuoc);
        }
    }
}
