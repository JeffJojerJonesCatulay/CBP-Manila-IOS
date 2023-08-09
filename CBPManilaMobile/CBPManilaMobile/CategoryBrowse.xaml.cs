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
    public partial class CategoryBrowse : ContentPage
    {
        private string category_filter;

        public CategoryBrowse(string search)
        {
            InitializeComponent();
            category_filter = search;
            this.Title = "CBP Manila";

            var toolBarItem = new ToolbarItem
            {
                Text = "Go Back"
            };

            toolBarItem.Clicked += async (sender, e) =>
            {
                App.Current.MainPage = new NavHome();
            };

            ToolbarItems.Add(toolBarItem);
        }

        // On Appearing
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BusinessListview.ItemsSource = await App.Database.FilterCategotyAsync(category_filter);          
        }

        // On Back Pressed
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new NavHome();
            return true;           
        }

        // Item Selected in ListView
        void BusinessListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                App.Current.MainPage = new NavigationPage(new CBPResult(category_filter) { BindingContext = e.SelectedItem as Business });
            }
        }

        // Search in ListView
        async private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = search.Text;
            var selectedDropdown = picker.SelectedIndex;
            var itemSource = await App.Database.FilterCategotyAsync(category_filter);
            BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));

            if (selectedDropdown == 0)
            {
                itemSource = await App.Database.FilterCategotyAsync(category_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
                
            }
            else if (selectedDropdown == 1)
            {
                string municipal_filter = "Binondo";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));              
            }
            else if (selectedDropdown == 2)
            {
                string municipal_filter = "Ermita";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 3)
            {
                string municipal_filter = "Intramuros";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 4)
            {
                string municipal_filter = "Sampaloc";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 5)
            {
                string municipal_filter = "Paco";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 6)
            {
                string municipal_filter = "Pandacan";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 7)
            {
                string municipal_filter = "Port Area";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 8)
            {
                string municipal_filter = "Quiapo";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 9)
            {
                string municipal_filter = "Malate";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 10)
            {
                string municipal_filter = "San Andres";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 11)
            {
                string municipal_filter = "San Miguel";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 12)
            {
                string municipal_filter = "San Nicolas";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 13)
            {
                string municipal_filter = "Sta Ana";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 14)
            {
                string municipal_filter = "Sta Cruz";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 15)
            {
                string municipal_filter = "Santa Mesa";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 16)
            {
                string municipal_filter = "Tondo";
                 itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
        }

        // Filter in Picker
        async private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDropdown = picker.SelectedIndex;
            if (selectedDropdown == 0)
            {           
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAsync(category_filter);
            }
            else if (selectedDropdown == 1)
            {
                string municipal_filter = "Binondo";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 2)
            {
                string municipal_filter = "Ermita";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 3)
            {
                string municipal_filter = "Intramuros";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 4)
            {
                string municipal_filter = "Sampaloc";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 5)
            {
                string municipal_filter = "Paco";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 6)
            {
                string municipal_filter = "Pandacan";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 7)
            {
                string municipal_filter = "Port Area";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 8)
            {
                string municipal_filter = "Quiapo";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 9)
            {
                string municipal_filter = "Malate";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 10)
            {
                string municipal_filter = "San Andres";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 11)
            {
                string municipal_filter = "San Miguel";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 12)
            {
                string municipal_filter = "San Nicolas";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 13)
            {
                string municipal_filter = "Sta Ana";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 14)
            {
                string municipal_filter = "Sta Cruz";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 15)
            {
                string municipal_filter = "Santa Mesa";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
            else if (selectedDropdown == 16)
            {
                string municipal_filter = "Tondo";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, municipal_filter);
            }
        }
    }
}