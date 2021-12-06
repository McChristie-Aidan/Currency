using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class MXCoin : Coin
    {
        new public string About()
        {
            return $"US {this.Name} is from {this.Year}. It is worth ${this.MonetaryValue.ToString("F")}.";
        }
        protected void SetNewCoinValues(string name, double value)
        {
            this.Name = name;
            this.MonetaryValue = value;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
