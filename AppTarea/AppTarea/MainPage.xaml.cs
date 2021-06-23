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
using System.Drawing;
using Android.Graphics;

namespace AppTarea
{
    public partial class MainPage : ContentPage
    {

           
        public MainPage()
        {
            InitializeComponent();
            enviarInfo.Clicked += EnviarInfo_Clicked;
        }

        private async void EnviarInfo_Clicked(object sender, EventArgs e)
        {
            var camera = new StoreCameraMediaOptions();
            camera.PhotoSize = PhotoSize.Full;
            camera.Name = "img.jpg";
            camera.Directory = "MiApp";
            var foto = await CrossMedia.Current.TakePhotoAsync(camera);
            if (foto!=null) {
                nombre.Text = camera.Name;
                image.Source = ImageSource.FromStream(()=> {
                  
                    return foto.GetStream();
                  

                    
                });
            }
            var compartirfoto = foto.Path;
            await Share.RequestAsync(new ShareFileRequest
            {
                Title = "foto",
                File = new ShareFile(compartirfoto)
            });
           
        }

        private void guardar_Clicked(object sender, EventArgs e)
        {
            
           
            Crud crud = new Crud();
           /*byte[] ImageData = File.ReadAllBytes(ImageSource.FromStream());
           
            var data = new Imagen
            {
                id = 0,
                Nombre = nombre.Text,
                MiImagen = ImageData

            };
            try
            {
                Conexion co = new Conexion();
                co.Conn().CreateTable<Imagen>();
                co.Conn().Insert(data);
                co.Conn().Close();
            }
            catch (SQLiteException ex) {

                Console.WriteLine(ex.ToString());
            }*/

        }
       


    }
   
}
