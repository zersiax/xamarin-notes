using System;

using Xamarin.Forms;
using Xamarin.Essentials;
namespace FromTheStart.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://florianbeijers.xyz");

        }
    }
}