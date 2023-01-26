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
    public partial class order2 : ContentPage
    {
        public order2()
        {
            InitializeComponent();
        }

        private void Btnorder2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
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