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
    public partial class NavSearchPlaces : ContentPage
    {
        public IList<Place> Places { get; set; }
        public Action<object, object> CurrentPageChanged { get; }

        public NavSearchPlaces()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
                
            }

            Places = new List<Place>();
            Places.Add(new Place
            {
                placeName = "Binondo",
                businessNum = "76 Business",
                ImageURL = "binondo.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Ermita",
                businessNum = "60 Business",
                ImageURL = "ermita.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Intramuros",
                businessNum = "62 Business",
                ImageURL = "intramuros.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Sampaloc",
                businessNum = "263 Business",
                ImageURL = "sampaloc.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Paco",
                businessNum = "146 Business",
                ImageURL = "paco.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Pandacan",
                businessNum = "81 Business",
                ImageURL = "pandacan.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Port Area",
                businessNum = "19 Business",
                ImageURL = "portArea.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Quaipo",
                businessNum = "84 Business",
                ImageURL = "quiapo.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Malate",
                businessNum = "100 Business",
                ImageURL = "malate.jpg"
            });
            Places.Add(new Place
            {
                placeName = "San Andres",
                businessNum = "53 Business",
                ImageURL = "sanAndres.jpg"
            });
            Places.Add(new Place
            {
                placeName = "San Miguel",
                businessNum = "33 Business",
                ImageURL = "sanMiguel.jpg"
            });
            Places.Add(new Place
            {
                placeName = "San Nicholas",
                businessNum = "36 Business",
                ImageURL = "sanNicholas.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Santa Ana",
                businessNum = "65 Business",
                ImageURL = "santaAna.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Santa Cruz",
                businessNum = "74 Business",
                ImageURL = "santaCruz.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Santa Mesa",
                businessNum = "161 Business",
                ImageURL = "santaMesa.jpg"
            });
            Places.Add(new Place
            {
                placeName = "Tondo",
                businessNum = "77 Business",
                ImageURL = "tondo.jpg"
            });

            BindingContext = this;
        }
        public class Place
        {
            public string placeName { get; set; }
            public string businessNum { get; set; }
            public string ImageURL { get; set; }
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItemIndex == 0)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Binondo"));
            }
            else if (e.SelectedItemIndex == 1)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Ermita"));
            }
            else if (e.SelectedItemIndex == 2)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Intramuros"));
            }
            else if (e.SelectedItemIndex == 3)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Sampaloc"));
            }
            else if (e.SelectedItemIndex == 4)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Paco"));
            }
            else if (e.SelectedItemIndex == 5)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Pandacan"));
            }
            else if (e.SelectedItemIndex == 6)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Port Area"));
            }
            else if (e.SelectedItemIndex == 7)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Quiapo"));
            }
            else if (e.SelectedItemIndex == 8)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Malate"));
            }
            else if (e.SelectedItemIndex == 9)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("San Andres"));
            }
            else if (e.SelectedItemIndex == 10)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("San Miguel"));
            }
            else if (e.SelectedItemIndex == 11)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("San Nicolas"));
            }
            else if (e.SelectedItemIndex == 12)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Sta Ana"));
            }
            else if (e.SelectedItemIndex == 13)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Sta Cruz"));
            }
            else if (e.SelectedItemIndex == 14)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Santa Mesa"));
            }
            else if (e.SelectedItemIndex == 15)
            {
                App.Current.MainPage = new NavigationPage(new PlaceBrowse("Tondo"));
            }
        }
    }
}