using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    // 人员
    public struct Person
    {
        public string account;  // 人员账号
        public string password; // 人员密码
    } 

    // 打卡提交
    public struct Submit
    {
        public string account;      // 账号
        public string time;         // 时间
        public string temperature;  // 体温
        public string health;       // 健康
        public string location;     // 地点
    }

    // 管理员
    public struct Manager
    {
        public string account;  // 管理员账号
        public string password; // 管理员密码
    }
}
