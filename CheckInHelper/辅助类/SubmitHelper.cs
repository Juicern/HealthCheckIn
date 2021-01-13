using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class SubmitHelper
    {
        /// <summary>
        /// 读取配置中的打卡信息
        /// </summary>
        /// <returns>打卡信息</returns>
        public static Submit GetSubmitInfoFromConfig()
        {
            return new Submit
            {
                temperature =  ConfigHelper.GetAppConfig(ParameterHelper.temperature),
                health = ConfigHelper.GetAppConfig(ParameterHelper.health),
                location = ConfigHelper.GetAppConfig(ParameterHelper.location)
            };
        }
        /// <summary>
        /// 修改配置中的打卡信息
        /// </summary>
        /// <param name="submit">打卡信息</param>
        public static void UpdateSubmitInfoToConfig(Submit submit)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.temperature, submit.temperature);
            ConfigHelper.UpdateAppConfig(ParameterHelper.health, submit.health);
            ConfigHelper.UpdateAppConfig(ParameterHelper.location, submit.location);
        }
        /// <summary>
        /// 更新打卡信息到数据库
        /// </summary>
        /// <param name="submit">打卡信息</param>
        /// <returns>是否更新成功</returns>
        public static bool UpdateSubmitInfo(Submit submit) => DataBaseHelper.GetInstance().UpdateSubmitInfo(ParameterHelper.submitInfo, submit);
    }
}
