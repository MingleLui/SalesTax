using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public interface ITax
    {
        IRounding Rounding { get; }
        decimal Rate { get; }
        decimal CalculateTax(decimal itemPrice);
    }
}
