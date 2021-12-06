using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class TenPeso : MXCoin
    {
        double value = 1;
        string name = "Ten Peso";

        public TenPeso()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
