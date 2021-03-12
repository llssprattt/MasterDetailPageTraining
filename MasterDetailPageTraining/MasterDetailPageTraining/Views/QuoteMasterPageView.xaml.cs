using MasterDetailPageTraining.Models;
using MasterDetailPageTraining.ViewModels;
using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace MasterDetailPageTraining.Views
{
    public partial class QuoteMasterPageView : ContentPage
    {
        public QuoteMasterPageViewViewModel ViewModel
        {
            get { return BindingContext as QuoteMasterPageViewViewModel; }
        }
        public QuoteMasterPageView()
        {
            try
            {
                InitializeComponent();
                lvQuotes.ItemSelected += (o, e) =>
                {
                    if(e.SelectedItem is Quote)
                    {
                        var quote = e.SelectedItem as Quote;
                        ViewModel.ItemClicked.Execute(quote);
                    }
                };
            }
            catch(Exception ex)
            {
                Debug.WriteLine($"{ex.Message} - {ex.StackTrace}");
            }

        }
    }
}
