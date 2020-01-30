using Microsoft.EntityFrameworkCore;
using PizzaBox.DataAccess.Models;
using PizzaBox.Library.Interfaces;
using PizzaBox.Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.DataAccess.Repositories
{
    public class  InventoryRepository :Repository<Inventory>, IInventory
    { 
            public InventoryRepository(PizzaBoxContext context)
    : base(context)
    {
    }
    public PizzaBoxContext PizzaBoxContext
    {
        get { return Context as PizzaBoxContext; }
    }

        IEnumerable<Inventory> IInventory.GetAllToppings()
        {
            return PizzaBoxContext.Ingredients.Select(Mapper.Map).ToList();
        }
    }
}
