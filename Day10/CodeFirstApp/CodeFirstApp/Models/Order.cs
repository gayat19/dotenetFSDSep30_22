using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApp.Models
{
    public class Order
    {
        [Key]
        public int OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

    }
}
