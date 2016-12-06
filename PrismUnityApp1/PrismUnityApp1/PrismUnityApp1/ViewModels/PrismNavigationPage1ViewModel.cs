using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace PrismUnityApp1.ViewModels
{
    public class PrismNavigationPage1ViewModel : BindableBase,INavigationAware
    {
        public PrismNavigationPage1ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        private DelegateCommand<ItemTappedEventArgs> _goToDetailPage;
        private INavigationService _navigationService;

        public DelegateCommand<ItemTappedEventArgs> GoToDetailPage
        {
            get
            {
                if (_goToDetailPage == null)
                {
                    _goToDetailPage = new DelegateCommand<ItemTappedEventArgs>(async selected =>
                    {
                        NavigationParameters param = new NavigationParameters();
                        await _navigationService.NavigateAsync("WebViewPage");
                    });
                }
                return _goToDetailPage;
            }
        }
    }
}
