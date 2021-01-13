using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class ParameterHelper
    {
        #region 数据库表名
        public const string personInfo = "personInfo";      // 人员信息表
        public const string submitInfo = "submitInfo";      // 提交信息表
        public const string managerInfo = "managerInfo";    // 管理员信息表
        #endregion

        #region 配置文件变量名
        public const string personAccount = "personAccount";        //人员账号配置
        public const string personPassword = "personPassword";      //人员密码配置
        public const string managerAccount = "managerAccount";      //管理员账号配置
        public const string managerPassword = "managerPassword";    //管理员密码配置
        #endregion

        #region 数据库列名
        public const string account = "account";            // 账号列名
        public const string password = "password";          // 密码列名
        public const string time = "time";                  // 时间列名
        public const string temperature = "temperature";    // 体温列名
        public const string health = "health";              // 健康列名
        public const string location = "location";          // 地点列名
        #endregion
    }
}
