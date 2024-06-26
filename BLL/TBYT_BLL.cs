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
    public class ThietBYT_BLL
    {
        ThietBYT_DAL tBYT_dal = new ThietBYT_DAL();
        public DataTable getTBYT()
        {
            return tBYT_dal.getTBYT();
        }
        public bool insertTBYT(ThietBiYT_Dto t)
        {
            return tBYT_dal.insertTBYT(t);
        }
        public bool updateTBYT(ThietBiYT_Dto t)
        {
            return tBYT_dal.updateTBYT(t);
        }
        public bool deleteTBYT(int maTBYT)
        {
            return tBYT_dal.deleteTBYT(maTBYT);
        }
    }
}
