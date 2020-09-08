using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.PayCards;
using Xamarin.Forms;

namespace CardReader
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ScanAsync();
        }

        public async void ScanAsync()
        {
            var cardInfo = await CrossPayCards.Current.ScanAsync();            
            _ = DisplayAlert("Result", $"{cardInfo.HolderName}\n{cardInfo.CardNumber}\n{cardInfo.ExpirationDate}", "Yes", "No");
        }
    }
}
