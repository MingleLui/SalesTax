using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Manwood.SalesTax.Domain;

namespace Manwood.SalesTax.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();

            o.AddItem(SalesItemFactory.GetSalesItem("book", 12.49M));
            o.AddItem(SalesItemFactory.GetSalesItem("CD", 14.99M, ItemType.Basic));
            o.AddItem(SalesItemFactory.GetSalesItem("chocolate bar", 0.85M));
            Console.WriteLine("Order 1:");
            Console.WriteLine("Order Price: " + o.GetOrderPrice());
            Console.WriteLine("Order Tax: " + o.GetOrderSalesTax());
            Console.WriteLine("Order Total: " + o.GetOrderTotal());

            o = new Order();

            o.AddItem(SalesItemFactory.GetSalesItem("imported chocolates", 10.0M, ItemType.Import));
            o.AddItem(SalesItemFactory.GetSalesItem("imported perfume", 47.5M, ItemType.Basic | ItemType.Import));
            Console.WriteLine("Order 2:");
            Console.WriteLine("Order Price: " + o.GetOrderPrice());
            Console.WriteLine("Order Tax: " + o.GetOrderSalesTax());
            Console.WriteLine("Order Total: " + o.GetOrderTotal());

            o = new Order();

            o.AddItem(SalesItemFactory.GetSalesItem("imported perfume", 27.99M, ItemType.Basic | ItemType.Import));
            o.AddItem(SalesItemFactory.GetSalesItem("perfume", 18.99M, ItemType.Basic));
            o.AddItem(SalesItemFactory.GetSalesItem("pills", 9.75M));
            o.AddItem(SalesItemFactory.GetSalesItem("imported chocolates", 11.25M, ItemType.Import));
            Console.WriteLine("Order 3:");
            Console.WriteLine("Order Price: " + o.GetOrderPrice());
            Console.WriteLine("Order Tax: " + o.GetOrderSalesTax());
            Console.WriteLine("Order Total: " + o.GetOrderTotal());

            Console.ReadLine();

        }
    }
}
