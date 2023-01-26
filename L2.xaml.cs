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
    public partial class L2 : ContentPage
    {
        public L2()
        {
            InitializeComponent();
        }

        private void BtnCheck_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProfile());
        }
    }
}