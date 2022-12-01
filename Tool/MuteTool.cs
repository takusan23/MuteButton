using Microsoft.UI.Xaml;
using System;

namespace MuteButton.Tool
{
    public class MuteTool
    {

        /// <summary>
        /// ミュートボタンを押す
        /// </summary>
        public static void ToggleMute(Window window)
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(window);
            WindowsAPITool.SendMessageW(hWnd, WindowsAPITool.WM_APPCOMMAND, hWnd, (IntPtr)WindowsAPITool.APPCOMMAND_VOLUME_MUTE);
        }
    }
}
