using DietApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DietApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            BindingContext = this;
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            displayData();
        }

        void displayData()
        {
            List<welcomeImage> source = new List<welcomeImage>();
            source.Add(new welcomeImage() 
            { 
                 img_url="run",
            }
           );

            source.Add(new welcomeImage()
            {
                img_url = "run",
            }
           );
            BindableLayout.SetItemsSource(listing,source);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            tab_1.BackgroundColor = Color.FromHex("#6CC57C");
            tab_2.BackgroundColor = Color.Transparent;
            tab_3.BackgroundColor = Color.Transparent;
            lvl_1.TextColor = Color.White;
            lvl_2.TextColor = Color.Black;
            lvl_3.TextColor = Color.Black;
           
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            tab_1.BackgroundColor = Color.Transparent;
            tab_2.BackgroundColor = Color.FromHex("#6CC57C");
            tab_3.BackgroundColor = Color.Transparent;
            lvl_1.TextColor = Color.Black;
            lvl_2.TextColor = Color.White;
            lvl_3.TextColor = Color.Black;
           
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            tab_1.BackgroundColor = Color.Transparent;
            tab_2.BackgroundColor = Color.Transparent;
            tab_3.BackgroundColor = Color.FromHex("#6CC57C");
            lvl_1.TextColor = Color.Black;
            lvl_2.TextColor = Color.Black;
            lvl_3.TextColor = Color.White;
           
        }
    }
}