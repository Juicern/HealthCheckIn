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
        public static Person GetLoginInfoFormConfig()
        {
            return new Person
            {
                account = ConfigHelper.GetAppConfig(ParameterHelper.personAccount),
                password = ConfigHelper.GetAppConfig(ParameterHelper.personPassword)
            };
        }
        public static void UpdateLoginInfoToConfig(Person person)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.personAccount, person.account);
            ConfigHelper.UpdateAppConfig(ParameterHelper.personPassword, person.password);
        }

        //check if this account is in db
        public static bool CheckAccount(string strAccount) => DataBaseHelper.GetInstance().CheckAccount(ParameterHelper.personInfo, strAccount);
        //check if this login is correct
        public static bool CheckLogin(string strAccount, string strPassword) => DataBaseHelper.GetInstance().CheckLogin(ParameterHelper.personInfo, strAccount, ToMD5(strPassword));
        public static (bool, string) Register(string strAccount, string strPassword) => DataBaseHelper.GetInstance().Register(ParameterHelper.personInfo, strAccount, ToMD5(strPassword));
        private static string ToMD5(string strs)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.Default.GetBytes(strs);
            byte[] encryptdata = md5.ComputeHash(bytes);
            return Convert.ToBase64String(encryptdata);
        }
    }
}
