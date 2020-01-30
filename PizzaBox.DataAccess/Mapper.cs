using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaBox.DataAccess
{
    public class Mapper
    {

        public static Customers Map(Customer items)
        {
            return new Customers()
            {
                FirstName = items.FirstName,
                LastName = items.LastName,
                

            };
        }
        public static Address Map(Addressing address)
        {
            return new Address()
            {
                City = address.Address2,
               

            };
        }
        public static Addressing Map(Address address)
        {
            return new Addressing()
            {
                Address2 = address.City,
                Address1 = address.Address1,
                Street = address.Street,
                PhoneNumber= address.PhoneNumber             
            };
        }
        public static Inventory Map(Ingredients ingredients)
        {
            return new Inventory
            {

                topping = ingredients.Topping,
                price = ingredients.Price,
                type = ingredients.Type

            };
        }

        internal static Customer Map(Customers cust)
        {
            throw new NotImplementedException();
        }

        public static Library.Models.Pizza Map(Models.Pizza pizza)
        {
            return new Library.Models.Pizza
            {
                orderId=pizza.OrderId,
                amount = pizza.Amount,
                

            };

        }


    }
}
