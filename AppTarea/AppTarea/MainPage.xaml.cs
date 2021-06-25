using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Media.Abstractions;
using Plugin.Media;
using SQLite;
using Xamarin.Essentials;
using System.Reflection.Metadata;
using AppTarea.clases;
using AppTarea.model;
using System.IO;



namespace AppTarea
{
    public partial class MainPage : ContentPage
    {
        byte[] imageArray = null;

        public MainPage()
        {
            InitializeComponent();
            enviarInfo.Clicked += EnviarInfo_Clicked;
         
        }

    
        private async void EnviarInfo_Clicked(object sender, EventArgs e)
        {
            var camera = new StoreCameraMediaOptions();
            camera.PhotoSize = PhotoSize.Medium;
        
            camera.Name = "Img";
            camera.Directory = "MiApp";
            
            var foto = await CrossMedia.Current.TakePhotoAsync(camera);
           
          
            if (foto!=null) {
                nombre.Text = camera.Name;
                image.Source = ImageSource.FromStream(()=> {
                  
                    return foto.GetStream();
                  

                    
                });
                using (MemoryStream memory = new MemoryStream())
                {

                    Stream stream = foto.GetStream();
                    stream.CopyTo(memory);
                    imageArray = memory.ToArray();
                }
            }
            var compartirfoto = foto.Path;
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "foto",
                File = new ShareFile(compartirfoto)
            });
         

        }



        private async void guardar_Clicked(object sender, EventArgs e)
        {
            
            var data = new Imagen
            {
                id = 0,
                Nombre = nombre.Text,
                MiImagen = imageArray

            };
           

            try
            {
                Conexion co = new Conexion();
                co.Conn().CreateTable<Imagen>();
                co.Conn().Insert(data);
                co.Conn().Close();
                await DisplayAlert("Save Fille","Datos Guardados ","ok");
                await Navigation.PushAsync(new PageInformation());
            }
            catch (SQLiteException ex) {

                Console.WriteLine(ex.ToString());
            }

        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageInformation());
        }

      
    }
   
}
