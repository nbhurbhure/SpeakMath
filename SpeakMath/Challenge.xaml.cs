using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SpeakMath
{
    public partial class Challenge : PhoneApplicationPage
    {
        public Challenge()
        {
            InitializeComponent();
        }
        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ChallengeMain.xaml", UriKind.Relative));
        }
    }
}