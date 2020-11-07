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
    public partial class Login : ContentPage
    {
        bool isPassword = true;
        public Login()
        {
            BindingContext = this;
            InitializeComponent();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
      
        private void CustomEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsValidEmail(emailAddress.Text))
            {

                checkIcon.TextColor = Color.FromHex("#61D27C");
            }
            else
            {
                checkIcon.TextColor = Color.Transparent;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           
           
            if (isPassword)
            {
                isPassword = false;
                password.IsPassword = isPassword;
                passSeeIcon.Text = "\uf6d0";
            }
            else
            {
                isPassword = true;
                password.IsPassword = isPassword;
                passSeeIcon.Text = "\uf6cf";
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new UserInfo());
        }
    }
}