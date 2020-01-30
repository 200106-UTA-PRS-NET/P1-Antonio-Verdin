using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Interfaces;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;


namespace PizzaBox.DataAccess.Repositories
{
    public class CustomerRepository : Repository<Customers>, ICustomers { 
        public CustomerRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }
       Library.Models.Customers GetCustomerbyId(int id = 1)
        {
            return Mapper.Map(PizzaBoxContext.Customer.Find(id));
        }
        void ICustomers.AddCustomer(Customers cust, Address add)
        {

            PizzaBoxContext.Addressing.Add(Mapper.Map(add));
            PizzaBoxContext.SaveChanges();
            var temp =   PizzaBoxContext.Orders.OrderByDescending(p =>p.CustomerId==add.customer_id ).FirstOrDefault();
            cust
            PizzaBoxContext.Customer.Add(Mapper.Map(cust));
            PizzaBoxContext.SaveChanges();

        }

        IEnumerable<Customers> ICustomers.GetAllCustomers()
        {
            var query = from e in PizzaBoxContext.Customer
                        select Mapper.Map(e);
            return query;
            
        }

        Customers ICustomers.GetCustomerbyId(int id)
        {
            throw new NotImplementedException();
        }
        
    }
}

