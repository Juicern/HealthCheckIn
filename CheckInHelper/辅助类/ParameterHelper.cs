using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class ParameterHelper
    {
        //数据库名称
        public const string personInfo = "personInfo";
        public const string submitInfo = "submitInfo";
        public const string managerInfo = "managerInfo";

        //配置文件变量名
        public const string personAccount = "personAccount";
        public const string personPassword = "personPassword";
        public const string managerAccount = "managerAccount";
        public const string managerPassword = "managerPassword";

        //数据库列名
        public const string account = "account";
        public const string password = "password";
        public const string time = "time";
        public const string temperature = "temperature";
        public const string health = "health";
        public const string location = "location";
    }
}
