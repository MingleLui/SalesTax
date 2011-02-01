using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Manwood.SalesTax.Domain
{
    public class Order
    {
        private Collection<ISalesItem> _items = new Collection<ISalesItem>();

        public Order()
        {

        }

        public void AddItem(ISalesItem item)
        {
            this._items.Add(item);
        }

        public decimal GetOrderPrice()
        {
            decimal total = 0.0M;
            foreach (var item in this._items)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public decimal GetOrderSalesTax()
        {
            decimal total = 0.0M;
            foreach (var item in this._items)
            {
                total += item.GetSalesTax();
            }
            return total;
        }

        public decimal GetOrderTotal()
        {
            return this.GetOrderPrice() + this.GetOrderSalesTax();
        }
    }
}
