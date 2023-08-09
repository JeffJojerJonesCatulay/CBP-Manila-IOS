using CBPManilaMobile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CBPManilaMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CBPResultPlace : ContentPage
    {
        private string recent_search;
        public CBPResultPlace(string recent)
        {
            InitializeComponent();
            recent_search = recent;

            this.Title = "CBP Manila";

            var toolBarItem = new ToolbarItem
            {
                Text = "Go Back"
            };

            toolBarItem.Clicked += async (sender, e) =>
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse(recent_search));
            };

            ToolbarItems.Add(toolBarItem);
        }

      
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new PlaceBrowse(recent_search);
            return true;
        }
    }
}