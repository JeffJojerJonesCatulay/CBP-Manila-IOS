using CBPManilaMobile.Controller;
using CBPManilaMobile.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CBPManilaMobile
{
    public partial class App : Application
    {
        static BusinessDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        // Property
        public static BusinessDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new BusinessDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalFilePath("data.db"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
