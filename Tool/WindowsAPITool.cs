using System.Runtime.InteropServices;
using System;

namespace MuteButton.Tool
{
    class WindowsAPITool
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int uFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public const int SWP_NOSIZE = 0x0001;

        public const int SWP_NOMOVE = 0x0002;

        public const int HWND_TOPMOST = -1;

        public const int APPCOMMAND_VOLUME_MUTE = 0x80000;

        public const int WM_APPCOMMAND = 0x319;
    }
}
