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
    public partial class MyProfile : ContentPage
    {
        public MyProfile()
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
        private void Btnhistory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderHistory());
        }

        private void Btnpanah_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderHistory());
        }

        private void BtnPanah_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Language());
        }

        private void BtnPk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyAddress());
        }
    }
}