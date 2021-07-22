using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    public class ClsUser
    {
        public bool KiemTraUser(string username, string password)
        {
            try
            {
                string str = "sp_KiemTraUser";
                object[] objUser = new object[2];
                objUser[0] = username;
                objUser[1] = password;
                DataTable dt = new DataTable();
                dt = ClsSupportDB.ReturnDatatable(str, objUser);
                if (dt != null && dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public DataTable DanhSachNhanVien_all()
        {
            try
            {
                string str = "sp_User_SelectAll";
                object[] objUser = new object[0];

                DataTable dt = new DataTable();
                dt = ClsSupportDB.ReturnDatatable(str, objUser);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable DanhSachNhanVien_TheoPhongBan(string maphongban)
        {
            try
            {
                string str = "sp_User_Select_PhongBan";
                object[] objUser = new object[1];
                objUser[0] = maphongban;

                DataTable dt = new DataTable();
                dt = ClsSupportDB.ReturnDatatable(str, objUser);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable DanhSachNhanVien_TheoPhongBan_TenNV(string maphongban, string TenTimKiem)
        {
            try
            {
                string str = "sp_User_Select_PhongBan_TenNV";
                object[] objUser = new object[2];
                objUser[0] = maphongban;
                objUser[1] = TenTimKiem;

                DataTable dt = new DataTable();
                dt = ClsSupportDB.ReturnDatatable(str, objUser);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool InsertNhanVien(string tenNV, string ngaysinh, bool gt, string diachi, string tendangnhap, string matkhau)
        {
            try
            {
                string str = "sp_User_Insert";
                object[] objUser = new object[6];
                objUser[0] = tenNV;
                objUser[1] = ngaysinh;
                objUser[2] = gt;
                objUser[3] = diachi;
                objUser[4] = tendangnhap;
                objUser[5] = matkhau;

                return ClsSupportDB.ExecuteProcedure(str, objUser);
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
