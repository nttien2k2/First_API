using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThietBYT_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getTBYT()
        {
            string query = "SELECT * FROM ThietBiYT";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtTBYT = new DataTable();
            da.Fill(dtTBYT);
            return dtTBYT;
        }

        public bool insertTBYT(ThietBiYT_Dto tb)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO ThietBiYT (TenTBYT, SoLuong, MaLoaiTBYT) " +
                               "VALUES (@TenTBYT, @SoLuong, @MaLoaiTBYT)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@TenTBYT", tb.TenTBYT);
                cmd.Parameters.AddWithValue("@SoLuong", tb.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoaiTBYT", tb.MaLoaiTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }

        public bool updateTBYT(ThietBiYT_Dto tb)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE TBYT " +
                               "SET TenTBYT = @TenTBYT, " +
                                   "SoLuong = @SoLuong, " +
                                   "MaLoaiTBYT = @MaLoaiTBYT " +
                               "WHERE MaTBYT = @MaTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaTBYT", tb.MaTBYT);
                cmd.Parameters.AddWithValue("@TenTBYT", tb.TenTBYT);
                cmd.Parameters.AddWithValue("@SoLuong", tb.SoLuong);
                cmd.Parameters.AddWithValue("@MaLoaiTBYT", tb.MaLoaiTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }

        public bool deleteTBYT(int maTBYT)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM TBYT WHERE MaTBYT = @MaTBYT";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaTBYT", maTBYT);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
    }
}
