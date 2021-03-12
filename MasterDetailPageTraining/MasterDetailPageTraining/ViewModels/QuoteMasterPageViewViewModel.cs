using MasterDetailPageTraining.Events;
using MasterDetailPageTraining.Messages;
using MasterDetailPageTraining.Models;
using MasterDetailPageTraining.Repository;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace MasterDetailPageTraining.ViewModels
{
    public class QuoteMasterPageViewViewModel : ViewModelBase
    {
        private readonly QuoteRepository _quoteRepository;
        private readonly IEventAggregator _eventAggregator;

        private ObservableCollection<Quote> _randomQuotes;
        public ObservableCollection<Quote> RandomQuotes
        {
            get { return _randomQuotes; }
            set { SetProperty(ref _randomQuotes, value); }
        }

        public DelegateCommand<Quote> ItemClicked { get; set; }

        public QuoteMasterPageViewViewModel(INavigationService navigationService, IEventAggregator eventAggregator, QuoteRepository quoteRepository) : base(navigationService)
        {
            _quoteRepository = quoteRepository;
            _eventAggregator = eventAggregator;
            Title = "Quotes";
            ItemClicked = new DelegateCommand<Quote>(DoQuoteClicked);
            GetRandomQuotes();
            Message = "The Quote Master Page";
        }

        private async void DoQuoteClicked(Quote quote)
        {
            if(Device.Idiom == TargetIdiom.Phone)
            {
                var parameter = new NavigationParameters($"id={quote.AuthorValue.Id}");
                await _navigationService.NavigateAsync("QuoteDetailPageView", parameter);
            }
            else
            {
                var message = new AuthorQuoteNavigationMessage { AuthorId = quote.AuthorValue.Id };
                _eventAggregator.GetEvent<AuthorQuoteNavigationEvent>().Publish(message);
            }
            
        }

        private void GetRandomQuotes()
        {
            RandomQuotes = new ObservableCollection<Quote>(_quoteRepository.GetRandomQuotes());
        }
    }
}
