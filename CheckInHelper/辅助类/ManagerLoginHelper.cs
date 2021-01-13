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
        public static Manager GetLoginInfoFormConfig()
        {
            return new Manager
            {
                account = ConfigHelper.GetAppConfig(ParameterHelper.managerAccount),
                password = ConfigHelper.GetAppConfig(ParameterHelper.managerPassword)
            };
        }
        public static void UpdateLoginInfoToConfig(Manager manager)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.managerAccount, manager.account);
            ConfigHelper.UpdateAppConfig(ParameterHelper.managerPassword, manager.password);
        }

        //check if this account is in db
        public static bool CheckAccount(string strAccount) => DataBaseHelper.GetInstance().CheckAccount(ParameterHelper.managerInfo, strAccount);
        //check if this login is correct
        public static bool CheckLogin(string strAccount, string strPassword) => DataBaseHelper.GetInstance().CheckLogin(ParameterHelper.managerInfo, strAccount, ToMD5(strPassword));
        public static (bool, string) Register(string strAccount, string strPassword) => DataBaseHelper.GetInstance().Register(ParameterHelper.managerInfo, strAccount, ToMD5(strPassword));
        private static string ToMD5(string strs)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(strs);
            byte[] encryptdata = md5.ComputeHash(bytes);
            return Convert.ToBase64String(encryptdata);
        }
    }
}
