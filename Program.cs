using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoShortcuts
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Program.LaunchedViaStartup = args != null && args.Any(arg => arg.Equals("startup", StringComparison.CurrentCultureIgnoreCase));

            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }
        public static bool LaunchedViaStartup { get; set; }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
