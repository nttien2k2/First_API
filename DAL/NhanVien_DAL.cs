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
    public class NhanVien_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getNhanVien()
        {
            string query = "SELECT * FROM NHANVIEN";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public bool insertNhanVien(NhanVien_DTO nhanVien)
        {
            try
            {
                conn.OpenConnect();
                string query = "INSERT INTO NhanVien (HoTen, SDT, DiaChi, Email, KinhNghiem, HocVan, Tuoi, AnhDaiDien, ChucVu, MatKhau) " +
                               "VALUES (@HoTen, @SDT, @DiaChi, @Email, @KinhNghiem, @HocVan, @Tuoi, @AnhDaiDien, @ChucVu, @MatKhau)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                //cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@KinhNghiem", "Khong co");
                cmd.Parameters.AddWithValue("@HocVan", nhanVien.HocVan);
                cmd.Parameters.AddWithValue("@Tuoi", nhanVien.Tuoi);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "image1.png");
                cmd.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                cmd.Parameters.AddWithValue("@MatKhau", "123");

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
        public bool updateNhanVien(NhanVien_DTO nhanVien)
        {
            try
            {
                conn.OpenConnect();
                string query = "UPDATE NhanVien SET " +
                               "HoTen = @HoTen, " +
                               "SDT = @SDT, " +
                               "DiaChi = @DiaChi, " +
                               "Email = @Email, " +
                               "KinhNghiem = @KinhNghiem, " +
                               "HocVan = @HocVan, " +
                               "Tuoi = @Tuoi, " +
                               "AnhDaiDien = @AnhDaiDien, " +
                               "ChucVu = @ChucVu, " +
                               "MatKhau = @MatKhau " +
                               "WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@KinhNghiem", "Sửa lần 1");
                cmd.Parameters.AddWithValue("@HocVan", nhanVien.HocVan);
                cmd.Parameters.AddWithValue("@Tuoi", nhanVien.Tuoi);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "image.jpn");
                cmd.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu);
                cmd.Parameters.AddWithValue("@MatKhau", "123");

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
