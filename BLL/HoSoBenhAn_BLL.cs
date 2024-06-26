using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;

namespace BLL
{
    public class HoSoBenhAn_BLL
    {
        HoSoBenhAn_DAL hsba_dal = new HoSoBenhAn_DAL();
        public DataTable getHoSoBenhAn(int MaBN)
        {
            return hsba_dal.getHoSoBenhAn(MaBN);
        }
        public bool insertHpSoBenhAn(HoSoBenhAn_DTO hsba)
        {
            return hsba_dal.insertHoSoBenhAn(hsba);
        }
    }
}
