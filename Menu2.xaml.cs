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
    public partial class Menu2 : ContentPage
    {
        public Menu2()
        {
            InitializeComponent();
        }

        private void Btnmyorder_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new order3());
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