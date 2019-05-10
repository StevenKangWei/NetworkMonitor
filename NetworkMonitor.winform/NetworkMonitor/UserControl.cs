using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitor
{
    public partial class UserControl: System.Windows.Forms.UserControl
    {
        Controller controller = null;
        Deskband deskband = null;
        public UserControl(Deskband w)
        {
            InitializeComponent();
            deskband = w;
        }

        protected override bool ProcessKeyPreview(ref Message m)
        {
            if ((Keys)m.WParam == Keys.Tab)
            {
                var selected = SelectNextControl(ActiveControl, true, true, true, true);
                return true;
            }

            return base.ProcessKeyPreview(ref m);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.hideBand();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.upload_label.Text = controller.getUploadSpeedString();
            this.download_label.Text = controller.getDownloadSpeedString();
            //var width = Math.Max(this.upload_label.Width, this.download_label.Width);
            //this.Width = width;
        }

        private void unregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.hideBand();
            controller.unregisterBand();
        }

        private void UserControl_Load(object sender, EventArgs e)
        {
            this.controller = new Controller();
            this.timer.Interval = 1000;
            this.timer.Start();
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
