using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//
using System.Collections.ObjectModel;
using System.IO;
using SQLite;
using System.Data;
using Proyecto_Movil.Tablas;


namespace Proyecto_Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        //
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<Usuario> _tablausuario;
        public MasterPage()
        {
            InitializeComponent();
            _conn = DependencyService.Get<Database>().GetConnection();

            Detail = new NavigationPage(new MenuPage());
            IsPresented = false;
        }

        protected async override void OnAppearing()
        {
            var ResulRegistro = await _conn.Table<Usuario>().ToListAsync();
            _tablausuario = new ObservableCollection<Usuario>(ResulRegistro);
            ListaUsuario.ItemsSource = _tablausuario;
            base.OnAppearing();
        }
           

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MenuPage());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new MisViajesPage());
            IsPresented = false;
        }

        private void Cuenta_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Micuentapage());
            IsPresented = false;
        }
    }
}