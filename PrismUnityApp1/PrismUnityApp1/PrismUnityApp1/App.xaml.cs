using Newtonsoft.Json;
using Prism.Unity;
using PrismUnityApp1.Views;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace PrismUnityApp1
{
    public partial class App : PrismApplication
    {
        private ThemeColors customThemeColors;
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            customThemeColors = GetThemeColors();
            //Application.Current.Properties["Dev Name"] = "Deva";
            //Application.Current.SavePropertiesAsync();

            var labelRedStyle = new Style(typeof(Label))
            {
                Setters = {
                //new Setter { Property = Label.TextColorProperty, Value = Color.Red  }
                new Setter { Property = Label.TextColorProperty, Value = Color.FromHex(customThemeColors.custombackgroundColor)  }
            }
            };
            var labelGreenStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.FromHex(customThemeColors.customtextColor) }
            }
            };
            var labelBlueStyle = new Style(typeof(Label))
            {
                Setters = {
                new Setter { Property = Label.TextColorProperty, Value = Color.FromHex(customThemeColors.customnavigationBarColor) }
            }
            };

            Resources = new ResourceDictionary();
            Resources.Add("labelRedStyle", labelRedStyle);
            Resources.Add("labelGreenStyle", labelGreenStyle);
            Resources.Add("labelBlueStyle", labelBlueStyle);

            NavigationService.NavigateAsync("RootPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PrismNavigationPage1>();
        }

        private ThemeColors GetThemeColors()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("PrismUnityApp1.ThemeColors.json");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            
            var themeColorsList = JsonConvert.DeserializeObject<List<ThemeColors>>(text);
            ThemeColors themeColors = themeColorsList[0];
            return themeColors;
        } 
    }

    public class RootPage : NavigationPage
    {
        public RootPage(Page rootPage) : base(rootPage)
        {
            BarBackgroundColor = Color.FromHex("#ff5300");
        }
    }
}
