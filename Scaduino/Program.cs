using Scaduino.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Scaduino
{
    static class Program
    {
        static public SerialArduino Arduino { get; set; }
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
