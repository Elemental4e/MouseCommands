using System.Drawing;
using System.Runtime.InteropServices;



namespace MouseCommands
{
    public static class Mouse
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern bool SetCursorPos(int x, int y);

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_WHEEL = 0x0800;

        public static void Click()
        {
            Point P;
            GetCursorPos(out P);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)P.X, (uint)P.Y, 0, 0);
        }

        public static void Click(int x, int y)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        public static void Click(Point P)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)P.X, (uint)P.Y, 0, 0);
        }

        public static void Click_and_Sleep(int WaitTime)
        {
            Click();
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void Click_and_Sleep(Point P, int WaitTime)
        {
            Click(P);
            System.Threading.Thread.Sleep(WaitTime);
        }
        public static void Click_and_Sleep(int x, int y, int WaitTime)
        {
            Click(x,y);
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void RightClick()
        {
            Point P;
            GetCursorPos(out P);
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)P.X, (uint)P.Y, 0, 0);
        }

        public static void RightClick(int x, int y)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)x, (uint)y, 0, 0);
        }

        public static void RightClick(Point P)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)P.X, (uint)P.Y, 0, 0);
        }

        public static void RightClick_and_Sleep(int WaitTime)
        {
            RightClick();
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void RightClick_and_Sleep(Point P, int WaitTime)
        {
            RightClick(P);
            System.Threading.Thread.Sleep(WaitTime);
        }
        public static void RightClick_and_Sleep(int x, int y, int WaitTime)
        {
            RightClick(x, y);
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static Point GetCursor()
        {
            Point lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;

        }

        public static void SetCursor(int x, int y)
        {
            SetCursorPos(x, y);
        }

        public static void SetCursor(Point P)
        {
            SetCursorPos(P.X, P.Y);
        }

        public static void WheelUp()
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 120, 0);
        }

        public static void WheelUp(int Distance)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)Distance, 0);
        }

        public static void WheelUp_and_Wait(int WaitTime)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 120, 0);
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void WheelUp_and_Wait(int Distance, int WaitTime)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)Distance, 0);
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void WheelDown()
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 0xFFFFFF88, 0);
        }
        public static void MouseWheelDown(int Distance)
        {
            int Minus = -Distance;
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)Minus, 0);
        }

        public static void WheelDown_and_Wait(int WaitTime)
        {
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 0xFFFFFF88, 0);
            System.Threading.Thread.Sleep(WaitTime);
        }

        public static void WheelDown_and_Wait(int Distance, int WaitTime)
        {
            int Minus = -Distance;
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (uint)Minus, 0);
            System.Threading.Thread.Sleep(WaitTime);
        }

    }
}
