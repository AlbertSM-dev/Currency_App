using System;
using Xamarin.Forms;

namespace Currency_M
{
    public partial class MainPage : ContentPage
    {
        public RestService _restService;

        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (Quantity.Text == null || Quantity.Text.Length > 10) { Quantity.Text = "0"; }
            var QuantityPost = Int64.Parse(Quantity.Text);
            string selectedFrom = (string)From.SelectedItem;
            string currencySelected = (string)To.SelectedItem;
            double currencyChange = 0;

            Currency currency = await _restService.GetWeatherDataAsync(@"https://api.exchangeratesapi.io/latest");

            //Currency Selected and Change
            if (currencySelected == "USD") { currencyChange = currency.rates.USD; }
            else if (currencySelected == "GBP") { currencyChange = currency.rates.GBP; }
            else if (currencySelected == "CAD") { currencyChange = currency.rates.CAD; }
            else if (currencySelected == "AUD") { currencyChange = currency.rates.AUD; }


            if (selectedFrom == "EUR")
            {
                currency.Quantity = QuantityPost;
                currency.FromCurrency = selectedFrom;
                currency.ToCurrency = currencySelected;
                currency.CurrencyTotal = currencyChange * QuantityPost;
            }

            BindingContext = currency;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            //lets the Entry be empty
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }
        }
    }
}
