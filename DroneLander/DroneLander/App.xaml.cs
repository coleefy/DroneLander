using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;

namespace DroneLander
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }

        public App()
        {
            InitializeComponent();

            //MainPage = new DroneLander.MainPage();
            MainPage = new NavigationPage(new DroneLander.MainPage());
        }

        protected override void OnStart()
        {
            MobileCenter.Start("uwp=45c913fb-f744-4b9c-b783-fb83be59236e;",
                   typeof(Analytics));
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
