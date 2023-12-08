using System.Collections.Generic;

namespace exchange
{
    public class Money
    {
        public List<string> LsMoney;
        public string SelectedCurrency { get; set; }
        public Dictionary<string, double> ExchangeRates { get; set; }

        public Money()
        {
            LsMoney = new List<string>
        {
            "USD", "EUR", "GBP", "JPY", "CHF", "CAD", "AUD", "CNY", "SEK", "NZD", "MXN", "SGD", "HKD"
        };
            SelectedCurrency = "USD";
            ExchangeRates = new Dictionary<string, double>();
        }
    }
}
