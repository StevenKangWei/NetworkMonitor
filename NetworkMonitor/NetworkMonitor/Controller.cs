using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing;

namespace NetworkMonitor
{
    
    public class Controller
    {
  
        public const String DESKBAND_GUID = "07374F07-960A-4E51-BEA7-9DBA619FBBC7";
        public const String TRAY_DESKBAND_GUID = "6D67E846-5B9C-4db8-9CBC-DDE12F4254F1";

        string framework = Environment.GetEnvironmentVariable("SystemRoot")
            + @"\Microsoft.NET\Framework64\v4.0.30319\";

        public NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

        public List<NetworkInterface> interfaces = new List<NetworkInterface>();

        public List<String> interface_names = NetworkManagerConfig.getNetworkInterfaces();

        TrayDeskband traydeskband = null;
        Guid deskbandGuid = new Guid(Controller.DESKBAND_GUID);
        public Controller()
        {
            Win32API.CoFreeUnusedLibraries();
            this.selectActiveNetworkInterfaces();
        }

        ~Controller()
        {
        }
 
        public String getDeskBandPath()
        {
            var current_path = new Uri(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).LocalPath;

            String path = Path.Combine(Path.GetDirectoryName(current_path), "NetworkMonitor.dll");
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("NetworkMonitor.dll not found");
            }
            return path;
        }

        public TrayDeskband getTrayDeskband()
        {
            if (this.traydeskband != null && Marshal.IsComObject(this.traydeskband))
                return this.traydeskband;
            Type deskbandType = System.Type.GetTypeFromCLSID(new Guid("E6442437-6C68-4f52-94DD-2CFED267EFB9"));
            try
            {
                this.traydeskband = (TrayDeskband)Activator.CreateInstance(deskbandType);
                return this.traydeskband;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return null;
        }
        
        public bool registerBand()
        {
            String deskband_path = this.getDeskBandPath();

            //Console.WriteLine(deskband_path);

            Process process = new Process();
            process.StartInfo.FileName = this.framework + "regasm.exe";
            process.StartInfo.Arguments = " /nologo /codebase " + String.Format("\"{0}\"", deskband_path);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            //Console.WriteLine(process.StartInfo.FileName);
            //Console.WriteLine(process.StartInfo.Arguments);
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.WaitForExit();

            return true;
        }

        public bool unregisterBand()
        {
            this.hideBand();

            String deskband_path = this.getDeskBandPath();

            Process process = new Process();
            process.StartInfo.FileName = this.framework + "regasm.exe";
            process.StartInfo.Arguments = " /unregister " + String.Format("\"{0}\"", deskband_path);
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start();
            //Console.WriteLine(process.StartInfo.FileName);
            //Console.WriteLine(process.StartInfo.Arguments);
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            process.WaitForExit();

            return true;
        }

        public bool relsaseBand()
        {
            this.unregisterBand();

            if (this.traydeskband != null && Marshal.IsComObject(this.traydeskband))
                Marshal.ReleaseComObject(this.traydeskband);
            
            Win32API.CoFreeUnusedLibraries();

            var handler = Win32API.FindWindow("Shell_TrayWnd", null);
            //Win32API.PostMessage(handler, );
            if (handler == IntPtr.Zero)
            {
                Console.WriteLine("not find window traywnd");
                return false;
            }
            Console.WriteLine("find window traywnd");
            Win32API.PostMessage(handler, Win32API.WM_TIMER, 24, 0);
            //return true;
            return true;
        }

        public bool showBand()
        {
            if (this.isBandShown())
                return true;
            this.registerBand();
            var traydeskband = this.getTrayDeskband();
            if (traydeskband == null)
                return false;
            traydeskband.DeskBandRegistrationChanged();
            var hr = traydeskband.ShowDeskBand(ref this.deskbandGuid);
            //if (hr != 0)
            //    throw new Exception("Error while trying to show deskband: " + hr);
            traydeskband.DeskBandRegistrationChanged();
            return true;
        }

        public bool hideBand()
        {
            if (!this.isBandShown())
                return true;
            var traydeskband = this.getTrayDeskband();
            if (traydeskband == null)
                return false;
            traydeskband.DeskBandRegistrationChanged();
            var hr = traydeskband.HideDeskBand(ref this.deskbandGuid);
            //if (hr != 0)
            //    throw new Exception("Error while trying to show deskband: " + hr);
            traydeskband.DeskBandRegistrationChanged();
            return true;
        }

        public void toggleBand()
        {
            if (this.isBandShown())
            {
                this.hideBand();
            }
            else
            {
                this.showBand();
            }
        }

        public bool isBandShown()
        {
            var traydeskband = this.getTrayDeskband();
            if (traydeskband == null)
                return false;
            var result = traydeskband.IsDeskBandShown(ref this.deskbandGuid);
            return result == 0;
        }


        public void selectActiveNetworkInterfaces()
        {
            this.interfaces.Clear();
            foreach (NetworkInterface adapter in adapters)
            {
                if (this.interface_names.Contains(adapter.Description))
                {
                    this.interfaces.Add(adapter);
                }
                //Console.WriteLine(adapter.Name);
                //Console.WriteLine(adapter.Description);
                //Console.WriteLine(adapter.Id);
                ////interfaces.Add(adapter);
                ////IPInterfaceProperties properties = adapter.GetIPProperties();
                ////IPv4InterfaceStatistics stat = adapter.GetIPv4Statistics();
                ////stat.
                ////Console.WriteLine(i.Name + i.Speed);
                //Console.WriteLine("--------------------------------");
            }
        }

        public String getSpeedString(double speed)
        {
            int unit = 1;
            while (speed > 1024)
            {
                speed /= 1024;
                unit += 1;
            }
            if (speed > 1000)
                speed = Math.Round(speed, 1);
            else
                speed = Math.Round(speed, 2);
            String unit_string = "";
            switch (unit)
            {
                case 1:
                    unit_string = " B/s";
                    break;
                case 2:
                    unit_string = " K/s";
                    break;
                case 3:
                    unit_string = " M/s";
                    break;
                case 4:
                    unit_string = " G/s";
                    break;
                case 5:
                    unit_string = " T/s";
                    break;
                default:
                    break;
            }

            return Convert.ToString(speed) + unit_string;
        }

        private long last_received_time = 0;
        private long last_received = 0;

        public double getDownloadSpeed()
        {
            long received = 0;
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            foreach (NetworkInterface adapter in interfaces)
            {
                var stat = adapter.GetIPv4Statistics();
                received += stat.BytesReceived;
                //Console.WriteLine(adapter.Description + " " + stat.BytesReceived);
            }
            if (last_received == 0)
            {
                last_received_time = milliseconds;
                last_received = received;
                return 0;
            }

            //Console.WriteLine("received data " + received);
            long period = (milliseconds - last_received_time);
            double data_count = received - this.last_received;
            last_received = received;
            last_received_time = milliseconds;

            if (period <= 0 || data_count <= 0)
            {
                return 0;
            }
            var speed = data_count * 1000 / period;
            return speed;
        }

        public String getDownloadSpeedString()
        {
            var speed = this.getDownloadSpeed();
            return this.getSpeedString(speed);
        }

        private long last_sent_time = 0;
        private long last_sent = 0;

        public double getUploadSpeed()
        {
            long sent = 0;
            long milliseconds = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            foreach (NetworkInterface adapter in interfaces)
            {
                var stat = adapter.GetIPv4Statistics();
                sent += stat.BytesSent;
                //Console.WriteLine(adapter.Description + " " + stat.BytesSent);
            }
            if (last_sent == 0)
            {
                last_sent_time = milliseconds;
                last_sent = sent;
                return 0;
            }

            //Console.WriteLine("sent data " + sent);
            long period = (milliseconds - last_sent_time);
            double data_count = sent - last_sent;
            last_sent = sent;
            last_sent_time = milliseconds;

            if (period <= 0 || data_count <= 0)
            {
                return 0;
            }

            var speed = data_count * 1000 / period;
            return speed;
        }

        public String getUploadSpeedString()
        {
            var speed = this.getUploadSpeed();
            return this.getSpeedString(speed);
        }

        public void saveConfiguration()
        {
            NetworkManagerConfig.setNetworkInterfaces(interface_names);
        }

        public Size getTaskbarSize()
        {
            int width = 0, height = 0;

            if ((Screen.PrimaryScreen.Bounds.Width == Screen.PrimaryScreen.WorkingArea.Width) &&
                (Screen.PrimaryScreen.WorkingArea.Y == 0))
            {
                //taskbar bottom
                width = Screen.PrimaryScreen.WorkingArea.Width;
                height = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            }
            else if ((Screen.PrimaryScreen.Bounds.Height == Screen.PrimaryScreen.WorkingArea.Height) &&
                    (Screen.PrimaryScreen.WorkingArea.X == 0))
            {
                //taskbar right
                width = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width;
                height = Screen.PrimaryScreen.WorkingArea.Height;
            }
            else if ((Screen.PrimaryScreen.Bounds.Width == Screen.PrimaryScreen.WorkingArea.Width) &&
                    (Screen.PrimaryScreen.WorkingArea.Y > 0))
            {
                //taskbar up
                width = Screen.PrimaryScreen.WorkingArea.Width;
                //height = Screen.PrimaryScreen.WorkingArea.Y;
                height = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            }
            else if ((Screen.PrimaryScreen.Bounds.Height == Screen.PrimaryScreen.WorkingArea.Height) &&
                    (Screen.PrimaryScreen.WorkingArea.X > 0))
            {
                //taskbar left
                width = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.WorkingArea.Width;
                height = Screen.PrimaryScreen.WorkingArea.Height;
            }

            return new Size(width, height);
        }
    }
}
