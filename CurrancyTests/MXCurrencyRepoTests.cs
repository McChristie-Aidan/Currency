using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyModel.Currency.MXN;
using CurrencyModel.Currency;

namespace CurrencyTests
{
    [TestClass]
    class MXCurrencyRepoTests
    {
        ICurrencyRepo repo;
        TwentyCentavo twentyCentavo;
        FiftyCentavo fiftyCentavo;
        OnePeso onePeso;
        FivePeso fivePeso;
        TenPeso tenPeso;
        TwentyPeso twentyPeso;
        public MXCurrencyRepoTests()
        {
            twentyCentavo = new TwentyCentavo();
            fiftyCentavo = new FiftyCentavo();
            onePeso = new OnePeso();
            fivePeso = new FivePeso();
            tenPeso = new TenPeso();
            twentyPeso = new TwentyPeso();
        }

        [TestMethod]
        public void MakeChangeTests()
        {
            //Arrange
            MXCurrencyRepo changeOneQuatersOnHalfDollar, changeTwoDollars, changeOneDollarOneHalfDoller,
               changeOneDimeOnePenny, changeOneNickelOnePenny, changeFourPennies;


            //Act
            changeTwoDollars = (USCurrencyRepo)USCurrencyRepo.CreateChange(2.0);
            changeOneDollarOneHalfDoller = (USCurrencyRepo)USCurrencyRepo.CreateChange(1.5);
            changeOneQuatersOnHalfDollar = (USCurrencyRepo)USCurrencyRepo.CreateChange(.75);

            changeOneDimeOnePenny = (USCurrencyRepo)USCurrencyRepo.CreateChange(.11);
            changeOneNickelOnePenny = (USCurrencyRepo)USCurrencyRepo.CreateChange(.06);
            changeFourPennies = (USCurrencyRepo)USCurrencyRepo.CreateChange(.04);


            //Assert
            Assert.AreEqual(changeTwoDollars.Coins.Count, 2);
            Assert.AreEqual(changeTwoDollars.Coins[0].GetType(), new DollarCoin().GetType());
            Assert.AreEqual(changeTwoDollars.Coins[1].GetType(), new DollarCoin().GetType());

            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins.Count, 2);
            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins[0].GetType(), new DollarCoin().GetType());
            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins[1].GetType(), new HalfDollar().GetType());


            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins.Count, 2);
            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins[0].GetType(), new HalfDollar().GetType());
            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins[1].GetType(), new Quarter().GetType());

            Assert.AreEqual(changeOneDimeOnePenny.Coins.Count, 2);
            Assert.AreEqual(changeOneDimeOnePenny.Coins[0].GetType(), new Dime().GetType());
            Assert.AreEqual(changeOneDimeOnePenny.Coins[1].GetType(), new Penny().GetType());

            Assert.AreEqual(changeOneNickelOnePenny.Coins.Count, 2);
            Assert.AreEqual(changeOneNickelOnePenny.Coins[0].GetType(), new Nickel().GetType());
            Assert.AreEqual(changeOneNickelOnePenny.Coins[1].GetType(), new Penny().GetType());


            Assert.AreEqual(changeFourPennies.Coins.Count, 4);
            Assert.AreEqual(changeFourPennies.Coins[0].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[1].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[2].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[3].GetType(), new Penny().GetType());

        }
    }
}
