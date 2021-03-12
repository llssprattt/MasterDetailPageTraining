using Prism.Navigation;
using Xamarin.Forms;

namespace MasterDetailPageTraining.Views
{
    public partial class BaseNavigationPage : NavigationPage, INavigationPageOptions
    {
        public BaseNavigationPage()
        {
            InitializeComponent();
        }

        public bool ClearNavigationStackOnNavigation 
        { 
            get { return true; } 
        }
    }
}
