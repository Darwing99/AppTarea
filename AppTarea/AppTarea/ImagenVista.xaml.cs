using AppTarea.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagenVista : ContentPage
    {
        Conexion conn = new Conexion();
        Crud crud = new Crud();

        public ImagenVista()
        {
            InitializeComponent();
        }

        private async void borrar_Clicked(object sender, EventArgs e)
        {
            var image = await crud.getImageId(Convert.ToInt32(id.Text));


            bool answer = await DisplayAlert("Delete", "Desea borrar imagen ubicacion indicada?", "si", "No");
            if (answer)
            {
                if (image != null)
                {
                    await crud.Delete(image);
                    await DisplayAlert("Delete", "Imagen Eliminada", "ok");
                    await Navigation.PopAsync();
                   
                }
                else
                {
                    await DisplayAlert("Warning", "no se ha podido borrar imagen", "Ok");
                }
            }
        }
    }
}