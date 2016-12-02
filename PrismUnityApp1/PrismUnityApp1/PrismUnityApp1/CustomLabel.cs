using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrismUnityApp1
{
    class CustomLabel: Label
    {
        public CustomLabel()
        {
            TextColor = Color.Red;
            FontFamily = Device.OnPlatform(
                                             "Myriad Pro",
                                             "Lobster-Regular.ttf#Lobster-Regular", // Android
                                             null
                                           );
        }
    }
}
