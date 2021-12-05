using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public enum USCoinMintMark
    {
        P,
        D,
        S,
        W
    }
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark { get; protected set; }

        new public string About()
        {
            return $"US {this.Name} is from {this.Year}. It is worth ${this.MonetaryValue.ToString("F")}. It was made in {GetMintNameFromMark()}";
        }

        public string GetMintNameFromMark()
        {
            switch (MintMark)
            {
                case USCoinMintMark.P:
                    return "Philadelphia";
                case USCoinMintMark.D:
                    return "Denver";
                case USCoinMintMark.S:
                    return "San Francisco";
                case USCoinMintMark.W:
                    return "West Point";
            }
            return "Invalid Mint Mark";
        }
        public static string GetMintNameFromMark(USCoinMintMark mintMark)
        {
            switch (mintMark)
            {
                case USCoinMintMark.P:
                    return "Philadelphia";
                case USCoinMintMark.D:
                    return "Denver";
                case USCoinMintMark.S:
                    return "San Francisco";
                case USCoinMintMark.W:
                    return "West Point";
            }
            return "Invalid Mint Mark";
        }

        public USCoin()
        {
        }

        protected void SetNewCoinValues(string name, double value)
        {
            this.Name = name;
            this.MonetaryValue = value;
            this.Year = System.DateTime.Now.Year;
        }
    }
}
