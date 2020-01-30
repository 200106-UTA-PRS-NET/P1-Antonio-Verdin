using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Library.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public decimal? TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public DateTime? PlaceDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? StoreId { get; set; }
        public int? EmployeeId { get; set; }
        public int? CustomerId { get; set; }
    }
}
