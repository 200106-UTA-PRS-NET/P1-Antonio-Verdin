using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.DataAccess.Repositories
{
    class UserRepository:Repository<User>
    {
        public UserRepository(PizzaBoxContext context)
: base(context)
        {
        }
        public PizzaBoxContext PizzaBoxContext
        {
            get { return Context as PizzaBoxContext; }
        }
    }
}
