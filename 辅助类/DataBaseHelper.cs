using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckIn
{
    public class DataBaseHelper
    {

        private string strConn = "server=SURFACE-PRO;database=HealthCheckIn;uid=sa;pwd=123456";
        private SqlConnection conn;
        public DataBaseHelper()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        ~DataBaseHelper()
        {
            conn.Close();
            //关闭连接
        }
        public bool CheckAccount(string strAccount)
        {
            try
            {
                string sql = $"select * from personInfo where account = '{strAccount}'";
                var com = new SqlCommand(sql, conn);
                if (com.ExecuteReader() == null) return false;
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool CheckLogin(string strAccount, string strPassword)
        {
            try
            {
                string sql = $"select * from personInfo where account = '{strAccount}' and password = '{strPassword}'";
                var com = new SqlCommand(sql, conn);
                if (com.ExecuteReader() == null) return false;
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public (bool, string) Register(string strAccount, string strPassword)
        {
            try
            {
                string sql = $"insert into personInfo values('{strAccount}', '{strPassword}')";
                var com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                return (true, "ok");
            }
            catch(Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public bool UpdateSubmitInfo(Dictionary<string, string> dictSubmitInfo)
        {
            try
            {
                string sql = $"insert into submitInfo values('{dictSubmitInfo["account"]}', '{dictSubmitInfo["time"]}', '{dictSubmitInfo["temperature"]}', '{dictSubmitInfo["health"]}', '{dictSubmitInfo["location"]}')";
                var com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}
