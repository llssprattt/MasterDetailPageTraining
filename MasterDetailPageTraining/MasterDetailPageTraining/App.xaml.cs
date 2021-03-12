using MasterDetailPageTraining.ViewModels;
using MasterDetailPageTraining.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace MasterDetailPageTraining
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            if(Device.Idiom == TargetIdiom.Desktop || Device.Idiom == TargetIdiom.Tablet)
            {
                await NavigationService.NavigateAsync("QuoteMasterPageView/BaseNavigationPage/QuoteDetailPageView");
            }
            else
            {
                //set up for phone
                await NavigationService.NavigateAsync("BaseNavigationPage/QuoteMasterPageView");
            }
            

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();

            containerRegistry.RegisterForNavigation<QuoteMasterPageView, QuoteMasterPageViewViewModel>();
            containerRegistry.RegisterForNavigation<QuoteDetailPageView, QuoteDetailPageViewViewModel>();
            containerRegistry.RegisterForNavigation<BaseNavigationPage, BaseNavigationPageViewModel>();
            containerRegistry.RegisterForNavigation<QuoteMasterDetailPageView, QuoteMasterDetailPageViewViewModel>();
        }
    }
}
