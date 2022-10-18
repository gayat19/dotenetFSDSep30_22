using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models
{
    public class OrderDetails
    {
        public int OrderId { get; set; }

        public int  PizzaId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }
    }
}
