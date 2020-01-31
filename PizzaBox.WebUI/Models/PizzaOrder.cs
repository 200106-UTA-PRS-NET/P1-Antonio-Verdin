using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaBox.WebUI.Models
{
    public class PizzaOrder
    {
        public class PizzaOrde
        {
            public Pizza Pizzas { get; set; }
        }

        public enum Pizza
        {
            Hawaiian,
            Pepperoni,
            Sausage,


        }
    }
}
