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

        private string strConn = @"server=SURFACE-PRO;database=HealthCheckIn;uid=sa;pwd=123456;";
        //private string strConn = "Server=SURFACE-PRO;Database=HealthCheckIn;Integrated Security = true;";
        private SqlConnection conn;
        public DataBaseHelper()
        {
            conn = new SqlConnection(strConn);
            if(conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }
        /// <summary>
        /// 检查账号是否存在
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <returns></returns>
        public bool CheckAccount(string strAccount)
        {
            try
            {
                string sql = $"select * from personInfo where account = '{strAccount}'";
                var com = new SqlCommand(sql, conn);
                if (com.ExecuteReader().HasRows) return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        /// 检查账号密码是否正确
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <param name="strPassword">密码</param>
        /// <returns></returns>
        public bool CheckLogin(string strAccount, string strPassword)
        {
            try
            {
                string sql = $"select * from personInfo where account = '{strAccount}' and password = '{strPassword}'";
                var com = new SqlCommand(sql, conn);
                if (com.ExecuteReader().HasRows) return true;
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        /// 注册到数据库
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <param name="strPassword">密码</param>
        /// <returns></returns>
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
        /// <summary>
        /// 更新数据库的提交信息
        /// </summary>
        /// <param name="dictSubmitInfo">所有提交信息</param>
        /// <returns></returns>
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
