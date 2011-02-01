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
    public class TaxTest
    {
        [TestMethod]
        public void TaxCalculateTaxTest()
        {
            Tax tax = new Tax(0.1M, new RoundingStub());

            decimal taxVal = tax.CalculateTax(10M);

            Assert.AreEqual(1M, taxVal);
        }
    }
}
