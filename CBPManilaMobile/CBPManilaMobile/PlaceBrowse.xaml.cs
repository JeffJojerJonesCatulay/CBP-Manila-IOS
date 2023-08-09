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
    public partial class PlaceBrowse : ContentPage
    {
        private string place_filter;
        public PlaceBrowse(string search)
        {
            InitializeComponent();
            place_filter = search;
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

        // Item Selected in ListView
        void BusinessListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                App.Current.MainPage = new NavigationPage(new CBPResultPlace(place_filter) { BindingContext = e.SelectedItem as Business });
            }
        }

        // Search in ListView
        async private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDropdown = picker.SelectedIndex;
            if (selectedDropdown == 0)
            {
                BusinessListview.ItemsSource = await App.Database.FilterPlacesAsync(place_filter);
            }
            else if (selectedDropdown == 1)
            {
                string category_filter = "Commercial";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 2)
            {
                string category_filter = "Food";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 3)
            {
                string category_filter = "Furniture";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 4)
            {
                string category_filter = "Hardware";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 5)
            {
                string category_filter = "Mall";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 6)
            {
                string category_filter = "Pet Shop";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 7)
            {
                string category_filter = "Salon";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 8)
            {
                string category_filter = "Store";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }
            else if (selectedDropdown == 9)
            {
                string category_filter = "Water";
                BusinessListview.ItemsSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
            }    
        }

        // On Appearing
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BusinessListview.ItemsSource = await App.Database.FilterPlacesAsync(place_filter);
        }

        // On Back Pressed
        protected override bool OnBackButtonPressed()
        {
            App.Current.MainPage = new NavSearchPlaces();
            return true;
        }

        // Search in ListView
        async private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = search.Text;
            var selectedDropdown = picker.SelectedIndex;
            var itemSource = await App.Database.FilterPlacesAsync(place_filter);
            BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));

            if (selectedDropdown == 0)
            {
                itemSource = await App.Database.FilterPlacesAsync(place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
                
            }
            else if (selectedDropdown == 1)
            {
                string category_filter = "Commercial";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));              
            }
            else if (selectedDropdown == 2)
            {
                string category_filter = "Food";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 3)
            {
                string category_filter = "Furniture";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 4)
            {
                string category_filter = "Hardware";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 5)
            {
                string category_filter = "Mall";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 6)
            {
                string category_filter = "Pet Shop";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 7)
            {
                string category_filter = "Salon";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 8)
            {
                string category_filter = "Store";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }
            else if (selectedDropdown == 9)
            {
                string category_filter = "Water";
                itemSource = await App.Database.FilterCategotyAndPlacesAsync(category_filter, place_filter);
                BusinessListview.ItemsSource = itemSource.Where(sample => sample.BusinessName.ToLower().Contains(keyword.ToLower()));
            }         
        }
    }
}