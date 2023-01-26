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
    public partial class Rating : ContentPage
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void Btnrc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rating2());
        }

        private void Btnc_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }
    }
}