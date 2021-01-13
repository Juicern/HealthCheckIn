using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public class PersonLoginHelper
    {
        /// <summary>
        /// 从配置文件中获得人员登录信息
        /// </summary>
        /// <returns>人员登录信息</returns>
        public static Person GetLoginInfoFormConfig()
        {
            return new Person
            {
                account = ConfigHelper.GetAppConfig(ParameterHelper.personAccount),
                password = ConfigHelper.GetAppConfig(ParameterHelper.personPassword)
            };
        }
        /// <summary>
        /// 更新人员登录信息的配置
        /// </summary>
        /// <param name="person">人员信息</param>
        public static void UpdateLoginInfoToConfig(Person person)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.personAccount, person.account);
            ConfigHelper.UpdateAppConfig(ParameterHelper.personPassword, person.password);
        }

        /// <summary>
        /// 判断人员账号是否在数据库
        /// </summary>
        /// <param name="strAccount">人员账号</param>
        /// <returns></returns>
        public static bool CheckAccount(string strAccount) => DataBaseHelper.GetInstance().CheckAccount(ParameterHelper.personInfo, strAccount);
        /// <summary>
        /// 判断人员密码是否正确
        /// </summary>
        /// <param name="strAccount">人员账号</param>
        /// <param name="strPassword">人员密码</param>
        /// <returns></returns>
        public static bool CheckLogin(string strAccount, string strPassword) => DataBaseHelper.GetInstance().CheckLogin(ParameterHelper.personInfo, strAccount, ToMD5(strPassword));
        /// <summary>
        /// 注册人员信息
        /// </summary>
        /// <param name="strAccount">人员账号</param>
        /// <param name="strPassword">人员信息</param>
        /// <returns>（是否成功注册，错误信息）</returns>
        public static (bool, string) Register(string strAccount, string strPassword) => DataBaseHelper.GetInstance().Register(ParameterHelper.personInfo, strAccount, ToMD5(strPassword));
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
