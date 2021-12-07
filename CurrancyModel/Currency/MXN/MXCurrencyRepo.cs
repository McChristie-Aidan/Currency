using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency.MXN
{
    public class MXCurrencyRepo : CurrencyRepo
    {

        public MXCurrencyRepo()
        {
        }

        new static public ICurrencyRepo CreateChange(double Amount)
        {
            return CreateChange(Amount, 0);
        }

        new static public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            MXCurrencyRepo result = new MXCurrencyRepo();
            double differnce = AmountTendered - TotalCost;
            double loopHelper = 0;

            //this is really jank and needs improvement.
            //I wanted to use an array that stores each coin and iderate through it to get my values
            //that way i wouldn't have to hard code it and i could add larger denominations of money easily if need be
            //i think i maybe overthinking it though
            //it works just suboptimally

            while (loopHelper < differnce)
            {
                if (loopHelper + 20 <= differnce)
                {
                    result.AddCoin(new TwentyPeso());
                    loopHelper += 20;
                }
                else if (loopHelper + 10 <= differnce)
                {
                    result.AddCoin(new TenPeso());
                    loopHelper += 10;
                }
                else if (loopHelper + 5 <= differnce)
                {
                    result.AddCoin(new FivePeso());
                    loopHelper += 5;
                }
                else if (loopHelper + 1 <= differnce)
                {
                    result.AddCoin(new OnePeso());
                    loopHelper += 1;
                }
                else if (loopHelper + .5 <= differnce)
                {
                    result.AddCoin(new FiftyCentavo());
                    loopHelper += .5;
                }
                else
                {
                    result.AddCoin(new TwentyCentavo());
                    loopHelper += .2;
                }
            }
            return result;
        }
    }
}
