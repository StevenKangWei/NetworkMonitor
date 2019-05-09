using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace NetworkMonitor
{
    public static class NetworkManagerConfig
    {
        public const String NETWORK_INTERFACES_KEY = "NETWORK_INTERFACES_KEY";

        public static Configuration getConfiguration()
        {
            var current_path = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;
            String filepath = Path.Combine(Path.GetDirectoryName(current_path), "NetworkMonitor.exe");
            Configuration config = ConfigurationManager.OpenExeConfiguration(filepath);
            return config;
        }

        public static string getAppConfig(string key)
        {
            var config = getConfiguration();

            foreach (string var in config.AppSettings.Settings.AllKeys)
            {
                if (var == key)
                {
                    return config.AppSettings.Settings[key].Value.ToString();
                }
            }
            return null;
        }

        public static void setAppConfig(string key, string value)
        {
            Configuration config = getConfiguration();
            bool exist = false;
            foreach (string var in config.AppSettings.Settings.AllKeys)
            {
                if (var == key)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(key);
            }
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static List<String> getNetworkInterfaces()
        {
            List<String> list = new List<string>();

            String interfaces = getAppConfig(NETWORK_INTERFACES_KEY);
            if (interfaces == null)
                return list;
           
            foreach(String var in interfaces.Split('\n'))
            {
                if (var.Trim().Length > 0)
                    list.Add(var.Trim());
            }
            return list;
        }

        public static void setNetworkInterfaces(List<string> interfaces)
        {
            String value = "";
            foreach(String name in interfaces)
            {
                value += name + "\n";
            }
            setAppConfig(NETWORK_INTERFACES_KEY, value);
        }

    }
}
