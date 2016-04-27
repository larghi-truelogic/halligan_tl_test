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
            listView.ItemsSource = new[] { "Alex", "Steve", "Jack", "David", "Martin", "Henry", "William", "Dave", "Tim" };
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }

    }
}
