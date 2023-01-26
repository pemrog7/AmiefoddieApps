using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Amiefoodiee
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login2 : ContentPage
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void Btnlogin2_Clicked(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Homepage());
        }

    }
}