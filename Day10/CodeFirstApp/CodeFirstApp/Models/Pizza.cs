namespace CodeFirstApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Pic { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
