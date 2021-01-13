using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public class DataBaseHelper
    {

        private const string strConn = @"server=SURFACE-PRO;database=HealthCheckIn;uid=sa;pwd=123456;MultipleActiveResultSets=true";
        //private string strConn = "Server=SURFACE-PRO;Database=HealthCheckIn;Integrated Security = true;";
        private SqlConnection conn;
        private static DataBaseHelper instance;
        private DataBaseHelper()
        {
            conn = new SqlConnection(strConn);
            if(conn.State == System.Data.ConnectionState.Closed) conn.Open();
        }
        
        public static DataBaseHelper GetInstance()
        {
            if(instance == null)
            {
                instance = new DataBaseHelper();
            }
            return instance;
        }
        /// <summary>
        /// 检查账号是否存在
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <returns></returns>
        public bool CheckAccount(string strDataBase, string strAccount)
        {
            try
            {
                var sql = $"select {ParameterHelper.account} from {strDataBase} where account = '{strAccount}'";
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
        public bool CheckLogin(string strDataBase, string strAccount, string strPassword)
        {
            try
            {
                var sql = $"select {ParameterHelper.account}, {ParameterHelper.password} from {strDataBase} where account = '{strAccount}' and password = '{strPassword}'";
                var com = new SqlCommand(sql, conn);
                if (com.ExecuteReader().HasRows) return true;
                return false;
            }
            catch(Exception ex)
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
        public (bool, string) Register(string strDataBase, string strAccount, string strPassword)
        {
            try
            {
                var sql = $"insert into {strDataBase} values('{strAccount}', '{strPassword}')";
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
        public bool UpdateSubmitInfo(string strDataBase, Submit submit)
        {
            try
            {
                var sql = $"insert into {strDataBase} values('{submit.account}', '{submit.time}', '{submit.temperature}', '{submit.health}', '{submit.location}')";
                var com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        /// <summary>
        /// 获得所有学生信息
        /// </summary>
        /// <param name="strDataBase">要查询的数据库</param>
        /// <returns>所有学生信息</returns>
        public IEnumerable<Person> GetAllPersons(string strDataBase)
        {
            var sql = $"select {ParameterHelper.account} from {strDataBase} order by {ParameterHelper.account}";
            var com = new SqlCommand(sql, conn);
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                yield return new Person()
                {
                    account = reader[ParameterHelper.account].ToString()
                };
            }
        }
        /// <summary>
        /// 获得所有提交结果
        /// </summary>
        /// <param name="strDataBase">要搜索的数据库</param>
        /// <returns>所有提交结果</returns>
        public IEnumerable<Submit> GetAllSubmits(string strDataBase)
        {
            var sql = $"select {ParameterHelper.account}, {ParameterHelper.time}, {ParameterHelper.temperature}, {ParameterHelper.health}, {ParameterHelper.location} ";
            sql += $"from {strDataBase} order by {ParameterHelper.time} desc" ;
            var com = new SqlCommand(sql, conn);
            var reader = com.ExecuteReader();
            while(reader.Read())
            {
                yield return new Submit()
                {
                    account = reader[ParameterHelper.account].ToString(),
                    time = reader[ParameterHelper.time].ToString(),
                    temperature = reader[ParameterHelper.temperature].ToString(),
                    health = reader[ParameterHelper.health].ToString(),
                    location = reader[ParameterHelper.location].ToString()
                };
            }
        }
        /// <summary>
        /// 根据学生账号获得其提交记录
        /// </summary>
        /// <param name="strDataBase">要搜索的数据库</param>
        /// <param name="strAccount">学生账号</param>
        /// <returns>学生提交记录</returns>
        public IEnumerable<Submit> GetPersonSubmits(string strDataBase, string strAccount)
        {
            var sql = $"select {ParameterHelper.account}, {ParameterHelper.time}, {ParameterHelper.temperature}, {ParameterHelper.health}, {ParameterHelper.location} ";
            sql += $"from {strDataBase} where {ParameterHelper.account} = '{strAccount}' order by {ParameterHelper.time} desc";
            var com = new SqlCommand(sql, conn);
            var reader = com.ExecuteReader();
            while (reader.Read())
            {
                yield return new Submit()
                {
                    account = reader[ParameterHelper.account].ToString(),
                    time = reader[ParameterHelper.time].ToString(),
                    temperature = reader[ParameterHelper.temperature].ToString(),
                    health = reader[ParameterHelper.health].ToString(),
                    location = reader[ParameterHelper.location].ToString()
                };
            }
        }
    }
}
