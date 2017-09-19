using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

// Ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(Xam.FormsHelloPCL.Droid.Services.MessageServiceDroid))]

namespace Xam.FormsHelloPCL.Droid.Services
{
    public class MessageServiceDroid : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "Android !";
        }
    }
}