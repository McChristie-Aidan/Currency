using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class DollarCoin : USCoin
    {
        double value = 1;
        string name = "Dollar Coin";

        public DollarCoin()
        {
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }

        public DollarCoin(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
