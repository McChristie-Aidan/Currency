using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency
{
    public abstract class Coin : ICoin
    {
        public double MonetaryValue { get; protected set; }
        public string Name { get; protected set; }
        public int Year { get; protected set; } 

        public string About()
        {
            return "";
        }
        
        public Coin()
        {

        }
    }
}
