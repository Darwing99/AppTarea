using AppTarea.model;
using Xamarin.Forms;

namespace AppTarea
{
    internal class Lista : Imagen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public ImageSource Image { get; set; }
    }
}