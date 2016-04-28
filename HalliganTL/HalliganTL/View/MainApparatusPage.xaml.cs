using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HalliganTL.View
{
    public partial class MainApparatusPage : ContentPage
    {
        public MainApparatusPage()
        {
            InitializeComponent();
            //TODO Get rid of the mock data
           /* ApparatusListView.ItemsSource = new Apparatus[] {
                new Apparatus() { ImageSource = "http://a2.mzstatic.com/us/r30/Purple49/v4/40/c7/df/40c7dfd4-6aeb-e1a8-ea03-9189eba03222/icon128-2x.png", Name = "Engine 550" },
                new Apparatus() { ImageSource = "http://d2gzmlqnkfjqmm.cloudfront.net/data/product/content/agg/hubbell/Hubbell-Premise-Wiring/NextFrameLadder-Rack/D5177439241A498BB775AC170737DCF2_62F8CE82AF841A1A5D76D03023EDCE9E.detail.jpg", Name = "Ladder 551" },
                new Apparatus() { ImageSource = "http://iedchs.com/Lectures/wp-content/uploads/rtMedia/groups/1/2015/09/engineer.png", Name = "Engineer 552" },
                new Apparatus() { ImageSource = "http://www.fancyicons.com/free-icons/146/cema-graphics/png/256/tanker_256.png", Name = "Tanker 553" }
            };*/
        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var apparatus = e.SelectedItem;
            if (apparatus == null)
                return;
            //TODO Send apparatus through the arguments
            this.Navigation.PushAsync(new ApparatusDetailPage());
            this.ApparatusListView.SelectedItem = null;
        }
    }
}
