using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CardReader.Views;

namespace CardReader
{
    public partial class App : Application
    {
        public static Theme AppTheme { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new CustomNavigationPage(new CardEntryView());
        }        
    }

    public enum Theme
    {
        Light,
        Dark
    }
}
