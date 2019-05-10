using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetworkMonitor
{
    [ComImport, Guid(Controller.TRAY_DESKBAND_GUID),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface TrayDeskband
    {
        [PreserveSig]
        int ShowDeskBand([In, MarshalAs(UnmanagedType.Struct)] ref Guid clsid);

        [PreserveSig]
        int HideDeskBand([In, MarshalAs(UnmanagedType.Struct)] ref Guid clsid);
 
        [PreserveSig]
        int IsDeskBandShown([In, MarshalAs(UnmanagedType.Struct)] ref Guid clsid);

        [PreserveSig]
        int DeskBandRegistrationChanged();
    }
}
