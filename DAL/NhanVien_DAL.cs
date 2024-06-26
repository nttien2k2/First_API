using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataTable = System.Data.DataTable;

namespace DAL
{
    public class NhanVien_DAL : DbContext
    {
        private readonly DbContext conn = new DbContext();

        public DataTable getNhanVien()
        {
            string query = @"SELECT 
                                NV.MaNV,
                                NV.HoTen, 
                                NV.SDT,
                                NV.DiaChi,
                                NV.Email,
                                NV.MatKhau,
                                NV.CCCD,
                                NV.HocVan,
                                NV.Tuoi,
                                NV.ChucDanh,
                                NV.TrangThai,
                                NV.NgaySinh,
                                PB.TenPhongBan
                            FROM NhanVien NV
                            JOIN PhongBan PB ON NV.MaPhongBan = PB.MaPhongBan
                            WHERE NV.TrangThai = 1
                        ";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public DataTable loadcbo_ChucDanh()
        {
            string query = "SELECT * FROM NhomQuyen";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            DataTable dtNhomQuyen = new DataTable();
            da.Fill(dtNhomQuyen);
            return dtNhomQuyen;
        }
        public string getNhanVienBySDT(string sdt)
        {
            //conn.OpenConnectAsSA();
            conn.OpenConnect();
            string query = "SELECT HoTen FROM NhanVien WHERE SDT = @sdt";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
            string HoTen = (string)cmd.ExecuteScalar();
            //CloseConnect();
            return HoTen;
        }
        public bool insertNhanVien(NhanVien_DTO nhanVien)
        {
            SqlTransaction transaction = null;
            try
            {
                //conn.OpenConnect();
                transaction = conn.Connect.BeginTransaction();

                string query = "INSERT INTO NhanVien (HoTen, SDT, DiaChi, Email, CCCD, HocVan, Tuoi, NgaySinh, AnhDaiDien, ChucDanh, MatKhau, TrangThai, MaPhongBan) " +
                               "VALUES (@HoTen, @SDT, @DiaChi, @Email, @CCCD, @HocVan, @Tuoi, @NgaySinh, @AnhDaiDien, @ChucDanh, @MatKhau, @TrangThai, @MaPhongBan)";
                SqlCommand cmd = new SqlCommand(query, conn.Connect, transaction);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@CCCD", nhanVien.CCCD);
                cmd.Parameters.AddWithValue("@HocVan", nhanVien.HocVan);
                cmd.Parameters.AddWithValue("@Tuoi", nhanVien.Tuoi);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "image1.png");
                cmd.Parameters.AddWithValue("@ChucDanh", nhanVien.ChucDanh);
                cmd.Parameters.AddWithValue("@MaPhongBan", nhanVien.MaPhongBan);
                cmd.Parameters.AddWithValue("@MatKhau", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@TrangThai", 1);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    string loginName = nhanVien.SDT;
                    string passWord = nhanVien.SDT;

                    SqlCommand createAccountCmd = new SqlCommand("proc_CreateAccount", Connect, transaction);
                    createAccountCmd.CommandType = CommandType.StoredProcedure;
                    createAccountCmd.Parameters.AddWithValue("@loginName", loginName);
                    createAccountCmd.Parameters.AddWithValue("@passWord", passWord);

                    try
                    {
                        createAccountCmd.ExecuteNonQuery();
                        transaction.Commit();
                        return true;

                    }
                    catch (SqlException ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Failed to create account: " + ex.Message);
                    }
                }
                else
                {
                    transaction.Rollback();
                }
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool updateNhanVien(NhanVien_DTO nhanVien)
        {
            try
            {
                //conn.OpenConnect();
                string query = "UPDATE NhanVien SET " +
                               "HoTen = @HoTen, " +
                               "SDT = @SDT, " +
                               "DiaChi = @DiaChi, " +
                               "Email = @Email, " +
                               "HocVan = @HocVan, " +
                               "Tuoi = @Tuoi, " +
                               "CCCD = @CCCD, " +
                               "NgaySinh = @NgaySinh, " +
                               "AnhDaiDien = @AnhDaiDien, " +
                               "ChucDanh = @ChucDanh, " +
                               "MatKhau = @MatKhau, " +
                               "MaPhongBan = @MaPhongBan " +
                               "WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, conn.Connect);

                cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV);
                cmd.Parameters.AddWithValue("@HoTen", nhanVien.HoTen);
                cmd.Parameters.AddWithValue("@SDT", nhanVien.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", nhanVien.DiaChi);
                cmd.Parameters.AddWithValue("@Email", nhanVien.Email);
                cmd.Parameters.AddWithValue("@HocVan", nhanVien.HocVan);
                cmd.Parameters.AddWithValue("@Tuoi", nhanVien.Tuoi);
                cmd.Parameters.AddWithValue("@CCCD", nhanVien.CCCD);
                cmd.Parameters.AddWithValue("@NgaySinh", nhanVien.NgaySinh);
                cmd.Parameters.AddWithValue("@AnhDaiDien", "image.jpn");
                cmd.Parameters.AddWithValue("@ChucDanh", nhanVien.ChucDanh);
                cmd.Parameters.AddWithValue("@MatKhau", "123");
                cmd.Parameters.AddWithValue("@MaPhongBan", nhanVien.MaPhongBan);


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
        public bool deleteNhanVien(string sdt)
        {
            try
            {
                //conn.OpenConnect();
                string query = "Update NhanVien SET " +
                                "TrangThai = @TrangThai " +
                                "WHERE SDT = @SDT";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@TrangThai", 0);


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
        public bool deleteNhanVienChuyenKhoa(int maNV)
        {
            try
            {
                //conn.OpenConnect();
                string query = "DELETE FROM CT_ChuyenKhoa WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(query, Connect);

                cmd.Parameters.AddWithValue("@MaNV", maNV);

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
        public DataTable search(string search)
        {
            string query = @"SELECT 
                                NV.MaNV,
                                NV.HoTen, 
                                NV.SDT,
                                NV.DiaChi,
                                NV.Email,
                                NV.MatKhau,
                                NV.CCCD,
                                NV.HocVan,
                                NV.Tuoi,
                                NV.AnhDaiDien,
                                NV.ChucDanh,
                                NV.TrangThai,                                
                                NV.NgaySinh,
                                PB.TenPhongBan
                            FROM NhanVien NV
                            JOIN PhongBan PB ON NV.MaPhongBan = PB.MaPhongBan
                            WHERE NV.TrangThai = 1
                            AND NV.HoTen LIKE '%' + @HoTen + '%'";
            SqlDataAdapter da = new SqlDataAdapter(query, Connect);
            da.SelectCommand.Parameters.AddWithValue("@HoTen", "%" + search + "%");
            DataTable dtNhanVien = new DataTable();
            da.Fill(dtNhanVien);
            return dtNhanVien;
        }
        public int countNhanVien()
        {
            //conn.OpenConnect();
            string query = "SELECT COUNT(*) FROM NHANVIEN";
            SqlCommand cmd = new SqlCommand(query, Connect);
            int tongSoLuongNhanVien = (int)cmd.ExecuteScalar();
            conn.CloseConnect();
            return tongSoLuongNhanVien;
        }
        public int countNhanVienBySearch(string search)
        {
            //conn.OpenConnect();
            string query = "SELECT COUNT(*) FROM NHANVIEN WHERE HoTen LIKE @HoTen";
            SqlCommand cmd = new SqlCommand(query, Connect);
            cmd.Parameters.AddWithValue("@HoTen", "%" + search + "%");
            int soLuongNhanVien = (int)cmd.ExecuteScalar();
            conn.CloseConnect();
            return soLuongNhanVien;
        }
        public bool XoaTaiKhoanNhanVien(string sdt)
        {
            try
            {
                conn.OpenConnect();
                //string loginName = sdt;
                SqlCommand cmd = new SqlCommand("proc_XoaTaiKhoanDangNhap", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoginName", sdt);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool insertNhomQuyen(string roleName)
        {
            try
            {
                conn.OpenConnect();
                SqlCommand cmd = new SqlCommand("proc_AddRole", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", roleName);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }
        public bool deleteNhomQuyen(string roleName)
        {
            try
            {
                conn.OpenConnect();
                SqlCommand cmd = new SqlCommand("proc_DropRole", Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", roleName);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                conn.CloseConnect();
            }
            return false;
        }
    }
}
