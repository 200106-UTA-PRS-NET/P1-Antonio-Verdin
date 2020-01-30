using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PizzaBox.DataAccess.Repositories
{
    public class PizzaRepository : Repository<PizzaRepository>
    {
        public PizzaRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }
       /* public IEnumerable<Library.Models.Store> GetStores(string search = null)
        {
            // disable unnecessary tracking for performance benefit
        }*/
        void AddUser(Library.Models.Customers cust, Library.Models.Address add)
        {


        }


    }
}
