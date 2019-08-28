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
	public partial class ItemPage : TabbedPage
	{

        public ItemPage()
        {
            InitializeComponent();
        }
        
        async void ItemEdit(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage
            {
                BindingContext = BindingContext
            });
        }

    }
}
