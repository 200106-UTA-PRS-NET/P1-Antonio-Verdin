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

        public static object Map(bool v)
        {
            throw new NotImplementedException();
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

        public static Customer Map(Customers cust)
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

        public static Library.Models.Store Map(Models.Store store)
        {
            return new Library.Models.Store(){
                storename = store.Name,
                id = store.Id
            };

        }
        public static Library.Models.Orders Map(Models.Orders orders)
        {
            return new Library.Models.Orders{
                Id = orders.Id,
                TotalPrice = orders.TotalPrice,
                PlaceDate = orders.PlaceDate,
                DeliveryDate = orders.DeliveryDate,
                StoreId = orders.StoreId
                
            };
        }
        public static Models.Orders Map(Library.Models.Orders orders) {
            return new Models.Orders{
                Id = orders.Id,
                TotalPrice= orders.TotalPrice,
                PlaceDate = DateTime.Now,
                StoreId = orders.StoreId

            }; }


    }
}
