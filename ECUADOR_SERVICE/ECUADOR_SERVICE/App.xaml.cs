using Proyecto_Movil;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECUADOR_SERVICE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Primera pagina Principal;
            MainPage = new NavigationPage(new Login ())
            { BarBackgroundColor = Color.FromRgb(37, 64, 153), BarTextColor = Color.White };
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
