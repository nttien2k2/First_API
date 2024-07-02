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
    public class DichVu_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getDichVu()
        {
            string query = "select dv.MaDichVu, dv.TenDichVu, dv.Gia, ck.TenChuyenKhoa from DichVu dv join ChuyenKhoa ck on dv.MaChuyenKhoa = ck.MaChuyenKhoa";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtDichVu = new DataTable();
            da.Fill(dtDichVu);
            return dtDichVu;
        }
        public bool insertDichVu(DichVu_DTO dichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "INSERT INTO DichVu (TenDichVu, Gia, MaChuyenKhoa) " +
                               "VALUES (@TenDichVu, @Gia, @MaChuyenKhoa)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                //cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                cmd.Parameters.AddWithValue("@Gia", dichVu.Gia);
                cmd.Parameters.AddWithValue("@MaChuyenKhoa", dichVu.MaChuyenKhoa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool updateDichVu(DichVu_DTO dichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE DichVu " +
                               "SET TenDichVu = @TenDichVu, " +
                                   "Gia = @Gia, " +
                                   "MaChuyenKhoa = @MaChuyenKhoa " +
                               "WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaDichVu", dichVu.MaDichVu);
                cmd.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                cmd.Parameters.AddWithValue("@Gia", dichVu.Gia);
                cmd.Parameters.AddWithValue("@MaChuyenKhoa", dichVu.MaChuyenKhoa);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }

        public bool deleteDichVu(int maDichVu)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM DichVu WHERE MaDichVu = @MaDichVu";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaDichVu", maDichVu);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }


    }
}
