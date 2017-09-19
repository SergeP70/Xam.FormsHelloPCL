﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam.FormsHelloPCL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var message = DependencyService.Get<IMessageService>();
            lblWelcome.Text = "Hello, I am " + message.GetWelcomeMessage();

        }
    }
}
