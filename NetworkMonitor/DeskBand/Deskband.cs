using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWinforms
{
    [ComVisible(true)]
    [Guid("50888C49-7F68-49BB-AA65-A1912AAEA7AF")]
    [CSDeskBand.CSDeskBandRegistration(Name = "NetworkMonitor", ShowDeskBand = false)]
    public class Deskband : CSDeskBand.CSDeskBandWin
    {
        private static Control _control;

        public Deskband()
        {
            Options.MinHorizontalSize = new Size(100, 30);
            _control = new UserControl(this);
        }

        protected override Control Control => _control;
    }
}
