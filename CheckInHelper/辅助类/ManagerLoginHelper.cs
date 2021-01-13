using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public class ManagerLoginHelper
    {
        /// <summary>
        /// 从配置文件中读出管理员登录信息
        /// </summary>
        /// <returns>管理员登录信息</returns>
        public static Manager GetLoginInfoFormConfig()
        {
            return new Manager
            {
                account = ConfigHelper.GetAppConfig(ParameterHelper.managerAccount),
                password = ConfigHelper.GetAppConfig(ParameterHelper.managerPassword)
            };
        }
        /// <summary>
        /// 更新管理员登录信息的配置文件
        /// </summary>
        /// <param name="manager">管理员登录信息</param>
        public static void UpdateLoginInfoToConfig(Manager manager)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.managerAccount, manager.account);
            ConfigHelper.UpdateAppConfig(ParameterHelper.managerPassword, manager.password);
        }

        /// <summary>
        /// 判断账户是否在系统中你给
        /// </summary>
        /// <param name="strAccount">账户</param>
        /// <returns></returns>
        public static bool CheckAccount(string strAccount) => DataBaseHelper.GetInstance().CheckAccount(ParameterHelper.managerInfo, strAccount);
        /// <summary>
        /// 判断密码是否正确
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <param name="strPassword">密码</param>
        /// <returns></returns>
        public static bool CheckLogin(string strAccount, string strPassword) => DataBaseHelper.GetInstance().CheckLogin(ParameterHelper.managerInfo, strAccount, ToMD5(strPassword));
        /// <summary>
        /// 注册管理员账户
        /// </summary>
        /// <param name="strAccount">账号</param>
        /// <param name="strPassword">密码</param>
        /// <returns>（是否成功注册，错误信息）</returns>
        public static (bool, string) Register(string strAccount, string strPassword) => DataBaseHelper.GetInstance().Register(ParameterHelper.managerInfo, strAccount, ToMD5(strPassword));
        /// <summary>
        /// MD5加密算法
        /// </summary>
        /// <param name="strs">传入数据</param>
        /// <returns>加密后的数据</returns>
        private static string ToMD5(string strs)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(strs);
            byte[] encryptdata = md5.ComputeHash(bytes);
            return Convert.ToBase64String(encryptdata);
        }
    }
}
