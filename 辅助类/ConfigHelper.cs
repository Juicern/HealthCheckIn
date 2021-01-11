using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HealthCheckIn
{
    public class ConfigHelper
    {
        /// <summary>
        /// 读取strKey的配置缓存信息
        /// </summary>
        /// <param name="strKey">要查找的key</param>
        /// <returns>查找的值</returns>
        public static string GetAppConfig(string strKey)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == strKey)
                {
                    return config.AppSettings.Settings[strKey].Value.ToString();
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// 更新配置信息
        /// </summary>
        /// <param name="newKey">新的key</param>
        /// <param name="newValue">新的value</param>
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            if (config.AppSettings.Settings.AllKeys.Any(x => x == newKey))
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
