using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class FiveCentavo : MXCoin
    {
        double value = .05;
        string name = "Five Centavo";

        public FiveCentavo()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
