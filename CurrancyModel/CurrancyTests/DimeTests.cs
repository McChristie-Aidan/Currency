using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyModel.Currency.US;

namespace CurrencyTests
{
    [TestClass]
    public class DimeTests
    {

        [TestMethod]
        public void DimeConstructor()
        {
            //Arrange
            Dime p, philiDime;
            //Act 
            p = new Dime();
            philiDime = new Dime(USCoinMintMark.P);
            //Assert
            //D is the default mint mark
            //Current Year is default year

            Assert.AreEqual(USCoinMintMark.P, philiDime.MintMark);
        }

        [TestMethod]
        public void DimeMonetaryValue()
        {
            //Arrange
            Penny p;
            //Act 
            p = new Penny();
            //Assert
            Assert.AreEqual(.01, p.MonetaryValue);
        }

        [TestMethod]
        public void DimeAbout()
        {
            //Arrange
            Dime p;
            string expected = $"US Dime is from {System.DateTime.Now.Year}. It is worth $0.10. It was made in Denver";
            //Act 
            p = new Dime();
            //Assert
            //About output "US Penny is from 2017. It is worth $0.01. It was made in Denver"
            Assert.AreEqual(expected, p.About());
        }
    }
}
