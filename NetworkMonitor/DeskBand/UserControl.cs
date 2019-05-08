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
        CSDeskBand.CSDeskBandWin deskband = null;
        Controller controller = null;
        public UserControl(CSDeskBand.CSDeskBandWin deskband)
        {
            InitializeComponent();
            this.deskband = deskband;
            this.controller = new Controller();
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
