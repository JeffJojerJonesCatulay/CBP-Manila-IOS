using MediaManager;
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
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
               
            }
            VideoAnimation();
        }

        private void VideoAnimation()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {   
                CrossMediaManager.Current.RepeatMode = MediaManager.Playback.RepeatMode.All;
                CrossMediaManager.Current.PlayFromResource("IntroAnimation.mp4");           
            }
            else if (Device.RuntimePlatform == Device.Android)
            {    
                CrossMediaManager.Current.RepeatMode = MediaManager.Playback.RepeatMode.All;
                CrossMediaManager.Current.Play("file:///android_asset/IntroAnimation.mp4");
            }
        }

        // Open Browse Filter by Category
         private void commercial_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Commercial"));
        }
        private void food_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Food"));
        }
        private void furniture_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Furniture"));
        }
        private void hardware_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Hardware"));
        }
        private void mall_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Mall"));
        }
        private void pet_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Pet Shop"));
        }
        private void salon_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Salon"));
        }
        private void store_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new CategoryBrowse("Store"));
        }
        private void water_Tapped(object sender, EventArgs e)
        {
           App.Current.MainPage = new NavigationPage(new CategoryBrowse("Water"));
        }

    }
}