using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CBPManilaMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            _ = Animate();
        }

        public async Task Animate()
        {
            cbpTxt.Opacity = 0;
            cbplogo.Opacity = 0;
            await cbpTxt.FadeTo(1, 4000);  
            await cbplogo.FadeTo(1, 4000);
            Application.Current.MainPage = new NavHome();
        }
    }
}
