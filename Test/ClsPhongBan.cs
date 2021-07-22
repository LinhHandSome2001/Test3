using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Test
{
    public class ClsPhongBan
    {
        public DataTable DanhSachPhongBan_all()
        {
            try
            {
                string str = "sp_PhongBan_SelectAll";
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

        public DataTable DanhSachPhongBan_Goc()
        {
            try
            {
                string str = "sp_PhongBan_Select_Goc";
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

        public DataTable DanhSachPhongBan_Con(string maphongcha)
        {
            try
            {
                string str = "sp_PhongBan_Select_Con";
                object[] objUser = new object[1];
                objUser[0] = maphongcha;

                DataTable dt = new DataTable();
                dt = ClsSupportDB.ReturnDatatable(str, objUser);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
