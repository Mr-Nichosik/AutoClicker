
global using System;
global using System.Windows.Forms;
global using System.Threading.Tasks;

namespace AutoClicker
{
    internal static class Program
    {
        internal static MainForm MainUi = new();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}