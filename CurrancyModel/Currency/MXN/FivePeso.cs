using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class FivePeso : MXCoin
    {
        double value = 5;
        string name = "Five Peso";

        public FivePeso()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
