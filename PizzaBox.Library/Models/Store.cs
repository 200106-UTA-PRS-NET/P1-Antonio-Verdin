using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
    public class Store
    {
        public int? id;
        private string _storename;
        public string storename
        {
            get => _storename;
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
