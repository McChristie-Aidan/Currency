using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MXN
{
    public class TwentyCentavo : MXCoin
    {
        double value = .20;
        string name = "Twenty Centavo";

        public TwentyCentavo()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
