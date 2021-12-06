using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MX
{
    internal class OnePeso : MXCoin
    {
        double value = 1;
        string name = "One Peso";

        public OnePeso()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
