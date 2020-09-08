using System.Windows.Input;
using System;
using Plugin.PayCards;
using Xamarin.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace CardReader.ViewModels
{
    public class CardEntryViewModel : INotifyPropertyChanged
    {
        public ICommand CardScanButtonCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        // props
        private string _cardHolderName;
        public string CardHolderName
        {
            get { return _cardHolderName; }
            set { SetField(ref _cardHolderName, value, "CardHolderName"); }
        }

        private string _cardNumber;
        public string CardNumber
        {
            get { return _cardNumber; }
            set { SetField(ref _cardNumber, value, "CardNumber"); }
        }

        private string _cardExpirationDate;
        public string CardExpirationDate
        {
            get { return _cardExpirationDate; }
            set { SetField(ref _cardExpirationDate, value, "CardExpirationDate"); }
        }

        
        public CardEntryViewModel()
        {
            CardScanButtonCommand = new Command(CardScanAsync, () => true);
        }
     
        private async void CardScanAsync()
        {
            try
            {
                var cardInfo = await CrossPayCards.Current.ScanAsync();
                CardHolderName = cardInfo.HolderName;
                CardNumber = cardInfo.CardNumber;
                CardExpirationDate = cardInfo.ExpirationDate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }            
        }

        //Property binding Methods
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        //Generic Method
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}