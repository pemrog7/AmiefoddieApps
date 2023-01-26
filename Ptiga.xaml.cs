using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace Amiefoodiee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ptiga : ContentPage
    {
        public Ptiga()
        {
            InitializeComponent();
        }

        

        private void BtnOK_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderConfirm());
        }

        private void Btncash_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Payment());
        }

        private void Btnovo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pdua());
        }
    }
}