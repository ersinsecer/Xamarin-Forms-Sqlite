using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFSQLite.Model;

namespace XFSQLite
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void ItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage
            {
                BindingContext = new Item()
            });
        }

       

        async void ListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ItemPage
                {
                    BindingContext = e.SelectedItem as Item
                });
            }
        }
    }
}
