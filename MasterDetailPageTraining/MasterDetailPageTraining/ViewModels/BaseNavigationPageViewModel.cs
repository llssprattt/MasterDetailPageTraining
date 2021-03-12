using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDetailPageTraining.ViewModels
{
    public class BaseNavigationPageViewModel : ViewModelBase
    {
        public BaseNavigationPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Base Navigation Page";
        }
    }
}
