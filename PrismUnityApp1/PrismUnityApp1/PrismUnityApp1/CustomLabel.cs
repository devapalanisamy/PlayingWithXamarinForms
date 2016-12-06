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
            Style = (Style) Application.Current.Resources["labelGreenStyle"];
        }
    }
}
