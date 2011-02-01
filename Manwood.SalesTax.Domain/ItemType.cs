using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    [Flags] 
    public enum ItemType
    {
        Basic = 1,
        Import = 2
    }
}
