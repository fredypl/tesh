using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tesh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MenuItem;
            if (item == null)
                return;
            if (item.Title == "Android")
            {
                Detail = new NavigationPage(new androi());
                IsPresented = false;
            }

            if (item.Title == "IOS")
            {
                Detail = new NavigationPage(new ios());
                IsPresented = false;
            }
            if (item.Title == "UWP")
            {
                Detail = new NavigationPage(new uwp());
                IsPresented = false;
            }

            MasterPage.ListView.SelectedItem = null;


        }
    }
}