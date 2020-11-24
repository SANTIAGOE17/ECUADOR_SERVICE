using System;
using System.Collections.Generic;
using System.Text;
//
using SQLite;

namespace Proyecto_Movil.Tablas
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre_Usuario { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Password { get; set; }

        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
        [MaxLength(50)]
        public byte Edad { get; set; }
        public string Pais { get; set; }
      

    }
}
