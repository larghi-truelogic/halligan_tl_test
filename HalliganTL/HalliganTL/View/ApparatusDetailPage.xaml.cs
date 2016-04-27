using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HalliganTL.View
{
    public partial class ApparatusDetailPage : ContentPage
    {

        public ApparatusDetailPage()
        {
            InitializeComponent();
        }

        async void OnCheckButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckApparatusProgressPage());
        }

    }

    
}
