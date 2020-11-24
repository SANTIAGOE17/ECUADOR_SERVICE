using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Registro_clicled(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }
        private void Login_clicled(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

    }
}