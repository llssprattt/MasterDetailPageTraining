using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MasterDetailPageTraining.Repository;
using MasterDetailPageTraining.Models;
using Xamarin.Forms;

namespace MasterDetailPageTraining.ViewModels
{
    public class QuoteDetailPageViewViewModel : ViewModelBase
    {
        private readonly QuoteRepository _quoteRepository;

        private Author _selectedAuthor;
        public Author SelectedAuthor
        {
            get { return _selectedAuthor; }
            set { SetProperty(ref _selectedAuthor, value); }
        }

        private ObservableCollection<Quote> _authorQuotes;
        public ObservableCollection<Quote> AuthorQuotes
        {
            get { return _authorQuotes; }
            set { SetProperty(ref _authorQuotes, value); }
        }


        public QuoteDetailPageViewViewModel(INavigationService navigationService, QuoteRepository quoteRepository) : base(navigationService)
        {
            _quoteRepository = quoteRepository;
            Title = "Author Quote";
        }

        public override void Initialize(INavigationParameters parameters)
        {
            if (parameters != null && parameters.ContainsKey("id"))
            {
                int id = -1;
                var didParse = int.TryParse(parameters["id"].ToString(), out id);
                if (didParse && id > -1)
                {
                    LoadAuthorQuotes(id);
                }
            }
        }

        private void LoadAuthorQuotes(int authorId)
        {
            SelectedAuthor = _quoteRepository.GetAuthorById(authorId);
            if(SelectedAuthor != null)
            {
                //if(Device.Idiom == TargetIdiom.Tablet || Device.Idiom == TargetIdiom.Desktop)
                //{
                    Title = $"{SelectedAuthor.FullName} Quotes";
                //}
                AuthorQuotes = new ObservableCollection<Quote>(_quoteRepository.GetQuotesByAuthor(authorId));
            }
        }
    }
}
