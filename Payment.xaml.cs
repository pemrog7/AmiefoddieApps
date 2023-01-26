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
    public partial class Payment : ContentPage
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Btnok_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderConfirm());
        }

        private void Btnovo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pdua());
        }

        private void BtnMC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ptiga());
        }
    }
}