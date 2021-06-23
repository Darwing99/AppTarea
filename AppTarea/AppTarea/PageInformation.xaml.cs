using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTarea
{
 
    public partial class PageInformation : ContentPage
    {
        public PageInformation()
        {
          
            InitializeComponent();

            
        } 
        async void volverPage(object sender, EventArgs e)
        {

        await Navigation.PopAsync();
        }

    }

   
}