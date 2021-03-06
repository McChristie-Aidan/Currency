using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class Dime : USCoin
    {
        double value = .1;
        string name = "Dime";

        public Dime()
        {
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }

        public Dime(USCoinMintMark mintMark)
        {
            this.MintMark = mintMark;
            this.MonetaryValue = value;
            this.Name = name;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
