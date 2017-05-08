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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            Gender.Items.Add("Female");
            Gender.Items.Add("Male");

        }

        private void SubmitonClicked(object sender, EventArgs e) {

            DisplayAlert("SIGN UP","Registered Success","Ok");

        }

        
    }
}
