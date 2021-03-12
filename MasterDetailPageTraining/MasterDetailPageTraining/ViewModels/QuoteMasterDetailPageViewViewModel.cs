using MasterDetailPageTraining.Events;
using MasterDetailPageTraining.Messages;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using MasterDetailPageTraining.Models;

namespace MasterDetailPageTraining.ViewModels
{
    public class QuoteMasterDetailPageViewViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        public QuoteMasterDetailPageViewViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService)
        {
            _eventAggregator = eventAggregator;
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            _eventAggregator.GetEvent<AuthorQuoteNavigationEvent>().Subscribe(DoAuthorQuoteNavigation);
        }

        private async void DoAuthorQuoteNavigation(AuthorQuoteNavigationMessage message)
        {
            var parameter = new NavigationParameters($"id={message.AuthorId}");
            await _navigationService.NavigateAsync("BaseNavigationPageView/QuoteDetailPageView", parameter);
        }
    }
}
