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
    public partial class DashBoard : MasterDetailPage
    {
        public DashBoard()
        {
            InitializeComponent();

            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.Menu = this;

        }
    }
}
