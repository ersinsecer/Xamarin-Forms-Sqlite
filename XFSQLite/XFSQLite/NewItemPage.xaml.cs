using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLite.Model;

namespace XFSQLite
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NewItemPage : ContentPage
	{
		public NewItemPage ()
		{
			InitializeComponent ();
		}

        async void SaveClicked(object sender, EventArgs e)
        {
            var Item = (Item)BindingContext;
            await App.Database.SaveItemAsync(Item);
            await Navigation.PushAsync(new MainPage());
        }

        async void DeleteClicked(object sender, EventArgs e)
        {
            var Item = (Item)BindingContext;
            await App.Database.DeleteItemAsync(Item);
            await Navigation.PushAsync(new MainPage());
        }

        async void CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}