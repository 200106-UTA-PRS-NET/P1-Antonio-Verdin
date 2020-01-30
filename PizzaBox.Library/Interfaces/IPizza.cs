using PizzaBox.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Interfaces
{
    public interface IPizza: IRepository<Pizza>
    {
        IEnumerable<Library.Models.Pizza> GetPizzasbyOrderId();
    }
}
