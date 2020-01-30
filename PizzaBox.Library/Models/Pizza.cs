using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
   public class Pizza
    {
      public int? id { get; set; }
      public int? orderId { get; set; }
      public byte amount { get; set; }

      public IList<Inventory> toppings;


    }
}
