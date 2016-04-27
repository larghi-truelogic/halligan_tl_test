using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HalliganTL.View
{
    public partial class MainFeedPage : ContentPage
    {
        public MainFeedPage()
        {
            InitializeComponent();
            //TODO Change this by a Feed object whose fields matches with the ones in MainFeedPage xaml
            FeedListView.ItemsSource = new[] { "Alex", "Steve", "Jack", "David", "Martin", "Henry", "William", "Dave", "Tim" };
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var feed = e.Item;
            if (feed == null)
               return;
            //Push to the feed detail
            //this.Navigation.PushAsync(new PhotoPage(photo));
            this.FeedListView.SelectedItem = null;
        }
    }
}
