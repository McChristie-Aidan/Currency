using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class HalfDollar : USCoin
    {
        double value = .5;
        string name = "Half Dollar";

        public HalfDollar()
        {
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }

        public HalfDollar(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
