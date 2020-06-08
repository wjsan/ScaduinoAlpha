using Scaduino.Properties;
using Scaduino.Protocols;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Scaduino
{
    public static class GlobalData
    {
        public static CommunicationChannels SelectedCommunicationChannels { get; set; }
        public static CommunicationDriver SelectedCommunicationDriver { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                bool isInDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

                if (!isInDesignMode)
                {
                    using (var process = Process.GetCurrentProcess())
                    {
                        return process.ProcessName.ToLowerInvariant().Contains("devenv");
                    }
                }

                return isInDesignMode;
            }
        }

    }
}
