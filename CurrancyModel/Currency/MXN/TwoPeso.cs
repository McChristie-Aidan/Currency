using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MXN
{
    public class TwoPeso : MXCoin
    {
        double value = 2;
        string name = "Two Peso";

        public TwoPeso()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
