using Microsoft.UI.Xaml;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;

namespace MuteButton.Tool
{
    public class WindowTool
    {

        /// <summary>
        /// AppWindow を返す
        /// </summary>
        /// <param name="window"></param>
        public static AppWindow GetAppWindow(Window window)
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            var myWndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        /// <summary>
        /// ウィンドウサイズを変更する
        /// </summary>
        /// <param name="window"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        public static void SetWindowSize(Window window, int height, int width)
        {
            GetAppWindow(window).Resize(new SizeInt32(width, height));
        }

        /// <summary>
        /// ウィンドウを最前面にする
        /// </summary>
        public static void SetWindowTopMost(Window window)
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WindowsAPITool.SetWindowPos(hWnd, WindowsAPITool.HWND_TOPMOST, 0, 0, 0, 0, WindowsAPITool.SWP_NOMOVE | WindowsAPITool.SWP_NOSIZE);
        }
    }
}
