using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class ManagerHelper
    {
        public static List<Person> GetAllPersons() => DataBaseHelper.GetInstance().GetAllPersons(ParameterHelper.personInfo).ToList();
        public static List<Submit> GetAllSubmits() => DataBaseHelper.GetInstance().GetAllSubmits(ParameterHelper.submitInfo).ToList();
        public static List<Submit> GetPersonSubmits(string strAccount) => DataBaseHelper.GetInstance().GetPersonSubmits(ParameterHelper.submitInfo, strAccount).ToList();
    }
}
