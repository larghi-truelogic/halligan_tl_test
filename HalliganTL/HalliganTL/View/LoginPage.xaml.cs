using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HalliganTL.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnForgotPasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            HalliganCredential credentials = new HalliganCredential
            {
                Email = entryEmail.Text,
                Password = entryPassword.Text
            };
            messageLabel.Text = "Login...";
            bool isValid = true;//await App.RestClient.GetUserAuthAsync(credentials);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                entryPassword.Text = string.Empty;
            }
        }

        private bool AreCredentialsCorrect(User user)
        {
            //TODO This should call the /authorize webservice
            return !string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Password);
        }
    }
}
