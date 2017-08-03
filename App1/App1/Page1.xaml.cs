using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender,EventArgs e)
        {
            MainLabel.Text = "Hello " + MainEntry.Text;
                
        }

        private async void navigateToSecondPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(MainEntry.Text));
        }

        
    }
}
