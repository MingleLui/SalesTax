using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public class SalesTaxConfiguration
    {
        public static readonly Guid BASIC;

        public static readonly Dictionary<Guid, ITax> ItemTypes;

        static SalesTaxConfiguration()
        {
            ItemTypes = new Dictionary<Guid, ITax>();
            BASIC = new Guid();
        }
    }
}
