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

            var menu = new List<MenuList>
            {
                new MenuList { Menu ="About", Options="About" },
                new MenuList { Menu ="Mission", Options="Mission"},
                new MenuList { Menu ="Vision", Options="Vision"},
                new MenuList { Menu ="Sign Out", Options="SignOut" }

           };

            MenuListView.ItemsSource = menu;

        }

        private async void MenuListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var MenuClicked = e.Item as MenuList;

            await DisplayAlert("Message", "Menu:" + MenuClicked, "Ok");


        }


    }
    }

