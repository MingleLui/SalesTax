using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manwood.SalesTax.Domain;

namespace Manwood.SalesTax.Tests.Stubs
{
    public class SalesItemStub: ISalesItem
    {
        private decimal _price;
        private decimal _tax;

        public SalesItemStub(decimal price, decimal tax)
        {
            this._price = price;
            this._tax = tax;
        }

        #region ISalesItem Members

        public string Name
        {
            get { return "SalesItemStub"; }
        }

        public decimal GetPrice()
        {
            return this._price;
        }

        public decimal GetSalesTax()
        {
            return this._tax;
        }

        public decimal GetTotal()
        {
            return this.GetPrice() + this.GetSalesTax();
        }

        #endregion
    }
}
