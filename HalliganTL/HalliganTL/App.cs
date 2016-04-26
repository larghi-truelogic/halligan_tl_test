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
        public static RolesManager RolesItemManager { get; private set; }

        public App()
        {
            RolesItemManager = new RolesManager(new RestService());
            MainPage = new FeedMainList { Title = "Feeds", Icon = "xaml.png" };
        }
    }
}
