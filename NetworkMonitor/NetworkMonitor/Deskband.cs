﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitor
{
    [ComVisible(true)]
    [Guid(Controller.DESKBAND_GUID)]
    [CSDeskBand.CSDeskBandRegistration(Name = "NetworkMonitor", ShowDeskBand = false)]
    public class Deskband : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;

        public Deskband()
        {
            _control = new UserControl(this);
            Options.MinHorizontalSize = new Size(90, 50);
            UserControl control = (UserControl)_control;
        }

        protected override Control Control => _control;
    }
}
