using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public class Rounding : IRounding
    {
        private decimal _roundTo;

        public Rounding(decimal roundTo)
        {
            this._roundTo = roundTo;
        }

        public decimal Round(decimal valToRound)
        {
            decimal remainder = Decimal.Remainder(valToRound, this._roundTo);
            if (remainder < (this._roundTo / 2))
                return valToRound - remainder;
            else
                return valToRound + (this._roundTo - remainder);
        }

    }
}
