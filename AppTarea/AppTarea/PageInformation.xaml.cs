using AppTarea.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using AppTarea.model;
using System.Globalization;

namespace AppTarea
{
 
    public partial class PageInformation : ContentPage
    { Conexion conn = new Conexion();
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

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                byte[] bytes = (byte[])value;
                ImageSource retImageSource = ImageSource.FromStream(() => new MemoryStream(bytes));
                return retImageSource;
            }

            if (parameter != null)
            {
                string fillerIcon = (string)parameter;
                ImageSource retImageSource = ImageSource.FromFile(fillerIcon);
                return retImageSource;
            }

            return null;

        }
            public async void mostrarDatos()
        {
            try
            {

                //var data =  conn.Conn().Query<Imagen>("Select*from Imagen").FirstOrDefault();
                //  MemoryStream ms = new MemoryStream(data.MiImagen);
                // var img = ImageSource.FromStream(() => ms);

                var imgLista = await crud.getReadImage();


                if (imgLista != null)
                {
                    listaItems.ItemsSource = imgLista;
                }
                else
                {
                    await DisplayAlert("Lista", "no hay registros", "ok");
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