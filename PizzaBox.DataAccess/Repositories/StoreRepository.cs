using PizzaBox.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.DataAccess.Repositories
{
    class StoreRepository:Repository<Store>
    {
        public StoreRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }

    }
}
