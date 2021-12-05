using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            this.Coins.Add(c);
        }
        static protected ICurrencyRepo CreateChange(double Amount)
        {
            throw new NotImplementedException();
        }

        static protected ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }
        public CurrencyRepo()
        {
            this.Coins = new List<ICoin>();
        }
        public int GetCoinCount()
        {
            int count = 0;
            foreach (ICoin c in Coins)
            {
                count++;
            }

            return count;
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            this.MakeChange(Amount, 0);
            return (ICurrencyRepo)this.Coins;
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            double difference = AmountTendered - TotalCost;

            while(this.TotalValue() < difference)
            {
                double currentValue = this.TotalValue();
            }
            return (ICurrencyRepo)this.Coins;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        public double TotalValue()
        {
            double count = 0;
            foreach (ICoin c in Coins)
            {
                count += c.MonetaryValue;
            }
            return count;
        }
    }
}
