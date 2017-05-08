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

        public MainPage()
        {
            InitializeComponent();
        }
        

        private void LogInonClicked(object sender, EventArgs e) {

          
            string Username = UserName.Text;
            string PassWord = Password.Text;
          

            if (Username == "ruth" && PassWord == "ruth")

                {
                    DisplayAlert("MESSAGE", "WELCOME", "OK");
                    DisplayResult.Text = "";
                }

            else {

                DisplayResult.Text = "Username/Password incorrect ";
               
            }



        }

      
    }
}
