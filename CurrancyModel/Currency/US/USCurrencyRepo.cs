using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.US
{
    public class USCurrencyRepo : CurrencyRepo
    {
        static USCoin[] everyCoin = new USCoin[] {
            new DollarCoin(),
            new HalfDollar(),
            new Quarter(),
            new Dime(),
            new Nickel(),
            new Penny()};

        public USCurrencyRepo()
        {       
        }

        new static public ICurrencyRepo CreateChange(double Amount)
        {
            return CreateChange(Amount, 0);
        }

        new static public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            USCurrencyRepo result = new USCurrencyRepo();
            double differnce = AmountTendered - TotalCost;
            double loopHelper = 0;
            int i = 0;

            //this is really jank and needs improvement.
            //I wanted to use an array that stores each coin and iderate through it to get my values
            //that way i wouldn't have to hard code it and i could add larger denominations of money easily if need be
            //i think i maybe overthinking it though
            //it works just suboptimally

            while (loopHelper < differnce)
            {
                if (loopHelper + everyCoin[i].MonetaryValue < differnce)
                {
                    result.AddCoin(everyCoin[i]);
                }
                else
                {
                    i++;
                }
            }

            return result;
        }
    }
}
