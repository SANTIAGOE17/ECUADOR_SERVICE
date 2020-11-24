using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;
using SQLite;
using System.Data;
using Proyecto_Movil.Tablas;


namespace Proyecto_Movil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //

        private  SQLiteAsyncConnection _conn;

        public LoginPage()
        {
            InitializeComponent();
            //
            _conn = DependencyService.Get<Database>().GetConnection();
        }
        private  void IniciarSeccion_clicled(Object sender, EventArgs e)
        {
            try
            {
                var documentsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db3");
                var db = new SQLiteConnection(documentsPath);

                db.CreateTable<Usuario>();
                IEnumerable<Usuario> resultado = SELECT_WHERE(db, usuario.Text, contra.Text);
                if (resultado.Count() > 0)
                {
                      Navigation.PushAsync(new MasterPage());
                }
                else
                {
                     DisplayAlert("Alerta", "Verifique su usuario o Contraseña", "Ok");
                }
            }
            catch (Exception ex)
            {

                 DisplayAlert("Alerta", ex.Message, "Ok");
            }
        }
        public static IEnumerable<Usuario> SELECT_WHERE(SQLiteConnection db, string usuario, string contra)
        {
            return db.Query<Usuario>("SELECT * FROM Usuario WHERE Usuario = ? AND Password = ?", usuario, contra);
        }
        
    }
}