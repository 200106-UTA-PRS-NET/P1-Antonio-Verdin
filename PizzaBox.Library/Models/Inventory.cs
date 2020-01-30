using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
   public class Inventory
    {
        public int? toppingId;
        private string _topping;
        public decimal? price;
        public int? inventory;
        private string _type;

        public string topping
        {
            get => _topping;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string type
        {
            get => _type;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }



    }
}
