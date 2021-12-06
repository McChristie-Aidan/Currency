using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency
{
    public interface ICurrency
    {
        public double MonetaryValue { get; }
        public string Name { get; }
        string About();
    }
}
