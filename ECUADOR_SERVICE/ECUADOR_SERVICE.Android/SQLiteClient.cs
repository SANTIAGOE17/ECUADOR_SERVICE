using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.CompilerServices;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

//
using SQLite;
using System.IO;
using ECUADOR_SERVICE.Droid;
using Proyecto_Movil;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteClient))]
namespace ECUADOR_SERVICE.Droid
{
    class SQLiteClient : Database {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            // se crea la Base de datos
            var path = Path.Combine(documentsPath, "uisrael.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}