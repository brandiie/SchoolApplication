using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HighFiveoulus
{
    public partial class MainPage : ContentPage 

    {
        List<string> objEmpCollections = new List<string>();
        public MainPage()
        {
            InitializeComponent();

            
        }
        


        private void LogInonClicked(object sender, EventArgs e) {

          
            string Username = UserName.Text;
            string PassWord = Password.Text;
          

            if (Username == "ruth" && PassWord == "ruth")

                    {
                Navigation.PushModalAsync(new DashBoard());
                DisplayAlert("MESSAGE", "WELCOME", "OK");
                        DisplayResult.Text = "";
                    
                    }

            else
                    {

                        DisplayResult.Text = "Username/Password incorrect ";
               
                    }


        }

        private async void SignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
            UserName.Text = "";
            Password.Text = "";

        }






    }
}
