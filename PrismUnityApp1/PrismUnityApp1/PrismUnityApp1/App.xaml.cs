using Prism.Unity;
using PrismUnityApp1.Views;
using Xamarin.Forms;

namespace PrismUnityApp1
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("RootPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<PrismNavigationPage1>();
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
