using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public interface ISalesItem
    {
        string Name { get; }
        decimal GetPrice();
        decimal GetSalesTax();
        decimal GetTotal();
    }
}
