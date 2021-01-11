using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCheckIn
{
    public static class SubmitHelper
    {
        public static Dictionary<string, string> GetSubmitInfoFromConfig()
        {
            var dictSubmitInfo = new Dictionary<string, string>();
            dictSubmitInfo.Add("temperature", ConfigHelper.GetAppConfig("temperature"));
            dictSubmitInfo.Add("health", ConfigHelper.GetAppConfig("health"));
            dictSubmitInfo.Add("location", ConfigHelper.GetAppConfig("location"));
            return dictSubmitInfo;
        }
        public static void UpdateSubmitInfoToConfig(Dictionary<string, string> dictSubmitInfo)
        {
            ConfigHelper.UpdateAppConfig("temperature", dictSubmitInfo["temperature"]);
            ConfigHelper.UpdateAppConfig("health", dictSubmitInfo["health"]);
            ConfigHelper.UpdateAppConfig("location", dictSubmitInfo["location"]);
        }
    }
}
