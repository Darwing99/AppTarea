using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTarea
{
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();
           
        }



        async void  OnNextPageButtonClicked(object sender, EventArgs e)
        {

            var informacion = new Information {
                Name = nombre.Text,
                Apellido=apellido.Text,
                Edad=edad.Text,
                correo=correo.Text
                   
          
            };

            var page2 = new PageInformation();
            page2.BindingContext = informacion;
             await Navigation.PushAsync(page2);
        }

    }
   
}
