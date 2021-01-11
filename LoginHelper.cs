using System;
using System.Collections.Generic;
using System.Linq;
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
            dictLoginInfo.Add("password", ConfigHelper.GetAppConfig("password"));
            return dictLoginInfo;
        }
        public static void UpdateLoginInfoToConfig(Dictionary<string, string> dictLoginInfo)
        {
            ConfigHelper.UpdateAppConfig("account", dictLoginInfo["account"]);
            ConfigHelper.UpdateAppConfig("password", dictLoginInfo["password"]);
        }
        public static bool CheckAccount(string strAccount)
        {
            //check if this account is in db
            return true;
        }
        public static bool CheckLogin(string strAccount, string strPassword)
        {
            //check if this login is correct
            return true;
        }
        public static (bool, string) Register(string strAccount, string strPassword)
        {
            try
            {
                //register
                return (true, "ok");
            }
            catch
            {
                return (false, "未知原因");
            }
        }
    }
}
