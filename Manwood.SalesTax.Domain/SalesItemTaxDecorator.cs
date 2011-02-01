using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public class SalesItemTaxDecorator: ISalesItem
    {
        protected ISalesItem _decoratedSalesItem;
        protected ITax _salesTax;

        public SalesItemTaxDecorator(ISalesItem salesItem, ITax salesTax)
        {
            this._decoratedSalesItem = salesItem;
            this._salesTax = salesTax;
        }

        #region ISalesItem Members

        public string Name
        {
            get { return _decoratedSalesItem.Name; }
        }

        public virtual decimal GetSalesTax()
        {
            return this._decoratedSalesItem.GetSalesTax() + _salesTax.CalculateTax(this._decoratedSalesItem.GetPrice());
        }

        public virtual decimal GetPrice()
        {
            return this._decoratedSalesItem.GetPrice();
        }

        public virtual decimal GetTotal()
        {
            return this.GetPrice() + this.GetSalesTax();
        }

        #endregion
    }
}
