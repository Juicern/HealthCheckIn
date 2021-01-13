using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CheckInHelper
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
        /// <param name="strKey">新的key</param>
        /// <param name="strValue">新的value</param>
        public static void UpdateAppConfig(string strKey, string strValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            if (config.AppSettings.Settings.AllKeys.Any(x => x == strKey))
            {
                config.AppSettings.Settings.Remove(strKey);
            }
            config.AppSettings.Settings.Add(strKey, strValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
