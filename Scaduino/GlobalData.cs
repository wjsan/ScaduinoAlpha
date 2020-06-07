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

        public static void CreateResources()
        {
            var dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Scaduino\\Resources";

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            Extract(Resources.analog, dir, "analog.png");
            Extract(Resources.antenna, dir, "antenna.png");
            Extract(Resources.balance, dir, "balance.png");
            Extract(Resources.error, dir, "error.png");
            Extract(Resources.furnace, dir, "furnace.png");
            Extract(Resources.indicator, dir, "indicator.png");
            Extract(Resources.ledBlue, dir, "ledBlue.png");
            Extract(Resources.ledGreen, dir, "ledGreen.png");
            Extract(Resources.ledGrey, dir, "ledGrey.png");
            Extract(Resources.ledRed, dir, "ledRed.png");
            Extract(Resources.motorFail, dir, "motorFail.png");
            Extract(Resources.motorOff, dir, "motorOff.png");
            Extract(Resources.motorOn, dir, "motorOn.png");
            Extract(Resources.ok, dir, "ok.png");
            Extract(Resources.petroleumPump, dir, "petroleumPump.png");
            Extract(Resources.pressure, dir, "pressure.png");
            Extract(Resources.roboticArm, dir, "roboticArm.png");
            Extract(Resources.satellite, dir, "satellite.png");
            Extract(Resources.shutdown, dir, "shutdown.png");
            Extract(Resources.speed, dir, "speed.png");
            Extract(Resources.tank, dir, "tank.png");
            Extract(Resources.temperature, dir, "temperature.png");
            Extract(Resources.tower, dir, "tower.png");
            Extract(Resources.turnOff, dir, "turnOff.png");
            Extract(Resources.turnOn, dir, "turnOn.png");

        }

        public static void Extract(Bitmap bitmap, string destiny, string name)
        {
            string filePath = destiny + "\\" + name;

            if (!File.Exists(filePath))
            {
                bitmap.Save(filePath, ImageFormat.Png);
            }
        }

    }
}
