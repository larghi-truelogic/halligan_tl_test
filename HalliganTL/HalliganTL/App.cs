using HalliganTL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XLabs.Forms.Mvvm;

namespace HalliganTL

{
    public class App : Application
    {
        public static RequestManager RestClient { get; private set; }
        public static bool IsUserLoggedIn { get; internal set; }

        public App()
        {
            RestClient = new RequestManager(new RestService());
            MainPage = new NavigationPage(new LoginPage { Title = "Login", Icon = "xaml.png" });
        }
    }
}
