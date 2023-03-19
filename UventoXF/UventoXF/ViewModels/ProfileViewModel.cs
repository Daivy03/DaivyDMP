using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using UventoXF.ViewModel;
using UventoXF.Views;
using Xamarin.Forms;

namespace UventoXF.ViewModels
{
    internal class ProfileViewModel : BaseViewModel
    {
      //  BindingContext = new ProfileViewModel(Navigation);
      public ProfileViewModel(INavigation navigation) {
             Navigation = navigation;
        }
    }
    
}
