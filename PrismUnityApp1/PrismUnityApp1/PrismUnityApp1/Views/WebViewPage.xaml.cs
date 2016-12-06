using System;
using Xamarin.Forms;

namespace PrismUnityApp1.Views
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        void backButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
            else
            {
                this.Navigation.PopAsync();
            }
        }

        void forwardButtonClicked(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }
    }
}
