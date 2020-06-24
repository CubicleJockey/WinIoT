﻿using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClickMe_OnClick(object sender, RoutedEventArgs e)
        {
            HelloMessage.Text = $"Hello, Windows 10 IoT Core! [{DateTime.Today.ToShortDateString()}]";
        }
    }
}
