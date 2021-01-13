using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public struct Person
    {
        public string account;
        public string password;
    } 
    public struct Submit
    {
        public string account;
        public string time;
        public string temperature;
        public string health;
        public string location;
    }
    public struct Manager
    {
        public string account;
        public string password;
    }
}
