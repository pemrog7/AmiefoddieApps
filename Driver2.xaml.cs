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
    public partial class Driver2 : ContentPage
    {
        public Driver2()
        {
            InitializeComponent();
        }

        private void Btndone_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Rating());
        }
    }
}