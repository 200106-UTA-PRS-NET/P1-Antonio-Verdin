using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
   public class Address
    {
        
       public int customer_id { get; set; }
        private string _City;
        private string _State;
        private string _PhoneNumber;
        private string _Address1;
        private string _Street;
        public string City
        {
            get => _City;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string State
        {
            get => _State;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string PhoneNumber
        {
            get => _PhoneNumber;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string Address1
        {
            get => _Address1;
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException(nameof(value));
                }
            }

        }
        public string Street
        {
            get => _Street;
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
