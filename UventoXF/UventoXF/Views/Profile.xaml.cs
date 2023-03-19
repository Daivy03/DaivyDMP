using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UventoXF.Interfaces;
using UventoXF.ViewModels;

namespace UventoXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel(Navigation);
        }
        private void OnUserManualClicked(object sender, EventArgs e)
        {
            var pdfViewer = DependencyService.Get<IPdfViewer>();
            pdfViewer.ShowDocument("manuale-utente.pdf");
        }

    }
}