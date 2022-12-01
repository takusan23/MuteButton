// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.UI.Xaml;
using MuteButton.Tool;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MuteButton
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // タイトルバーの設定
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
            // ウィンドウサイズ
            WindowTool.SetWindowSize(this, 300, 300);
            // 最前面にする
            WindowTool.SetWindowTopMost(this);
        }

        private void MuteButton_Clicked(object sender, RoutedEventArgs e)
        {
            MuteTool.ToggleMute(this);
        }
    }
}
