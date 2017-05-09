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
                new MenuList { Menu ="My Profile",},
                new MenuList { Menu ="My Subject",},
                new MenuList { Menu ="Events",},
                new MenuList { Menu ="Settings"},
                new MenuList { Menu ="Sign Out"}

           };

            MenuListView.ItemsSource = menu;

        }

        private async void MenuListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            var MenuClicked = e.Item as MenuList;
            if (MenuClicked.Menu == "My Profile")
            {
                await Navigation.PushModalAsync(new MyProfile());
            }
            else if (MenuClicked.Menu == "Events") {
                await Navigation.PushModalAsync(new MySubject());
            }
            else if (MenuClicked.Menu == "Events") {
                await Navigation.PushModalAsync(new Events());
            }
            else if (MenuClicked.Menu == "Settings")
            {
                await Navigation.PushModalAsync(new Settings());
            }
            else if (MenuClicked.Menu == "Sign Out")
            {
                await Navigation.PushModalAsync(new MainPage());
            }


        }


    }
    }

