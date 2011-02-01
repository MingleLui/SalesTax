using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public class SalesItem : ISalesItem
    {
        private string _name;
        private decimal _price;

        public SalesItem(string name, decimal price)
        {
            #region Parameter Checking
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("name");
            if(price < 0)
                throw new ArgumentException("price");
            #endregion

            this._name = name;
            this._price = price;
        }

        #region ISalesItem Members

        public string Name
        {
            get { return this._name; }
        }

        public decimal GetPrice()
        {
            return this._price;
        }

        public decimal GetSalesTax()
        {
            return 0.0M;
        }

        public decimal GetTotal()
        {
            return this.GetPrice() + this.GetSalesTax();
        }

        #endregion
    }
}
