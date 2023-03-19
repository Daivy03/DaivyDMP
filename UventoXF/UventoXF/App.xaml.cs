using System.Globalization;
using UventoXF.Interfaces;
using UventoXF.Views;
using Xamarin.Forms;

[assembly: ExportFont("Montserrat-Bold.ttf",Alias="Montserrat-Bold")]
     [assembly: ExportFont("Montserrat-Medium.ttf", Alias = "Montserrat-Medium")]
     [assembly: ExportFont("Montserrat-Regular.ttf", Alias = "Montserrat-Regular")]
     [assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "Montserrat-SemiBold")]
     [assembly: ExportFont("UIFontIcons.ttf", Alias = "FontIcons")]
namespace UventoXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var italianCulture = new CultureInfo("it-IT");
            CultureInfo.DefaultThreadCurrentCulture = italianCulture;
            CultureInfo.DefaultThreadCurrentUICulture = italianCulture;

            MainPage = new NavigationPage(new MainTabbedPage());
            NavigationPage navigationPage = new NavigationPage(new RegisterPage());
            NavigationPage navpage = new NavigationPage(new Profile());
            NavigationPage.SetHasNavigationBar(navigationPage, false);
            

            if (Device.RuntimePlatform == Device.iOS)
                DependencyService.Get<IStatusbarColor>().ChangeStatusbarColor();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
