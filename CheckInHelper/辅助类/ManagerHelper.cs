using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class ManagerHelper
    {
        /// <summary>
        /// 获得所有打卡信息，以List返回
        /// </summary>
        /// <returns>所有学生信息</returns>
        public static List<Person> GetAllPersons() => DataBaseHelper.GetInstance().GetAllPersons(ParameterHelper.personInfo).ToList();
        /// <summary>
        /// 获得所有打卡信息，以List返回
        /// </summary>
        /// <returns>所有打卡信息</returns>
        public static List<Submit> GetAllSubmits() => DataBaseHelper.GetInstance().GetAllSubmits(ParameterHelper.submitInfo).ToList();
        /// <summary>
        /// 获得某个人员的所有打卡信息，以List返回
        /// </summary>
        /// <param name="strAccount">人员账号</param>
        /// <returns>该人员所有打卡信息</returns>
        public static List<Submit> GetPersonSubmits(string strAccount) => DataBaseHelper.GetInstance().GetPersonSubmits(ParameterHelper.submitInfo, strAccount).ToList();
    }
}
