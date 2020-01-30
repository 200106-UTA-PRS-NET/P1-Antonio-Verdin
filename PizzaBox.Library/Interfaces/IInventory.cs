using PizzaBox.Library.Models;
using System.Collections.Generic;
/// <summary>
/// This Class is to extend the system to show running inventory. 
/// As well as provide A lookup for Stocked Pizza Ingredients.
/// </summary>
namespace PizzaBox.Library.Interfaces
{
    public interface IInventory: IRepository<Inventory>
    {
        IEnumerable<Library.Models.Inventory> GetAllToppings();

    }
}
