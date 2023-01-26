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
    public partial class Pdua : ContentPage
    {
        public Pdua()
        {
            InitializeComponent();
        }

        private void Btnmc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ptiga());
        }

        private void BtnOk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderConfirm ());
        }

        private void BtnC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Payment());
        }
    }
}