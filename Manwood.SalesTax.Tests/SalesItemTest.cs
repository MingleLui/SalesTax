using Manwood.SalesTax.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Manwood.SalesTax.Tests
{

    [TestClass()]
    public class SalesItemTest
    {
  
        [TestMethod()]
        public void SalesItemGetPriceTest()
        {
            SalesItem target = new SalesItem("test item", 10M); 
            decimal actual = target.GetPrice();
            Assert.AreEqual(10M, actual);
        }

        [TestMethod()]
        public void SalesItemGetSalesTaxTest()
        {
            SalesItem target = new SalesItem("test item", 10M);
            decimal actual = target.GetSalesTax();
            Assert.AreEqual(0M, actual);
        }

        [TestMethod()]
        public void SalesItemGetTotalTest()
        {
            SalesItem target = new SalesItem("test item", 10M);
            decimal actual = target.GetTotal();
            Assert.AreEqual(10M, actual);
        }
    }
}
