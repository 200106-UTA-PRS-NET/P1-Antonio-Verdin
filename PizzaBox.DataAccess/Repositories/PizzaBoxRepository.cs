using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaBox.DataAccess.Repositories
{
    public class PizzaBoxRepository
    {
        protected readonly PizzaBoxContext Context;
        public PizzaBoxRepository(PizzaBoxContext context)
        {
            Context = context;
        }
        void AddCustomer(Customers cust, Address add)
        {

            Context.Addressing.Add(Mapper.Map(add));
            Context.SaveChanges();
            var temp = Context.Addressing.FirstOrDefault();
            cust.id = temp.CustomerId;
            Context.Customer.Add(Mapper.Map(cust));
            Context.SaveChanges();
        }
        PizzaBox.Library.Models.Customers FindCustomer(int id = 1)
        {
            return Mapper.Map(Context.Customer.FirstOrDefault(e => e.Id == id));

        }
        IEnumerable<Library.Models.Store> GetStores()
        {
            return Context.Store.Select(o => Mapper.Map(o)).ToList();
        }
        IEnumerable<Inventory> GetToppings()
        {
            return Context.Ingredients.Select(o => Mapper.Map(o)).ToList();
        }
        PizzaBox.Library.Models.Orders GetPizzas(int id = 1)
        {
            return Mapper.Map(Context.Orders.FirstOrDefault(e => e.Id == id));
        }
        void OrderPizza(Library.Models.Pizza pizza, Library.Models.Orders ord) {
            Context.Orders.Add(Mapper.Map(ord));
            Context.SaveChanges();

        }
    }

}

