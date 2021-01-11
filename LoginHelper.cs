using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckIn
{
    public static class LoginHelper
    {
        public static Dictionary<string, string> GetLoginInfoFormConfig()
        {
            var dictLoginInfo = new Dictionary<string, string>();
            dictLoginInfo.Add("account", ConfigHelper.GetAppConfig("account"));
            dictLoginInfo.Add("password", ToMD5(ConfigHelper.GetAppConfig("password")));
            return dictLoginInfo;
        }
        public static void UpdateLoginInfoToConfig(Dictionary<string, string> dictLoginInfo)
        {
            ConfigHelper.UpdateAppConfig("account", dictLoginInfo["account"]);
            ConfigHelper.UpdateAppConfig("password", ToMD5(dictLoginInfo["password"]));
        }

        //check if this account is in db
        public static bool CheckAccount(string strAccount) => new DataBaseHelper().CheckAccount(strAccount);
        //check if this login is correct
        public static bool CheckLogin(string strAccount, string strPassword) => new DataBaseHelper().CheckLogin(strAccount, ToMD5(strPassword));
        public static (bool, string) Register(string strAccount, string strPassword) => new DataBaseHelper().Register(strAccount, ToMD5(strPassword));
        private static string ToMD5(string strs)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(strs);
            byte[] encryptdata = md5.ComputeHash(bytes);
            return Convert.ToBase64String(encryptdata);
        }
    }
}
