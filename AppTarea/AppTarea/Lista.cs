using AppTarea.model;
using Xamarin.Forms;

namespace AppTarea
{
    internal class Lista : Imagen
    {
        public int idimage { get; set; }
        public string nombre { get; set; }
        public byte[] image { get; set; }
    }
}