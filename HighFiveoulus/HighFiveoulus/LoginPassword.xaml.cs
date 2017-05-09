using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HighFiveoulus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPassword : ContentPage
    {
        public LoginPassword()
        {
            InitializeComponent();
        }
        private void NextPassword_Clicked(object sender, EventArgs e)
        {

            if (Password.Text == "1234")
            {
                Navigation.PushModalAsync(new DashBoard());

            }

            else
            {

                Password.Text = "Invalid password";

            }
        }
    }
}
