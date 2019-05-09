using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.traffic_timer.Interval = 1000;
            this.traffic_timer.Start();
            this.controller.registerBand();
            this.controller.showBand();
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            if(this.controller.isBandShown())
            {
                this.controller.hideBand();
            }
            else
            {
                this.controller.showBand();
            }
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
    }
}
