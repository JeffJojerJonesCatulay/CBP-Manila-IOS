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
    public partial class NavHome : TabbedPage
    {
        public NavHome()
        {
            InitializeComponent();
            var clrBg = Color.FromHex("#f5bd1f");
            this.BarBackgroundColor = clrBg;
            var clrTxt = Color.FromHex("#000000");
            this.BarTextColor = clrTxt;

            CurrentPageChanged += (sender, e) =>
            {
                if (CurrentPage == Children.First())
                {
                    Application.Current.MainPage = new NavHome();
                }                
            };
        }
    }
}