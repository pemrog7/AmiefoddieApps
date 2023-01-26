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
    public partial class Driver : ContentPage
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void BtnDone_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Driver2());
        }
    }
}