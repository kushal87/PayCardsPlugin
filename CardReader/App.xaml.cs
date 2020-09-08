using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CardReader.Views;

namespace CardReader
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new CustomNavigationPage(new CardEntryView());
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
