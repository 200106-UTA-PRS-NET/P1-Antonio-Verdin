using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using PizzaBox.Library.Models;

namespace PizzaBox.DataAccess.Repositories
{
    class StoreRepository:Repository<Library.Models.Store>,IStore
    {
        public StoreRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }

        public void AddStore(Library.Models.Store entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Library.Models.Store> GetAllStores()
        {
            throw new NotImplementedException();
        }
    }
}
