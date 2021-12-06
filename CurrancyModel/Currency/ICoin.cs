using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyModel.Currency
{
    public interface ICoin : ICurrency
    {
        public int Year { get; }
    }
}
