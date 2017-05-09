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
    public partial class LoginUsername : ContentPage
    {

        public LoginUsername()
        {
            InitializeComponent();
            
        }
        public async void NextUsername_Clicked(object sender, EventArgs e)
        {
            string userNname = Username.Text;

            if (userNname == "student")
            {

                await Navigation.PushModalAsync(new LoginPassword());

            }
            else
            {

                Invalid.Text = "Invalid username";

            }
        }
    }
}
