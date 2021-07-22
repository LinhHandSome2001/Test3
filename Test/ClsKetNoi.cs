using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml;

namespace Test
{
    
    class ClsKetNoi
    {
        public static string str_ketnoi = "";
        public static SqlConnection con;
        public bool kt = false;

        public ClsKetNoi()
        {
            
        }

        public bool ketnoi(string server, string user, string pass, string csdl)
        {
            try
            {
                str_ketnoi = "Data Source=" +server + ";Initial Catalog="+ csdl +";User ID=" + user + ";Password=" + pass;
                con = new SqlConnection(str_ketnoi);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối tới CSDL được!");
                return false;
            }
        }

        public static void ConectionString()
        {
            XmlDocument xmlDoc = XML.XMLReader("config.txt");
            XmlElement xmlEle = xmlDoc.DocumentElement;
            try
            {
                string DataSource = xmlEle.SelectSingleNode("servername").InnerText;
                string Username = xmlEle.SelectSingleNode("username").InnerText;
                string Password = xmlEle.SelectSingleNode("password").InnerText;
                string Database = xmlEle.SelectSingleNode("database").InnerText;
                str_ketnoi = "Data Source=" + DataSource + ";Initial Catalog=" + Database + ";User ID=" + Username + ";Password=" + Password;
            }
            catch(Exception ex)
            {

            }
        }

        public static bool OpenConection()
        {
            if (str_ketnoi == "")
                //str_ketnoi = "Data Source=" + server + ";Initial Catalog=" + csdl + ";User ID=" + user + ";Password=" + pass;
                ConectionString();
            try
            {
                if (con == null)
                    con = new SqlConnection(str_ketnoi);
                if (con.State == System.Data.ConnectionState.Closed)
                    con.Open();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                return false;
            }
        }
    }

    public class XML
    {
        public static XmlDocument XMLReader(string filename)
        {
            XmlDocument xmlR = new XmlDocument();
            try
            {
                xmlR.Load(filename);
            }
            catch(Exception ex)
            {

            }
            return xmlR;
        }

        public static bool LuuXML(string filename, string server, string user, string pass, string database)
        {
            try
            {
                XmlDocument xmlDoc = XML.XMLReader(filename);
                XmlElement xmlEle = xmlDoc.DocumentElement;
                xmlEle.SelectSingleNode("servername").InnerText = server;
                xmlEle.SelectSingleNode("username").InnerText = user;
                xmlEle.SelectSingleNode("password").InnerText = pass;
                xmlEle.SelectSingleNode("database").InnerText = database;
                xmlDoc.Save(filename);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
