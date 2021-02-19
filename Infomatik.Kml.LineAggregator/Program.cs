using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Infomatik.Kml.LineAggregator
{
  static class Program
  {

    [DllImport("user32.dll", SetLastError = true)]
    static extern bool SetProcessDPIAware();


    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      SetProcessDPIAware();
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }
  }
}
