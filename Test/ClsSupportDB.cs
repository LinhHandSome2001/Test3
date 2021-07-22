using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Test
{
    public class ClsSupportDB
    {
        public static DataTable ReturnDatatable(string str, params object[] ds_thamso)
        {
            try
            {
                SqlDataAdapter sqlAdap = new SqlDataAdapter(getSQL(str, ds_thamso), ClsKetNoi.con);
                DataTable dt = new DataTable();
                sqlAdap.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool ExecuteProcedure(string str, params object[] ds_thamso)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(getSQL(str, ds_thamso), ClsKetNoi.con);
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static string getSQL(string str, params object[] ds_thamso)
        {
            string sql = "";
            for(int i =0; i<ds_thamso.Length;i++)
            {
                switch (ds_thamso[i].GetType().ToString())
                {
                    case "System.String":
                        sql += ",N'" + ds_thamso[i] + "'";
                        break;
                    case "System.DateTime":
                        sql += ",'" + ds_thamso[i] + "'";
                        break;
                    case "System.Boolean":
                        if ((bool)ds_thamso[i])
                            sql += ",1";
                        else
                            sql += ",0";
                        break;
                    case "System.Int16":
                        sql += "," + ds_thamso[i].ToString() ;
                        break;
                    case "System.Int32":
                        sql += "," + ds_thamso[i].ToString();
                        break;
                    case "System.Int64":
                        sql += "," + ds_thamso[i].ToString();
                        break;
                    case "System.Double":
                        sql += "," + ds_thamso[i].ToString();
                        break;
                    case "System.Byte":
                        sql += "," + ds_thamso[i].ToString();
                        break;
                }
            }
            if (sql.Equals(""))
                sql = str;
            else
                sql = str + " " + sql.Substring(1);
            return sql;
        }
    }
}
