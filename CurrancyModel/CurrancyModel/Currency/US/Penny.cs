using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class Penny : USCoin
    {
        double value = .01;
        string name = "Penny";

        public Penny()
        {
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }

        public Penny(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
