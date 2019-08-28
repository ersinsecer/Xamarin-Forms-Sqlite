using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFSQLite.Data;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XFSQLite
{
	public partial class App : Application
	{
        static Database database;

        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new  Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
