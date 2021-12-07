using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MXN
{
    public class FiftyCentavo : MXCoin
    {
        double value = 1;
        string name = "Ten Peso";

        public FiftyCentavo()
        {
            this.SetNewCoinValues(name, value);
        }
    }
}
