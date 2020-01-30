using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Interfaces;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        IEnumerable<Library.Models.Customers>  GetAllCustomers()
        {
           return PizzaBoxContext.Customer.Select(Mapper.Map).ToList();

        }

        void ICustomers.AddCustomer(Customers cust, Address add)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customers> ICustomers.GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        Customers ICustomers.GetCustomerbyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}

