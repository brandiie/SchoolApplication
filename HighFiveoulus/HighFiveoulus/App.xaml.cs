using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HighFiveoulus
{
    public partial class App : Application
    {

        public static MasterDetailPage Menu { get; set; }

        public async static Task NavigateMasterDetail(Page page) {

            App.Menu.IsPresented = false;
            await App.Menu.Detail.Navigation.PushAsync(page);
        }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HighFiveoulus.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#0000ff"),
                BarTextColor = Color.White,
                
            };

            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
