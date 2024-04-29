
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class MainForm : Form
    {
        internal const int MOUSE_EVENTF_LEFT_DOWN = 0x02;
        internal const int MOUSE_EVENTF_LEFT_UP = 0x04;

        internal const int MOUSE_EVENTF_RIGHT_DOWN = 0x08;
        internal const int MOUSE_EVENTF_RIGHT_UP = 0x010;

        public MainForm() => InitializeComponent();

        private void TimerTick(object sender, EventArgs e)
        {
            Point point = new Point();
            GetCursorPos(ref point);
            ClientToScreen(Handle, ref point);
            DoMouseLeftClick(point.x, point.y);
        }

        private void StartStop(object sender, EventArgs e)
        {
            switch (Time.Enabled)
            {
                case true:
                    Time.Enabled = false;
                    StartStopButton.Text = "Старт";
                    StatusLabel.Text = "Остановлен";
                    break;

                case false:
                    Time.Enabled = true;
                    Time.Interval = Convert.ToInt32(NumUpDown.Value);
                    StartStopButton.Text = "Стоп";
                    StatusLabel.Text = "Запущен";
                    break;
            }
        }

        private void DoMouseLeftClick(int x, int y)
        {
            mouse_event(MOUSE_EVENTF_LEFT_DOWN, x, y, 0, 0);
            mouse_event(MOUSE_EVENTF_LEFT_UP, x, y, 0, 0);
        }

        private void DoMouseRightClick(int x, int y)
        {
            mouse_event(MOUSE_EVENTF_RIGHT_DOWN, x, y, 0, 0);
            mouse_event(MOUSE_EVENTF_RIGHT_UP, x, y, 0, 0);
        }

        private void MainFormLoad(object sender, EventArgs e) => NumUpDown.Value = 1000;

        private void AboutProgram(object sender, EventArgs e) => MessageBox.Show("AutoClicker 0.1.0\nMr Nichosik", "AutoClicker", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void SwitchTopMost(object sender, EventArgs e)
        {
            switch (TopMost)
            {
                case true:
                    TopMost = false;
                    TopMostWindowButton.Text = "Закрепить окно";
                    break;
                case false:
                    TopMost = true;
                    TopMostWindowButton.Text = "Открепить окно";
                    break;
            }
        }

        // Импорт
        [StructLayout(LayoutKind.Sequential)]
        internal struct Point
        {
            internal int x, y;
        }

        [DllImport("user32.dll")]
        internal static extern bool ClientToScreen(IntPtr hWnd, ref Point point);

        [DllImport("user32.dll")]
        internal static extern void mouse_event(int dsFlags, int dx, int dy, int cButtons, int dsExtraInfo);

        [DllImport("user32.dll")]
        internal static extern bool GetCursorPos(ref Point lpPoint);
    }
}
