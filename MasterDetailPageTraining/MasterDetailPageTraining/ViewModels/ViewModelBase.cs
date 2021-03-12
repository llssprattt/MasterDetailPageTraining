using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailPageTraining.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize , INavigationAware, IDestructible
    {
        protected readonly INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }


        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }

        private async void Navigate(string name)
        {
            await _navigationService.NavigateAsync(name);
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Initialize(INavigationParameters parameters)
        {
            
        }

        public virtual void Destroy()
        {

        }

    }
}
