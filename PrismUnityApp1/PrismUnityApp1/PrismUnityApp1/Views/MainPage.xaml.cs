using Prism.Commands;
using Xamarin.Forms;

namespace PrismUnityApp1.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            /***
            var labelRedStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Red  }
            }
            };
            var labelGreenStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Green }
            }
            };
            var labelBlueStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.Blue }
            }
            };

            Resources = new ResourceDictionary();
            Resources.Add("labelRedStyle", labelRedStyle);
            Resources.Add("labelGreenStyle", labelGreenStyle);
            Resources.Add("labelBlueStyle", labelBlueStyle);
            ***/
            //Resources = Application.Current.Resources;

            InitializeComponent();
        }
}
}
