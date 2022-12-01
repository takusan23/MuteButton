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
            // �^�C�g���o�[�̐ݒ�
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(AppTitleBar);
            // �E�B���h�E�T�C�Y
            WindowTool.SetWindowSize(this, 300, 300);
            // �őO�ʂɂ���
            WindowTool.SetWindowTopMost(this);
        }

        private void MuteButton_Clicked(object sender, RoutedEventArgs e)
        {
            MuteTool.ToggleMute(this);
        }
    }
}
