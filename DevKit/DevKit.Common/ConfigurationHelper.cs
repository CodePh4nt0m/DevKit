using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevKit.Common
{
    public class ConfigurationHelper
    {
        public Configuration config = null;

        public ConfigurationHelper()
        {
            config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        }

        public void AddConfiguration(string key, string value)
        {
            try
            {
                var val = config.AppSettings.Settings[key];
                if (val == null)
                {
                    config.AppSettings.Settings.Add(key, value);
                }
                else
                {
                    config.AppSettings.Settings[key].Value = value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GetConfigurationValue(string key)
        {
            try
            {
                var val = config.AppSettings.Settings[key];
                if (val != null)
                    return val.Value.ToString();
                else
                    return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
