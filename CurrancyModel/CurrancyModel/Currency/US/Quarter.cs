using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class Quarter : USCoin
    {
        double value = .25;
        string name = "Dollar Coin";

        public Quarter()
        {
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }

        public Quarter(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
