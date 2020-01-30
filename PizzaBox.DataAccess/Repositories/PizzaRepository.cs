using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using PizzaBox.Library.Interfaces;
using System.Linq.Expressions;

namespace PizzaBox.DataAccess.Repositories
{
    public class PizzaRepository : Repository<Library.Models.Pizza>,IPizza
    {
        public PizzaRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }






        public IEnumerable<Library.Models.Pizza> GetPizzasbyOrderId()
        {
            throw new NotImplementedException();
        }




    }
}
