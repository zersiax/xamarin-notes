using System;
using System.IO;
using Xamarin.Forms;

namespace FromTheStart
{
    public partial class App : Application
    {
        public static string FolderPath { get; set; }
        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
