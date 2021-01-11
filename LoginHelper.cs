using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckIn
{
    public class LoginHelper
    {
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
