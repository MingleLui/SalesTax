using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manwood.SalesTax.Domain
{
    public static class SalesItemFactory
    {
        private static readonly Rounding ROUNDING = new Rounding(0.05M);
        private static readonly ITax BASICTAX = new Tax(0.1M, ROUNDING);
        private static readonly ITax IMPORTTAX = new Tax(0.05M, ROUNDING);

        private static readonly Dictionary<ItemType, ITax> itemTaxLookup = new Dictionary<ItemType, ITax>()
        {
            { ItemType.Basic, BASICTAX },
            { ItemType.Import, IMPORTTAX }
        };

        public static ISalesItem GetSalesItem(string name, decimal price, ItemType itemType)
        {
            ISalesItem item = new SalesItem(name, price);

            foreach (int flag in Enum.GetValues(typeof(ItemType)))
            {
                if ((flag & (int)itemType) == flag)
                {
                    item = (ISalesItem)Activator.CreateInstance(typeof(SalesItemTaxDecorator), new object[] { item, itemTaxLookup[(ItemType)flag] });
                }
            }
            
            return item;
        }

        public static ISalesItem GetSalesItem(string name, decimal price)
        {
            return new SalesItem(name, price);
        }
    }
}
