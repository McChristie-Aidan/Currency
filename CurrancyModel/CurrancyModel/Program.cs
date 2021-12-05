using System;
using CurrencyModel;
using CurrencyModel.Currency.US;

namespace CurrancyModel
{
    class Program
    {
        static void Main(string[] args)
        {
            USCurrencyRepo.CreateChange(.06);
        }
    }
}
