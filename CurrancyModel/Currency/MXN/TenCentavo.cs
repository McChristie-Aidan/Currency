using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class TenCentavo : MXCoin
    {
        double value = .1;
        string name = "Ten Centavo";

        public TenCentavo()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
