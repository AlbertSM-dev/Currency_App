namespace Currency_M
{
    public class Rates
    {
        public double CAD { get; set; }
        public double HKD { get; set; }
        public double ISK { get; set; }
        public double PHP { get; set; }
        public double DKK { get; set; }
        public double HUF { get; set; }
        public double CZK { get; set; }
        public double AUD { get; set; }
        public double RON { get; set; }
        public double SEK { get; set; }
        public double IDR { get; set; }
        public double INR { get; set; }
        public double BRL { get; set; }
        public double RUB { get; set; }
        public double HRK { get; set; }
        public double JPY { get; set; }
        public double THB { get; set; }
        public double CHF { get; set; }
        public double SGD { get; set; }
        public double PLN { get; set; }
        public double BGN { get; set; }
        public double TRY { get; set; }
        public double CNY { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double ZAR { get; set; }
        public double USD { get; set; }
        public double MXN { get; set; }
        public double ILS { get; set; }
        public double GBP { get; set; }
        public double KRW { get; set; }
        public double MYR { get; set; }
    }
    public class Currency
    {
        public Rates rates { get; set; }
        public double Quantity { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public double CurrencyTotal { get; set; }
        /*public string CurrencyChange()
        { return $"{Quantity} {FromCurrency} = {CurrencyCalculations(Quantity, FromCurrency)} {ToCurrency}"; }
        public double CurrencyCalculations(int q, string from)
        {
            if(from == "EUR")
            {
                return q * 1.2;
            }
            return 0;
        }*/
    }
    /*
    public class WeatherData
    {
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("visibility")]
        public long Visibility { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public long Humidity { get; set; }
    }

    public class Weather
    {
        [JsonProperty("main")]
        public string Visibility { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }*/
}
