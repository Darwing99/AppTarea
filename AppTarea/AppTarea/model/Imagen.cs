using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace AppTarea.model
{
    class Imagen
    {


        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        [MaxLength(200)]
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public byte[] MiImagen { get; set; }



    }
}
