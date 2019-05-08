using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace NetworkMonitor
{
    public class Controller
    {

        string framework = Environment.GetEnvironmentVariable("SystemRoot")
            + @"\Microsoft.NET\Framework64\v4.0.30319\";

        NetworkInterface [] NetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

        List<NetworkInterface> activate_interfaces = new List<NetworkInterface>();

        public Controller()
        {
            foreach(NetworkInterface i in NetworkInterfaces)
            {
                Console.WriteLine(i.Name);
            }
        }

        public String getDeskBandPath()
        {
            String path = Path.Combine(Application.StartupPath, "DeskBand.dll");
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("DeskBand.dll not found");
            }
            return path;
        }

           
        public bool isBandRegistered()
        {
            //try
            //{
            //    Assembly band = Assembly.Load("NetworkMonitor");
            //    if (band.GetName().GetPublicKeyToken() != null)
            //    {
            //        return true;
            //    }
            //    return false;
            //}
            //catch (FileNotFoundException)
            //{
            //    return false;
            //}
            using (var classesRootKey = Microsoft.Win32.RegistryKey.OpenBaseKey(
                Microsoft.Win32.RegistryHive.ClassesRoot,
                Microsoft.Win32.RegistryView.Default)
            )
            {
                const string clsid = "{150888C49-7F68-49BB-AA65-A1912AAEA7AF}";
                var clsIdKey = classesRootKey.OpenSubKey(@"Wow6432Node\CLSID\" + clsid) ??
                                classesRootKey.OpenSubKey(@"CLSID\" + clsid);

                if (clsIdKey != null)
                {
                    clsIdKey.Dispose();
                    return true;
                }
                return false;
            }
        }

        public bool registerBand()
        {
            String deskband_path = this.getDeskBandPath();

            Console.WriteLine(deskband_path);

            Process process = new Process();
            process.StartInfo.FileName = this.framework + "regasm.exe";
            process.StartInfo.Arguments = " /nologo /codebase " + deskband_path;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            Console.WriteLine(process.StartInfo.FileName);
            Console.WriteLine(process.StartInfo.Arguments);
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.WaitForExit();
            
            return true;
        }

        public bool unregisterBand()
        {
            String deskband_path = this.getDeskBandPath();

            Process process = new Process();
            process.StartInfo.FileName = this.framework + "regasm.exe";
            process.StartInfo.Arguments = " /unregister " + deskband_path;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            Console.WriteLine(process.StartInfo.FileName);
            Console.WriteLine(process.StartInfo.Arguments);
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.WaitForExit();

            return true;
        }

        private DateTime lasttime = DateTime.Now;
        private long last_received = 0;

        public float getDownloadSpeed()
        {
            if (lasttime == null)
            {
                lasttime = DateTime.Now;
              
                return 0;
            }
            return 0;
        }
    }
}
