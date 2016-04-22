using HalliganTL.View;
using HalliganTL.ViewModel;
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
        private void RegisterViews()
        {
            ViewFactory.Register<MainView, MainViewModel>();
        }

        public App()
        {
            RegisterViews();
            MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainView>());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
