using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;


// Ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(Xam.FormsHelloPCL.iOS.Services.MessageServiceIOS))]

namespace Xam.FormsHelloPCL.iOS.Services
{
    public class MessageServiceIOS : IMessageService
    {
        return "IOS!";
    }
}