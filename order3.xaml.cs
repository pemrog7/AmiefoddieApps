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
    public partial class order3 : ContentPage
    {
        public order3()
        {
            InitializeComponent();
        }

        private void BtnCheckout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Payment());
        }

        private void Btnhistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderHistory());
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }

        private void Btnuser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProfile());
        }
    }
}