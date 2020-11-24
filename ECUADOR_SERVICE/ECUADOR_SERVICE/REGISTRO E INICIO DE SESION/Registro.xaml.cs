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
    public partial class Registro : ContentPage
    {
        //
        private SQLiteAsyncConnection _conn;
        public Registro()
        {
            InitializeComponent();
            //
            _conn = DependencyService.Get<Database>().GetConnection();
        }
        private async void Volver_clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void btn_registrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datosRegistro = new Usuario
                {
                    Nombre_Usuario= Nombre_Usuario.Text,
                    Email= Email.Text,
                    Password= Password.Text,
                    Nombre=Nombre.Text,
                    Apellido=Apellido.Text,
                    
                    //Edad= Edad
                   // Pais= Pais



                };
                _conn.InsertAsync(datosRegistro);

                limpiarDatos();
            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Ok");
            }

        }


        void limpiarDatos()
        {
            DisplayAlert("Alerta", "Datos agregados correctamente", "Ok");
            Nombre_Usuario.Text = "";
            Email.Text = "";
            Password.Text = "";
            Nombre.Text = "";
            Apellido.Text = "";
        }
    }
}