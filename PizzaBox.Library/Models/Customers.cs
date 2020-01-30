using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
   public class Customers
    {

        public int? id { get; set; }
        public int? AddressId { get; set; }
        private string _FirstName;
        private string _LastName;
        private string _Password;
       
        public string FirstName
        {
            get => _FirstName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        
        public string LastName
        {
            get => _LastName;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string Password
        {
            get => _Password;
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
