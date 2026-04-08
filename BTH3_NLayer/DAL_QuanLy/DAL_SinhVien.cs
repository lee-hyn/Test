using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO_QuanLy;

namespace DAL_QuanLy
{
     public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select* from SinhVien", conn);
            DataTable dtSinhVien = new DataTable();
            da.Fill(dtSinhVien);
            return dtSinhVien;
        }

        //THEM SINH VEIN
        public bool themSinhVien(DTO_SinhVien sv)
        {
            try
            {
                conn.Open();
                string SQL = string.Format("INSERT INTO SINHVIEN(SV_NAME, SV_PHONE, SV_EMAIL) VALUES ('{0}','{1}','{2}')",
                                            sv.SINHVIEN_NAME, sv.SINHVIEN_PHONE, sv.SINHVIEN_EMAIL);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            } 
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //SUA SINH VIEN
        public bool suaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                conn.Open();
                string sql = string.Format(@"UPDATE SINHVIEN SET SV_NAME = '{0}',
                                             SV_PHONE = '{1}', SV_EMAIL = '{2}'
                                             WHERE SV_ID = '{3}'", sv.SINHVIEN_NAME, sv.SINHVIEN_PHONE,
                                             sv.SINHVIEN_EMAIL, sv.SINHVIEN_ID);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        //XOA SINH VIEN
        public bool xoaSinhVien(int SV_id)
        {
            try
            {
                conn.Open();
                string sql = string.Format("DELETE FROM SINHVIEN WHERE SV_ID = '{0}'", SV_id);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
