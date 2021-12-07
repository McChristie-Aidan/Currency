using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MXN
{
    public class TwentyPeso : MXCoin 
    {
        double value = 1;
        string name = "Twenty Peso";

        public TwentyPeso()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
