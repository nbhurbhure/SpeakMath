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
    public partial class SpeakMathList : PhoneApplicationPage
    {
        public SpeakMathList()
        {
            InitializeComponent();
        }

        private void btnChallenge_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Challenge.xaml", UriKind.Relative));
        }

        private void btnPractice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Challenge.xaml", UriKind.Relative));
        }

        private void btnHighscore_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HighScore.xaml", UriKind.Relative));
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative));
        }

        private void btnInformation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Information.xaml", UriKind.Relative));
        }

    }
}