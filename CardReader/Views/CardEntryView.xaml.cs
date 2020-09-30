using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CardReader.ViewModels;
using System;

namespace CardReader.Views
{ 
    public partial class CardEntryView : ContentPage
    {
        public CardEntryView()
        {
            InitializeComponent();
            this.BindingContext = new CardEntryViewModel();            
        }

        public void Handle_ModeChange(object sender, EventArgs e)
        {
            Theme themeRequested = App.AppTheme == Theme.Light ? Theme.Dark : Theme.Light;
            MessagingCenter.Send<Page, Theme>(this, "ModeChanged", themeRequested);
        }
    }
}
