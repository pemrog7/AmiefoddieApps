using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amiefoodiee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderHistory : ContentPage
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }
        private void Btncart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new order2());
        }
        private void Btnuser_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProfile());
        }

        private void Btnhapus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Delete());
        }
    }
}