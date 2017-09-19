using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Ensures the PCL has access to this class. Must be defined outside of the namespace
[assembly: Xamarin.Forms.Dependency(typeof(Xam.FormsHelloPCL.UWP.Services.MessageServiceUWP))]

namespace Xam.FormsHelloPCL.UWP.Services
{
    public class MessageServiceUWP : IMessageService
    {
        public string GetWelcomeMessage()
        {
            return "UWP !";
        }
    }
}
