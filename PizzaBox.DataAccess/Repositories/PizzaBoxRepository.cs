using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace PizzaBox.DataAccess.Repositories
{
    public class PizzaBoxRepository
    {
        protected readonly DbContext Context;
        public PizzaBoxRepository(DbContext context)
        {
            Context = context;
        }

    }
}

