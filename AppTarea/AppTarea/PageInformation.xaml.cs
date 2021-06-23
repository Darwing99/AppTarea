using AppTarea.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
namespace AppTarea
{
 
    public partial class PageInformation : ContentPage
    {
        Crud crud = new Crud();
        public PageInformation()
        {
          
            InitializeComponent();
            mostrarDatos();
            
        } 
        async void volverPage(object sender, EventArgs e)
        {

        await Navigation.PopAsync();
        }
        public async void mostrarDatos()
        {
            try
            {
                var imgLista = await crud.getReadImage();


                if (imgLista != null)
                {
                    lista.ItemsSource = imgLista;
                }

            }
            catch (SQLiteException e)
            {
                await DisplayAlert("Lista", "no hay registros", "ok");

            }


        }
        private void lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }

   
}