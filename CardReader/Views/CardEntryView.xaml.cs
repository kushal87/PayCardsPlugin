using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CardReader.ViewModels;

namespace CardReader.Views
{ 
    public partial class CardEntryView : ContentPage
    {
        public CardEntryView()
        {
            InitializeComponent();
            this.BindingContext = new CardEntryViewModel();            
        }
    }
}
