using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manwood.SalesTax.Domain;
using Manwood.SalesTax.Tests.Stubs;

namespace Manwood.SalesTax.Tests
{
    [TestClass]
    public class SalesItemTaxDecoratorTest
    {
        [TestMethod]
        public void SalesItemTaxDecoratorPriceTest()
        {
            SalesItemTaxDecorator taxDecorator = new SalesItemTaxDecorator(new SalesItemStub(10M, 0M), new TaxStub(0.1M));

            decimal price = taxDecorator.GetPrice();

            Assert.AreEqual(10M, price);
        }

        [TestMethod]
        public void SalesItemTaxDecoratorTaxTest()
        {
            SalesItemTaxDecorator taxDecorator = new SalesItemTaxDecorator(new SalesItemStub(10M, 0M), new TaxStub(0.1M));

            decimal tax = taxDecorator.GetSalesTax();

            Assert.AreEqual(1M, tax);
        }

        [TestMethod]
        public void SalesItemTaxDecoratorTotalTest()
        {
            SalesItemTaxDecorator taxDecorator = new SalesItemTaxDecorator(new SalesItemStub(10M, 0M), new TaxStub(0.1M));

            decimal total = taxDecorator.GetTotal();

            Assert.AreEqual(11M, total);
        }
    }
}
