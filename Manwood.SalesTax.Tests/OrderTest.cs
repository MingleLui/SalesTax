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
    public class OrderTest
    {
        [TestMethod]
        public void OrderSingleItemPriceTest()
        {
            Order order = new Order();
            order.AddItem(new SalesItemStub(10.0M, 1.0M));

            decimal price = order.GetOrderPrice();

            Assert.AreEqual(10.0M, price);
        }

        [TestMethod]
        public void OrderSingleItemTaxTest()
        {
            Order order = new Order();
            order.AddItem(new SalesItemStub(10.0M, 1.0M));

            decimal tax = order.GetOrderSalesTax();

            Assert.AreEqual(1.0M, tax);
 
        }

        [TestMethod]
        public void OrderSingleItemTotalTest()
        {
            Order order = new Order();
            order.AddItem(new SalesItemStub(10.0M, 1.0M));

            decimal total = order.GetOrderTotal();

            Assert.AreEqual(11.0M, total);
        }
    }
}
