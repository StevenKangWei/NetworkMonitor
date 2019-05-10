using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using CSDeskBand;
using CSDeskBand.ContextMenu;

namespace NetworkMonitor
{
    [ComVisible(true)]
    [Guid("02F61A17-4E9D-4ED5-B246-305BAEB04206")]
    [CSDeskBandRegistration(Name = "NetworkMonitor")]
    public class Deskband : CSDeskBandWpf
    {
        public Deskband()
        {
            var size = this.getTaskbarSize();

            Options.MinHorizontalSize = new Size(90, size.Height);
            //Options.ContextMenuItems = ContextMenuItems;
        }

        protected override UIElement UIElement => new DeskbandUserControl();

        //private List<DeskBandMenuItem> ContextMenuItems
        //{
        //    get
        //    {
        //        var action = new DeskBandMenuAction("Action - Toggle submenu");
        //        var separator = new DeskBandMenuSeparator();
        //        var submenuAction = new DeskBandMenuAction("Submenu Action - Toggle checkmark");
        //        var submenu = new DeskBandMenu("Submenu")
        //        {
        //            Items = { submenuAction }
        //        };

        //        action.Clicked += (sender, args) => submenu.Enabled = !submenu.Enabled;
        //        submenuAction.Clicked += (sender, args) => submenuAction.Checked = !submenuAction.Checked;

        //        return new List<DeskBandMenuItem>() { action, separator, submenu };
        //    }
        //}

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
