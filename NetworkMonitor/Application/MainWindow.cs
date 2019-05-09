using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitor
{
    public partial class MainWindow : Form
    {
        Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            //this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.traffic_timer.Interval = 1000;
            this.traffic_timer.Start();
            this.controller.registerBand();
            this.controller.showBand();
            
            foreach (NetworkInterface adapter in controller.adapters)
            {
                var name = adapter.Description;
                if (controller.interface_names.Contains(name))
                {
                    interfaceListbox.Items.Add(name, true);
                }
                else
                {
                    interfaceListbox.Items.Add(name);
                }
            }
        }

        private void toggle_button_Click(object sender, EventArgs e)
        {
            controller.toggleBand();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
# if DEBUG
            this.controller.hideBand();
            this.controller.relsaseBand();
#endif
        }

        private void traffic_timer_Tick(object sender, EventArgs e)
        {
            this.download_label.Text = controller.getDownloadSpeedString();
            this.upload_label.Text = controller.getUploadSpeedString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toggleDeskbandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var box = new AboutBox();
            box.ShowDialog();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void interfaceListbox_SelectedValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(interfaceListbox.SelectedItems.Count);
        }

        private void interfaceListbox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = interfaceListbox.Items[e.Index];
            if (e.NewValue == CheckState.Checked)
            {
                controller.interface_names.Add(item.ToString());
            }
            else
            {
                controller.interface_names.Remove(item.ToString());
            }

            controller.selectActiveNetworkInterfaces();
            controller.saveConfiguration();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.toggleBand();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.registerBand();
        }

        private void unregisterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controller.hideBand();
            controller.unregisterBand();
        }
    }
}
