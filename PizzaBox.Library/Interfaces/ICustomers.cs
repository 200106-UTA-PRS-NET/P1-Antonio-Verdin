using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Interfaces
{
   public interface ICustomers: IRepository<Customers>
    {
        void AddCustomer(Customers cust, Address add);
        IEnumerable<Library.Models.Customers> GetAllCustomers();
        Library.Models.Customers GetCustomerbyId(int id = 1);



    }
}
