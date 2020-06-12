using Scaduino.ArduinoBoard;
using Scaduino.Components;
using Scaduino.Protocols;
using System.ComponentModel;
using System.Diagnostics;

namespace Scaduino
{
    public static class GlobalData
    {
        public static CommunicationChannels SelectedCommunicationChannels { get; set; }
        public static CommunicationDriver SelectedCommunicationDriver { get; set; }
        public static EmailSender EmailSettings { get; set; }

        public static string CodeDirectory { get; set; }

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

        public static Arduino SelectedArduino { get; set; }
    }
}
