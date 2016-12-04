using Prism.Commands;
using System.Diagnostics;
using Xamarin.Forms;

namespace PrismUnityApp1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //System.Diagnostics.Debug.WriteLine("Dev Name:" + Application.Current.Properties["Dev Name"] as string);
            Debug.WriteLine("****************************"+Application.Current.Properties["Dev Name"] as string);
        }
}
}
