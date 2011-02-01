using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manwood.SalesTax.Domain;

namespace Manwood.SalesTax.Tests.Stubs
{
    public class RoundingStub: IRounding
    {
        #region IRounding Members

        public decimal Round(decimal valToRound)
        {
            return valToRound;
        }

        #endregion
    }
}
