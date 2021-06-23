using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using SQLite;
namespace AppTarea.model
{
    class Imagen
    {


        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        public byte[] MiImagen { get; set; }


    }
}
