using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Models
{
    public class PizzaStoreContext: DbContext
    {
        public PizzaStoreContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-86CRKFR\SQLEXPRESS;user id=sa;password=P@ssw0rd;Initial Catalog=dbPizzaStote14Oct22");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeding the value
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza() { Id=101,Name="SimplePIzza",Price=100.0f,Pic="/images/Pic1.jpg"}
                );
            modelBuilder.Entity<OrderDetails>().HasKey(od => new { od.OrderId, od.PizzaId });

        }
    }
}
