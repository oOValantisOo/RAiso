using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCart_Item> Carts { get; set; }
    }
    public class ShoppingCart_Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}