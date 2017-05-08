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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();

            ButtonAbout.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new AboutUs());
            };

            ButtonMission.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new Mission());
            };

            ButtonVision.Clicked += async (sender, e) =>
            {
                await App.NavigateMasterDetail(new Vision());
            };


        }
    }
}
