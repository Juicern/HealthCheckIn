using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInHelper
{
    public static class SubmitHelper
    {
        //读取配置
        public static Submit GetSubmitInfoFromConfig()
        {
            return new Submit
            {
                temperature =  ConfigHelper.GetAppConfig(ParameterHelper.temperature),
                health = ConfigHelper.GetAppConfig(ParameterHelper.health),
                location = ConfigHelper.GetAppConfig(ParameterHelper.location)
            };
        }
        //修改配置
        public static void UpdateSubmitInfoToConfig(Submit submit)
        {
            ConfigHelper.UpdateAppConfig(ParameterHelper.temperature, submit.temperature);
            ConfigHelper.UpdateAppConfig(ParameterHelper.health, submit.health);
            ConfigHelper.UpdateAppConfig(ParameterHelper.location, submit.location);
        }
        //提交信息更新到数据库
        public static bool UpdateSubmitInfo(Submit submit) => DataBaseHelper.GetInstance().UpdateSubmitInfo(ParameterHelper.submitInfo, submit);
    }
}
