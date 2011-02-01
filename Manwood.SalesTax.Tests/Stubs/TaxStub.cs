using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public class TaxStub : ITax
    {
        private decimal _rate;

        public TaxStub(decimal rate)
        {
            this._rate = rate;
        }

        #region ISalesTax Members

        public decimal Rate
        {
            get { return this._rate; }
        }

        public IRounding Rounding
        {
            get { return null; }
        }

        public virtual decimal CalculateTax(decimal itemPrice)
        {
            return itemPrice * this.Rate;
        }

        #endregion
    }
}
