﻿using System;
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
    public partial class ChallengeMain : PhoneApplicationPage
    {
        public ChallengeMain()
        {
            InitializeComponent();
        }

        private void ContentPanel_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/score.xaml", UriKind.Relative));
        }
    }
}