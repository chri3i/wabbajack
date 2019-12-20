﻿using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using Wabbajack.Common;
using Wabbajack.UserInterventions;

namespace Wabbajack
{
    /// <summary>
    /// Interaction logic for LinksView.xaml
    /// </summary>
    public partial class LinksView : UserControl
    {
        public LinksView()
        {
            InitializeComponent();
        }

        private void GitHub_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://github.com/wabbajack-tools/wabbajack");
        }

        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.gg/wabbajack");
        }

        private void Patreon_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.patreon.com/user?u=11907933");
        }

        private void ConfigureLogins_Click(object sender, RoutedEventArgs e)
        {
            Utils.Log(new ShowLoginManager());
        }
    }
}
