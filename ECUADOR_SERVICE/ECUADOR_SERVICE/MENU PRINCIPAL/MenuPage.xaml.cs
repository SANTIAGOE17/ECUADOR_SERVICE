using ECUADOR_SERVICE;
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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e) => await Navigation.PushAsync(new Busqueda_Avion());


        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e) => await Navigation.PushAsync(new Busqueda_Hotel());
       
        
        
    }
}