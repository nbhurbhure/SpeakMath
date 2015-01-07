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
    public partial class Practice : PhoneApplicationPage
    {
        public Practice()
        {
            InitializeComponent();
        }

        private void btnAddition_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Calculation.xaml", UriKind.Relative));
        }

        private void SpeechPractice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/SpeechPractice.xaml", UriKind.Relative));
        }
 
    }
}